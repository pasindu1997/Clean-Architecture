using Boomerang.Employee.Application.Common.Interfaces;
using System;

namespace Boomerang.Employee.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
