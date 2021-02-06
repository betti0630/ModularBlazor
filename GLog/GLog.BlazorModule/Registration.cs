using System.Collections.Generic;
using Frame.Blazor.Core;

namespace GLog.BlazorModule
{
    public class Registration : IModule
    {
        public string Name => "GLog";
        public List<NavItem> NavItems => new List<NavItem> { 
            new NavItem { Name = "Loglista", Url = "/gloglist" },
            new NavItem { Name = "Log keresése", Url = "/glogsearch" } 
        };
    }
}
