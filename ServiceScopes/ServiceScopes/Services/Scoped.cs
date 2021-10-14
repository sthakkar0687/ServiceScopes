using ServiceScopes.Services.Interfaces;

namespace ServiceScopes.Services
{
    public class Scoped : IScoped
    {
        public static int ScopedCount { get; set; }
        public Scoped()
        {
            ScopedCount = ScopedCount + 1;
        }

        public int GetScopedCount()
        {
            return ScopedCount;
        }
    }
}
