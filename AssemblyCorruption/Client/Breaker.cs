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
            for (var x = 0; x < 1000; x++)
            {
                // allocate memory that appears to cause assembly corruption
                var memory = new byte[1024 * 1024 * 10];

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

                string message;
                var serialiser = new DataContractSerializer(typeof(Container[]), new DataContractSerializerSettings
                {
                    PreserveObjectReferences = true,
                    KnownTypes = assembly.GetTypes()
                    .Where(t =>
                        t != typeof(IInterfaceA) && typeof(IInterfaceA).IsAssignableFrom(t)
                    )
                });

                using (var output = new StringWriter())
                using (var writer = new XmlTextWriter(output) { Formatting = Formatting.None })
                {
                    serialiser.WriteObject(writer,
                       assembly.GetTypes()
                       .Where(t => typeof(IInterfaceC).IsAssignableFrom(t))
                       .Select(t=>GenerateObjects(t)).ToArray());
                    message = output.GetStringBuilder().ToString();
                }
                var reader = XmlDictionaryReader.CreateTextReader(
                                new MemoryStream(Encoding.UTF8.GetBytes(message)),
                                XmlDictionaryReaderQuotas.Max);
                var result = (Container[])serialiser.ReadObject(reader, false);
                iterationUpdate(x.ToString() + ":end");

                static IInterfaceC CreateInstance(Type t)
                {
                    var instance = (IInterfaceC)Activator.CreateInstance(t);
                    foreach (var prop in t.GetProperties())
                    {
                        if (typeof(Guid) == prop.PropertyType)
                        {
                            prop.SetValue(instance, Guid.NewGuid());
                        }
                        else if (typeof(string) == prop.PropertyType)
                        {
                            prop.SetValue(instance, "a test string");
                        }
                    }
                    return instance;
                }

                static Container GenerateObjects(Type t)
                {
                    return new Container
                    {
                        TypeName = t.FullName,
                        DataOfType = Enumerable.Range(0, 10).Select(e => CreateInstance(t)).ToArray()
                    };
                }
            }
        }
    

        [DataContract]
        public class Container
        {
            [DataMember]
            public string TypeName { get; set; }

            [DataMember]
            public IInterfaceC[] DataOfType { get; set; }
        }
    }
}