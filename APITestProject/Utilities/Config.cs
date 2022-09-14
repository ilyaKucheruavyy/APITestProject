using System.Reflection;

namespace APITestProject.Utilities
{
    public static class Config
    {
        public static string Read = Assembly.GetCallingAssembly().Location;
    }
}
