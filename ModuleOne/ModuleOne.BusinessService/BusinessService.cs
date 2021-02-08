using System;
using Frame.Core.Infrastructure.Interfaces;
using ModuleOne.Logic.QueryHandlers;
using ModuleOne.Shared.Queries;

namespace ModuleOne.BusinessService
{
    public class BusinessService : IBusinessService<ModuleOneService>
    {
        public object ExecuteQuery(dynamic query) 
        {
            if (query.GetType() == typeof(GetPartnerQuery))
            {
                var handler = new PartnerQueryHandler();
                return handler.Handle(query);
            }

            return null;
        }

        public TResult ExecuteCommand<TCommand, TResult>(TCommand command) where TCommand : ICommand<TResult>
        {
            throw new NotImplementedException();
        }
    }
}
