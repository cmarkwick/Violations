using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess.Models;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;


namespace ViolationsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void CanRetrieveViolations()
        {
            using (var db = new ViolationsContext() )
           { 
                //db.Violations.Add(new Violation{DriverNumber = 1, Points="0", PolicyNumber= "123456789", ViolationName = "Failure to Yield" });
                //db.SaveChanges();
                 var violation = db.Violations.FirstOrDefault();
                 Assert.IsTrue(violation.ViolationId == 1);
            }
        }
              
           
    }
}
