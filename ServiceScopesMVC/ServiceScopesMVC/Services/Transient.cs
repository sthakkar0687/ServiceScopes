using ServiceScopesMVC.Services.Interfaces;

namespace ServiceScopesMVC.Services
{
    public class Transient : ITransient
    {
        public static int TransientCount { get; set; }
        public Transient()
        {
            TransientCount = TransientCount + 1;
        }

        public int GetTransientCount()
        {
            return TransientCount;
        }
    }
}
