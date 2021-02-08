using System;
using System.Collections.Generic;
using System.Text;
using Frame.Core.Infrastructure.Interfaces;

namespace Frame.Core.Infrastructure
{
    public class BaseQueryCommand : IQueryCommand
    {
        public string UserId { get; set; }
        public string Adopter { get; set; }
    }
}
