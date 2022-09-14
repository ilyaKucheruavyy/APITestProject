using Newtonsoft.Json;
using NUnit.Framework;

namespace APITestProject.DTO
{
    public class ListOfTheUserDTO
    {
        [JsonProperty("page")] public string Page { get; set; }

        [JsonProperty("pre_page")] public string PerPage { get; set; }

        [JsonProperty("total")] public string Total { get; set; }

        [JsonProperty("total_pages")] public string TotalPages { get; set; }

        [JsonProperty("data")] public List<UsersInfoDTO> Data { get; set; }

        [JsonProperty("support")] public SupportInfoDto SupportInfo { get; set; }

        public override bool Equals(object obj) => this.Equals(obj as ListOfTheUserDTO);

        public bool Equals(ListOfTheUserDTO obj)
        {
            Assert.AreEqual(this.Page, obj.Page, "Incorrect page");
            Assert.AreEqual(this.PerPage, obj.PerPage, "Incorrect per page");
            Assert.AreEqual(this.Total, obj.Total, "Incorrect total");
            Assert.AreEqual(this.TotalPages, obj.TotalPages, "Incorrect total pages");

            return true;
        }
    }
}
