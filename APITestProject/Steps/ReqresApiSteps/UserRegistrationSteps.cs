using APITestProject.API.Reqres;
using APITestProject.DTO;
using APITestProject.Extensions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using APITestProject.Helpers;

namespace APITestProject.Steps.ReqresApiSteps
{
    [Binding]
    public class UserRegistrationSteps : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private RestResponse _response;

        public UserRegistrationSteps(RestWebClient client, RestResponse response)
        {
            _client = client;
            _response = response;
        }

        [When(@"Registration user with following data")]
        public void WhenRegistrationUserWithFollowingData(Table table)
        {
            var body = table.CreateInstance<UsersInfoDTO>();
            _response = _client.Reqres.InitApiMethods<RegistrationMethods>().PostUserRegistration(body);
        }

        [When(@"Login user with following data")]
        public void WhenLoginUserWithFollowingData(Table table)
        {
            var body = table.CreateInstance<UsersInfoDTO>();
            _response = _client.Reqres.InitApiMethods<RegistrationMethods>().PostUserLogin(body);
        }

        [Then(@"User get response after successful registration")]
        public void ThenUserGetResponseAfterSuccessfulRegistration(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode, "Incorrect status code");
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }

        [Then(@"User get response after successful login")]
        public void ThenUserGetResponseAfter(Table table)
        {
            Assert.AreEqual(HttpStatusCode.OK, _response.StatusCode, "Incorrect status code");
            var expectedData = table.CreateInstance<UsersInfoDTO>();
            var actualData = JsonConvert.DeserializeObject<UsersInfoDTO>(_response.Content);
            Assert.AreEqual(expectedData, actualData, "Incorrect data");
        }
    }
}
