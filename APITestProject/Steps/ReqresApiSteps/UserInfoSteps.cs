using System.Diagnostics;
using System.Net;
using APITestProject.API.Reqres;
using APITestProject.DTO;
using APITestProject.Extensions;
using APITestProject.Helpers;
using Newtonsoft.Json;
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

        public UserInfoSteps(RestWebClient client, RestResponse response)
        {
            _client = client;
            _response = response;
        }

        [When(@"Get info about '(.*)' user")]
        public void WhenGetInfoAboutUser(int userId)
        {
            _response = _client.Reqres.InitApiMethods<InfoMethods>().GetInfoAboutSingleUser(userId);
        }

        [When(@"Get list of the user from '(.*)' page")]
        public void WhenGetListOfTheUserFromPage(int pageNumber)
        {
            _response = _client.Reqres.InitApiMethods<InfoMethods>().GetListOfTheUsers(pageNumber);
        }

        [Then(@"User get response after successful got list of the user")]
        public void ThenUserGetResponseAfterSuccessfulGotListOfTheUser(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }

        [Then(@"User get response after successful got info about single user")]
        public void ThenUserGetResponseAfterSuccessfulGotInfo(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode);
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }
    }
}
