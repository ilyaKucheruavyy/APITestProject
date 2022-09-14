using Newtonsoft.Json;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITestProject.DTO
{
    public class DataForListOfTheUserDto
    {
        [JsonProperty("first_name")] public string FirstName { get; set; }

        [JsonProperty("last_name")] public string LastName { get; set; }

        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }

        [JsonProperty("data")] public List<DataForListOfTheUserDto> listOfData { get; set; } 

        public override bool Equals(object? obj) => this.Equals(obj as DataForListOfTheUserDto);

        public bool Equals(DataForListOfTheUserDto obj)
        {
            Assert.IsNotEmpty(obj.ID, "ID field is empty");
            Assert.AreEqual(this.Email, obj.Email, "Incorrect email");
            Assert.AreEqual(this.FirstName, obj.FirstName, "Incorrect first name");
            Assert.AreEqual(this.LastName, obj.LastName, "Incorrect last name");
            Assert.IsNotEmpty(obj.Avatar, "Avatar field is empty");

            return true;
        }

        public DataForListOfTheUserDto ListOfData(Table table)
        {
            var data = table.CreateSet<DataForListOfTheUserDto>().ToList();
            this.listOfData = data;
            return this;
        }
    }
}
