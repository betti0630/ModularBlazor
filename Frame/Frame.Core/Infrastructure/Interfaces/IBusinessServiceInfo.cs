using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Frame.Core.Infrastructure.Interfaces
{
    public interface IBusinessServiceInfo
    {
        string Name { get; }
        string GetVersion();
        void RegisterService(IServiceCollection services);
    }
}
