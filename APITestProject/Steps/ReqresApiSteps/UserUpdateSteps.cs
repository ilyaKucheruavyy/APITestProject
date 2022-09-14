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
    public class UserUpdateSteps : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private RestResponse _response;

        public UserUpdateSteps(RestResponse response, RestWebClient client)
        {
            _response = response;
            _client = client;
        }

        [When(@"Update info about '(.*)' user")]
        public void WhenUpdateInfoAboutSingleUser(int userId, Table table)
        {
            var body = table.CreateInstance<UsersInfoDTO>();
            _response = _client.Reqres.InitApiMethods<UpdateMethods>().PutUpdateInfo(body, userId);
        }

        [Then(@"User get response after successful updated")]
        public void ThenUserGetResponseAfterSuccessfulUpdated(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode, "Incorrect status code");
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }
    }
}
