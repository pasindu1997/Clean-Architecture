using Boomerang.Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Boomerang.Employee.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<Designation> Designations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
