using System.IO;
using System.Reflection;
using Model;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyLoadTest.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssemblyController : ControllerBase
    {
        [HttpGet]
        public AssemblyData Get() => GetAssemblyBytes(typeof(ReplacedClassName1).Assembly);

        private AssemblyData GetAssemblyBytes(Assembly assembly) =>
            new AssemblyData { AssemblyDllBytes = System.IO.File.ReadAllBytes(assembly.Location), AssemblyPdbBytes = TryGetPdp(assembly.Location) };


        private static byte[] TryGetPdp(string assemblyLocation)
        {
            var pdp = Path.ChangeExtension(assemblyLocation, "pdp");
            return pdp != null && System.IO.File.Exists(pdp) ? System.IO.File.ReadAllBytes(pdp) : null;
        }
        
        public class AssemblyData
        {
            public byte[] AssemblyDllBytes { get; set; }
            public byte[] AssemblyPdbBytes { get; set; }
        }
    }
}
