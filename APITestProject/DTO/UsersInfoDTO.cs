using Newtonsoft.Json;
using NUnit.Framework;

namespace APITestProject.DTO
{
    public class UsersInfoDTO
    {
        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("first_name")] public string FirstName { get; set; }

        [JsonProperty("last_name")] public string LastName { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("job")] public string Job { get; set; }

        [JsonProperty("password")] public string Password { get; set; }

        [JsonProperty("token")] public string Token { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }

        public override bool Equals(object obj) => this.Equals(obj as UsersInfoDTO);

        public bool Equals(UsersInfoDTO obj)
        {
            Assert.AreEqual(this.ID, obj.ID, "Incorrect ID");
            Assert.AreEqual(this.FirstName, obj.FirstName, "Incorrect first name");
            Assert.AreEqual(this.LastName, obj.LastName, "Incorrect last name");
            Assert.AreEqual(this.Email, obj.Email, "Incorrect email");
            Assert.AreEqual(this.Name, obj.Name, "Incorrect name");
            Assert.AreEqual(this.Job, obj.Job, "Incorrect job");
            Assert.AreEqual(this.Password, obj.Password, "Incorrect password");
            Assert.AreEqual(this.Token, obj.Token, "Incorrect Token");
            Assert.AreEqual(this.Avatar, obj.Avatar, "Incorrect avatar");

            return true;
        }
    }
}
