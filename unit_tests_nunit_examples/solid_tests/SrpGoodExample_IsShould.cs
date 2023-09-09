using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using static solid_principles_practice.SRP.SRPGoodExample;

namespace unit_tests_nunit_examples.solid_tests
{

    /// <summary>
    /// Test class for the SRPGoodExample implementation
    /// </summary>
    /// <remarks>
    /// Used real classes for the testing, no fake implementations 
    /// </remarks>
    [TestFixture]    
    public class SrpGoodExample_IsShould
    {
        public Employee employee; 


        /// <summary>
        /// Method that creates employee field dummy for the test cases
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            employee = new Employee();
            employee.FullName = "Test";
            employee.ID = 1;
        }

        /// <summary>
        /// Simple test case where we check the return value of <see cref="employee.Add"/>
        /// </summary>
        /// <remarks>
        /// Test is made following AAA pattern:
        /// Arrange|Act|Assert
        /// Arrange: employee stub is created 
        /// Act: <see cref="employee.Add"/> method called and result saved
        /// Assert: checking if value equals true
        /// </remarks>
        [Test] 
        public void EmployeeAdd_ShouldReturnTrue()
        {
            var employeeStub = new Employee();

            var res = employee.Add(employeeStub); 

            Assert.IsTrue(res);
        }

    }
}
