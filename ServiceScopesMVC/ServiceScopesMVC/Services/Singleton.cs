using ServiceScopesMVC.Services.Interfaces;

namespace ServiceScopesMVC.Services
{
    public class Singleton : ISingleton
    {
        public static int SingletonCount { get; set; }
        public Singleton()
        {
            SingletonCount = SingletonCount + 1;
        }

        public int GetSingletonCount()
        {
            return SingletonCount;
        }
    }
}
