using System.Collections.Generic;
using Frame.Blazor.Core;

namespace ModuleTwo.BlazorModule
{
    public class Registration : IModule
    {
        public string Name => "Module Two";
        public List<NavItem> NavItems => new List<NavItem> { 
            new NavItem { Name = "Module Two Test", Url = "/test-two" } 
        };
    }
}
