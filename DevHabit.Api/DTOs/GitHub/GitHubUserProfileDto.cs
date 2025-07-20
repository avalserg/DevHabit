using DevHabit.Api.DTOs.Common;
using Newtonsoft.Json;

namespace DevHabit.Api.DTOs.GitHub;

public sealed record GitHubUserProfileDto
{

    [JsonProperty("login")]
    public string Login { get; set; } = default!;

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; } = default!;

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("bio")]
    public string? Bio { get; set; }

    [JsonProperty("public_repos")]
    public int PublicRepos { get; set; }

    [JsonProperty("followers")]
    public int Followers { get; set; }

    [JsonProperty("following")]
    public int Following { get; set; }
    public List<LinkDto> Links { get; set; }

}
