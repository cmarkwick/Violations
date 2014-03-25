using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string PolicyNumber {get; set;}
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }
        public string DriverLicenceNumber { get; set; }
        public string DriverState {get; set;}
    }
}
