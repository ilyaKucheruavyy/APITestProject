using System.Net;
using APITestProject.API.Reqres;
using APITestProject.DTO;
using APITestProject.Extensions;
using APITestProject.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITestProject.Steps.ReqresApiSteps
{
    [Binding]
    public class UserInfoSteps :  SpecFlowContext
    {
        private readonly RestWebClient _client;
        private RestResponse _response;
        private readonly UsersInfoDTO _usersInfoDto;
        private readonly DataForListOfTheUserDto _dataList;
        private readonly SupportInfoDto _supportInfo;

        public UserInfoSteps(RestWebClient client, RestResponse response, UsersInfoDTO usersInfoDTO, DataForListOfTheUserDto dataList, SupportInfoDto supportInfo)
        {
            _client = client;
            _response = response;
            _usersInfoDto = usersInfoDTO;
            _dataList= dataList;
            _supportInfo = supportInfo;
        }

        [When(@"Get info about '(.*)' user")]
        public void WhenGetInfoAboutUser(int userId)
        {
            _response = _client.Reqres.InitApiMethods<InfoMethods>().GetInfoAboutSingleUser(userId);
        }

        [When(@"Get list of the users from '(.*)' page")]
        public void WhenGetListOfTheUsersFromPage(int pageNumber)
        {
            _response = _client.Reqres.InitApiMethods<InfoMethods>().GetListOfTheUsers(pageNumber);
        }

        [Then(@"User checks page info from response body for list of the users")]
        public void ThenUserChecksPageInfoFromResponseBodyForListOfTheUsers(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
            var expectedData = table.CreateInstance<ListOfTheUserDTO>();
            var actualData = JsonConvert.DeserializeObject<ListOfTheUserDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }

        [Then(@"User checks 'data' class from response body for single user")]
        public void ThenUserChecksDataClassFromResponseBodyForSingleUser(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
            var expectedData = _usersInfoDto.DataAboutSingleUser(table);
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }

        [Then(@"User checks 'support' class from response body")]
        public void ThenUserChecksSupportClassFromResponseBody(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode, "Incorrect status code");
            var expectedData = _supportInfo.GetSupportData(table);
            var actualData = JsonConvert.DeserializeObject<SupportInfoDto>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }

        [Then(@"User checks 'data' class from response body for list of the users")]
        public void ThenUserChecksDataClassFromResponseBodyForListOfTheUsers(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
            var expectedData = _dataList.ListOfData(table);
            var actualData = JsonConvert.DeserializeObject<DataForListOfTheUserDto>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }
    }
}
