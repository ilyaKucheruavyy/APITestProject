using System.Net;
using APITestProject.API.Reqres;
using APITestProject.Extensions;
using APITestProject.Helpers;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace APITestProject.Steps.ReqresApiSteps
{
    [Binding]
    public class UserDeleteSteps : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private RestResponse _response;

        public UserDeleteSteps(RestWebClient client, RestResponse response)
        {
            _client = client;
            _response = response;
        }

        [When(@"Delete '(.*)' user")]
        public void WhenDeleteUser(int userId)
        {
            _response = _client.Reqres.InitApiMethods<DeleteMethods>().DeleteUser(userId);
        }

        [Then(@"User get response after successful deleted")]
        public void ThenUserGetResponseAfterSuccessfulDeleted()
        {
            Assert.AreEqual(HttpStatusCode.NoContent, _response.StatusCode);
        }
    }
}
