using System.Reflection;

namespace APITestProject.Utilits
{
    public static class Config
    {

        public static string Read = Assembly.GetCallingAssembly().Location;
    }
}
