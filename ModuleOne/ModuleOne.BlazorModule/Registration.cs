using System.Collections.Generic;
using Frame.Blazor.Core;

namespace ModuleOne.BlazorModule
{
    public class Registration : IModule
    {
        public string Name => "Module One";
        public List<NavItem> NavItems => new List<NavItem> { 
            new NavItem { Name = "Module One Test", Url = "/test" },
            new NavItem { Name = "Module One Test2", Url = "/test" } 
        };
    }
}
