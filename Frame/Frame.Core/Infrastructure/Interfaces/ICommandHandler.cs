using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.Core.Infrastructure.Interfaces
{
    public interface ICommandHandler<in TCommand, out TResult> where TCommand : ICommand<TResult>
    {
        TResult Handle(TCommand command);
    }
}
