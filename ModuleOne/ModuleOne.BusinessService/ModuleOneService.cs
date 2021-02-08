using System;
using Frame.Core.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ModuleOne.BusinessService
{
    public class ModuleOneService : IBusinessServiceInfo
    {
        public string Name { get; } = "ModuleOne";

        public string GetVersion()
        {
            throw new NotImplementedException();
        }

        public void RegisterService(IServiceCollection services)
        {
            services.AddSingleton<IBusinessService<ModuleOneService>, BusinessService>();
        }
    }
}
