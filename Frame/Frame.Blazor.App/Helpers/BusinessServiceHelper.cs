using System;
using System.Collections.Generic;
using System.Linq;
using Frame.Core.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Frame.Blazor.App.Helpers
{
    public class BusinessServiceHelper
    {
        private static IEnumerable<Type> GetBusinessServiceInfoTypes()
        {
            var businessServices = AssemblyScanning.GetTypes<IBusinessServiceInfo>();
            return businessServices;
        }

        public Type GetBusinessServiceTypes<T>() where T : IBusinessServiceInfo
        {
            var businessServices = AssemblyScanning.GetTypes<IBusinessService<T>>();
            return businessServices.FirstOrDefault();
        }

        public static void AddServiceConfig(IServiceCollection services) 
        {
            var businessServiceInfos = GetBusinessServiceInfoTypes();

            foreach (var infoType in businessServiceInfos)
            {
                var getMethod = typeof(BusinessServiceHelper).GetMethod(nameof(BusinessServiceHelper.GetBusinessServiceTypes));
                if (getMethod != null)
                {
                    var getMethodRef = getMethod.MakeGenericMethod(new Type[] {infoType});
                    var businessServiceType = (Type) getMethodRef.Invoke(new BusinessServiceHelper(), null);
                    var businessServiceInterfaceType = typeof(IBusinessService<>).MakeGenericType(new Type[] {infoType});

                    services.AddSingleton(businessServiceInterfaceType, businessServiceType);
                }
            }
        }
  
    }
}
