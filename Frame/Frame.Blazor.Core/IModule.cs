using System.Collections.Generic;

namespace Frame.Blazor.Core
{
    public interface IModule
    {
        string Name { get; }

        List<NavItem> NavItems { get; }

    }
}
