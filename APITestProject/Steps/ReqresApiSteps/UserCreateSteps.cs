using APITestProject.API.Reqres;
using APITestProject.DTO;
using APITestProject.Extensions;
using APITestProject.Helpers;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITestProject.Steps.ReqresApiSteps
{
    [Binding]
    public class UserCreateSteps : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private RestResponse _response;

        public UserCreateSteps(RestWebClient client, RestResponse response)
        {
            _client = client;
            _response = response;
        }

        [When(@"Create new user with following data")]
        public void WhenCreateNewUserWithFollowingData(Table table)
        {
            var body = table.CreateInstance<UsersInfoDTO>();
            _response = _client.Reqres.InitApiMethods<CreateMethods>().PostCreateNewUser(body);
        }

        [Then(@"User get response after successful created")]
        public void UserGetResponseAfterSuccessfulCreated(Table table)
        {
            Assert.AreEqual(HttpStatusCode.Created, _response.StatusCode, "Incorrect status code");
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }
    }
}
