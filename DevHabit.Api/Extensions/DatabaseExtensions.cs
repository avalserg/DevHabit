using DevHabit.Api.Database;
using Microsoft.EntityFrameworkCore;

namespace DevHabit.Api.Extensions;

public static class DatabaseExtensions
{
    public static async Task ApplyMigrationsAsync(this WebApplication app)
    {
        using IServiceScope scope = app.Services.CreateScope();
        await using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await using ApplicationIdentityDbContext identityDbContext = scope.ServiceProvider.GetRequiredService<ApplicationIdentityDbContext>();

        try
        {
            await dbContext.Database.MigrateAsync();

            app.Logger.LogInformation("ApplicationDatabase migrations applied successfully.");

            await identityDbContext.Database.MigrateAsync();

            app.Logger.LogInformation("ApplicationIdentityDatabase migrations applied successfully.");
        }
        catch (Exception e)
        {
            app.Logger.LogError(e, "An error occurred while applying database migrations.");
            throw;
        }
    }
}
