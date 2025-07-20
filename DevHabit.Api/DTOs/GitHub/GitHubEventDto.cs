using Newtonsoft.Json.Linq;

namespace DevHabit.Api.DTOs.GitHub;

public sealed record GitHubEventDto
{
    public string Id { get; init; } = default!;
    public string Type { get; init; } = default!;

    public GitHubEventActorDto Actor { get; init; } = default!;

    public GitHubEventRepoDto Repo { get; init; } = default!;

    public DateTime CreatedAt { get; init; }

    public JObject Payload { get; init; } = default!;
}

public sealed record GitHubEventActorDto
{
    public int Id { get; init; }

    public string Login { get; init; } = default!;

    public string AvatarUrl { get; init; } = default!;
}

public sealed record GitHubEventRepoDto
{
    public int Id { get; init; }

    public string Name { get; init; } = default!;

    public string Url { get; init; } = default!;
}
