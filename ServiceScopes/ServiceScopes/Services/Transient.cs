using ServiceScopes.Services.Interfaces;

namespace ServiceScopes.Services
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
