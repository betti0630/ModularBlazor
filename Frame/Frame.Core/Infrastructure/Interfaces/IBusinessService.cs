using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Frame.Core.Infrastructure.Interfaces
{
    public interface IBusinessService<TServiceInfo> where TServiceInfo : IBusinessServiceInfo
    {
        object ExecuteQuery(dynamic query);
        //TResult ExecuteQuery<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
        TResult ExecuteCommand<TCommand, TResult>(TCommand command) where TCommand : ICommand<TResult>;
        //TODO: async methods
    }
}
