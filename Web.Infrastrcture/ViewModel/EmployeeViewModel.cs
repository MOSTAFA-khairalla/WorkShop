using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Entities;

namespace Web.Infrastrcture.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DataOFBirhData { get; set; }
        public string GraudationYear { get; set; }
        public Degree Degree { get; set; }
        public int YearsOFExperience { get; set; }
        public string CoverLetterFiled { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }
    }
}
