using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Entities
{
    public class Employee:Entity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DataOFBirhData { get; set; }
        public string GraudationYear { get; set; }
        public int DegreeId { get; set; }
        public int YearsOFExperience { get; set; }
        public string CoverLetterFiled { get; set; }

        public int CountryId { get; set; }
        public int CityId { get; set; }

    }
}
