using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Frame.Blazor.App.Helpers
{
    public static class AssemblyScanning
    {

        public static List<Assembly> GetAssemblies(Type[] types)
        {

            List<Assembly> allAssemblies = new List<Assembly>();

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var files = Directory.GetFiles(path, "*.dll");

            foreach (string dll in files)//.Where(x => Path.GetFileName(x).Contains(nameSpace)))
            {
                //allAssemblies.Add(Assembly.LoadFile(dll));
                var asm = AssemblyLoadContext.Default.LoadFromAssemblyPath(dll);
                allAssemblies.Add(asm);
            }

            var returnAssemblies = new List<Assembly>();
            foreach (var type in types)
            {
                returnAssemblies.AddRange(allAssemblies
                    .Where(w => w.GetTypes().Any(a => a.GetInterfaces().Contains(type))));
            }

            return returnAssemblies.ToList();


        }

        //public static IEnumerable<TypeInfo> GetTypes<T>()
        //{
        //    return GetAssemblies(new Type[] {typeof(T)}).SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(T))));
        //}
        public static IEnumerable<Type> GetTypes<T>()
        {
            return GetAssemblies(new Type[] {typeof(T)}).SelectMany(a => a.GetTypes().Where(x => x.GetInterfaces().Contains(typeof(T))));
        }

        public static  IEnumerable<T> GetInstances<T>()
        {
            List<T> instances = new List<T>();

            foreach (var implementation in GetTypes<T>())
            {
                if (!implementation.GetTypeInfo().IsAbstract)
                {
                    T instance = (T)Activator.CreateInstance(implementation);

                    instances.Add(instance);
                }
            }

            return instances;
        }

    }
}


