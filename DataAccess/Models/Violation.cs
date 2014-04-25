using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Violation
    {
        public int ViolationId {get; set;}
        public string PolicyNumber { get; set; }
        public int DriverNumber {get; set; }
        public string ViolationName { get; set; }
        public string Points { get; set; }
    }
}
