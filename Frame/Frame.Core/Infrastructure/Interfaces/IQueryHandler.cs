using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.Core.Infrastructure.Interfaces
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
