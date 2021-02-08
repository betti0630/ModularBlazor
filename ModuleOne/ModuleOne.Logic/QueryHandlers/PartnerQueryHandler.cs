using System;
using System.Collections.Generic;
using System.Text;
using Frame.Core.Infrastructure.Interfaces;
using ModuleOne.Shared.Dtos;
using ModuleOne.Shared.Queries;

namespace ModuleOne.Logic.QueryHandlers
{
    public class PartnerQueryHandler : IQueryHandler<GetPartnerQuery, PartnerDto>
    {
        public PartnerDto Handle(GetPartnerQuery query)
        {
            return new PartnerDto()
            {
                Id = 1,
                Name = "Jakab"
            };
        }
    }
}
