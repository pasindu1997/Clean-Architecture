using Boomerang.Employee.Infrastructure.Persistence;
using System;

namespace Boomerang.Employee.Application.UnitTests.Common
{
    public class CommandTestBase : IDisposable
    {
        public CommandTestBase()
        {
           // Context = ApplicationDbContextFactory.Create();
        }

        public ApplicationDbContext Context { get; }

        public void Dispose()
        {
            ApplicationDbContextFactory.Destroy(Context);
        }
    }
}