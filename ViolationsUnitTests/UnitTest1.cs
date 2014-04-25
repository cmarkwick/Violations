using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;


namespace DataAccessUnitTests
{
    [TestClass]
    public class UnitTests
    {
       

        [TestMethod]
        public void CanRetrieveViolations()
        {
            using (var db = new ViolationsContext() )
           { 
                 var violation = db.Violations.FirstOrDefault();
                 Assert.IsTrue(violation.ViolationId == 1);
            }
        }

        [TestMethod]
        public void CanRetrieveDrivers()
        {
            using (var db = new ViolationsContext())
            {
                var driver = db.Drivers.FirstOrDefault();
                Assert.IsTrue(driver.DriverId == 1);
            }
        }
              
           
    }
}
