using System.Reflection;
using System.Runtime.Loader;

namespace DynamicCode
{
    internal class SimpleUnloadableAssemblyLoadContext : AssemblyLoadContext
    {
        public SimpleUnloadableAssemblyLoadContext(): base(true)
        {

        }
        protected override Assembly Load(AssemblyName assemblyName)
        {
            return null;
        }
    }
}
