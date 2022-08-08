using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APITestProject.Extensions
{
    public static class StringExtensions
    {
        public static string ByKey(this string assemblyPath, string key)
        {
            var path = Directory.GetParent(assemblyPath).GetFiles("appsettings.json").First().FullName;
            using (StreamReader streamReader = new StreamReader(path))
            {
                try
                {
                    string configFileContent = streamReader.ReadToEnd();

                    var responseContent = JsonConvert.DeserializeObject<JObject>(configFileContent);
                    string value = responseContent[key].ToString();

                    return value;
                }
                catch (Exception e)
                {
                    throw new Exception($"Unable to read configuration property for '{key}' key: {e}");
                }
            }
        }
    }
}
