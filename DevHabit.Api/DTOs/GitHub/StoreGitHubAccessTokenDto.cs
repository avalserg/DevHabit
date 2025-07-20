namespace DevHabit.Api.DTOs.GitHub;

public sealed record StoreGitHubAccessTokenDto
{
    public required string AccessToken { get; set; } = default!;
    public required int ExpiresInDays { get; set; }

}
