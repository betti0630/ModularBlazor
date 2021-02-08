using System;
using System.Collections.Generic;
using System.Text;

namespace Frame.Core.Infrastructure.Interfaces
{
    public interface IQueryCommand
    {
        string UserId { get; set; }
        string Adopter { get; set; }
    }
}
