using Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AssemblyCorruption.Client
{
    internal static class Breaker
    {
        internal static async Task TestExerciseReflectionAsync(Assembly assembly, Action<string> iterationUpdate)
        {
            var random = new Random();
            for (var x = 0; x < 1000; x++)
            {
                // allocate memory that appears to cause assembly corruption
                for (int y = 0; y < 100; y++)
                {
                    var memory = new byte[1024 * 100];
                    random.NextBytes(memory);
                }

                // the delay allows GC to occur
                GC.Collect();
                await Task.Delay(1000);
                iterationUpdate(x.ToString() + ":start");
                var name = assembly.GetName().Name;
                if (name != "DynamicAssembly")
                    throw new ArgumentOutOfRangeException($"The assembly has the wrong name: {name}");
                
                // the next bit of code will fail with a cast exception
                var invokableMethods = assembly
                                .GetExportedTypes()
                                .SelectMany(type => type.GetMethods(
                                    BindingFlags.Public |
                                    BindingFlags.DeclaredOnly |
                                    BindingFlags.Instance |
                                    BindingFlags.Static));
                foreach (var method in invokableMethods)
                {
                    var parameterTypes = method.GetParameters().Select(p => p.ParameterType).ToArray();
                }

                foreach (var dmType in assembly.GetTypes().Where(t => t.IsClass))
                {
                    var type = Assembly.Load(dmType.Assembly.GetName()).GetType(dmType.FullName);
                    // the type is null the on the second iteration of the loop
                    if (type == null)
                        throw new ApplicationException($"Type name {dmType.FullName} retrieved from assembly does not exist in the assembly {assembly.GetName()}");
                    var inst = Activator.CreateInstance(type);
                    foreach (var prop in type.GetProperties())
                    {
                        prop.GetValue(inst);
                        if (typeof(Guid) == prop.PropertyType)
                            prop.SetValue(inst, Guid.NewGuid());
                        else
                            try
                            {
                                prop.SetValue(inst, null);
                            }
                            catch (Exception) { }
                    }
                }

            }
        }
    }
}