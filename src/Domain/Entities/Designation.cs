using Boomerang.Employee.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boomerang.Employee.Domain.Entities
{
    public class Designation : AuditableEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
