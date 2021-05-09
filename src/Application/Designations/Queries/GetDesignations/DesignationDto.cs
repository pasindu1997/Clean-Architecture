using AutoMapper;
using Boomerang.Employee.Application.Common.Mappings;
using Boomerang.Employee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boomerang.Employee.Application.Designations.Queries.GetDesignations
{
    public class DesignationDto : IMapFrom<Designation>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Designation, DesignationDto>();
        }
    }
}
