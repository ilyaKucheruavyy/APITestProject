using RestSharp;

namespace APITestProject.Base
{
    public interface IBaseApiMethods
    {
        RestClient Client { set; }
    }

}
