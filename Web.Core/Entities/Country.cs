using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Entities
{
    public class Country:Entity
    {
        public string CountryName { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
