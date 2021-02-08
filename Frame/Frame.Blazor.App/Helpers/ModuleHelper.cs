using System;
using System.Collections.Generic;
using System.Reflection;
using Frame.Blazor.Core;
using Frame.Core.Infrastructure.Interfaces;
using Frame.Core.Infrastructure.Interfaces.Modularization;

namespace Frame.Blazor.App.Helpers
{
    public static class ModuleHelper
    {
        private const string MODULE_NAMESPACE = "BlazorModule";

        public static IEnumerable<IModule> GetModules()
        {
            return AssemblyScanning.GetInstances<IModule>();
        }
        public static IEnumerable<Assembly> GetModuleAssembliess()
        {
           // var asm = AssemblyScanning.GetAssemblies<IModule>(MODULE_NAMESPACE);
            var asm2 = AssemblyScanning.GetAssemblies(new Type[] {typeof(IModule), typeof(IModuleShared), typeof(IModuleBusinessService), typeof(IModuleLogic)});
            //asm.AddRange(asm2);
            return asm2;
        }
    }
}
