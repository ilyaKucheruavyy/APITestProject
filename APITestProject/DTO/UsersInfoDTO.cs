using Newtonsoft.Json;

namespace APITestProject.DTO
{
    public class UsersInfoDTO
    {
        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("first_name")] public string FirstName { get; set; }

        [JsonProperty("last_name")] public string LastName { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("job")] public string Job { get; set; }

        [JsonProperty("password")] public string Password { get; set; }

        [JsonProperty("token")] public string Token { get; set; }
    }
}
