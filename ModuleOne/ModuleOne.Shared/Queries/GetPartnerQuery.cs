using System;
using System.Collections.Generic;
using System.Text;
using Frame.Core.Infrastructure;
using Frame.Core.Infrastructure.Interfaces;
using ModuleOne.Shared.Dtos;

namespace ModuleOne.Shared.Queries
{
    public class GetPartnerQuery : BaseQueryCommand, IQuery<PartnerDto>
    {
        public int PartnerId { get; set; }
    }
}
