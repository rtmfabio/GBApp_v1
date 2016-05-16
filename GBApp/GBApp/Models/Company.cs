using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBApp.Models
{
    public class Company
    {
        public Int32 ID { get; set; }
        public String DisplayName { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
    }
}
