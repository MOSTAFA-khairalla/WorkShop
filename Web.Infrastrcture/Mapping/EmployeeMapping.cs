using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entities;
using Web.Infrastrcture.ViewModel;

namespace Web.Infrastrcture.Mapping
{
    public class EmployeeMapping:Profile
    {
        public EmployeeMapping()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, Employee>();
        }
    }
}
