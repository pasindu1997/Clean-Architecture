using Boomerang.Employee.Application.Common.Interfaces;
using Boomerang.Employee.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Boomerang.Employee.Application.Designations.Commands.CreateDesignation
{
    public partial class CreateDesignationCommand : IRequest<int>
    {
        public string Name { get; set; }

        public class CreateDesignationCommandHandler : IRequestHandler<CreateDesignationCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public CreateDesignationCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(CreateDesignationCommand request, CancellationToken cancellationToken)
            {
                var entity = new Designation();

                entity.Name = request.Name;

                _context.Designations.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
