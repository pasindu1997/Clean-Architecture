using AutoMapper;
using AutoMapper.QueryableExtensions;
using Boomerang.Employee.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boomerang.Employee.Application.Designations.Queries.GetDesignations
{
    public class GetDesignationsQuery : IRequest<List<DesignationDto>>
    {
        public class GetDesignationsQueryHandler : IRequestHandler<GetDesignationsQuery, List<DesignationDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetDesignationsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<DesignationDto>> Handle(GetDesignationsQuery request, CancellationToken cancellationToken)
            {
                var list = await _context.Designations
                    .ProjectTo<DesignationDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Name)
                    .ToListAsync(cancellationToken);

                return list;
            }
        }
    }
}
