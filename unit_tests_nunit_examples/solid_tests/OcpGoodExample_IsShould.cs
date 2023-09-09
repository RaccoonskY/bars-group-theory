using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static solid_principles_practice.OCP.OpenCloseGoodExample;
using static solid_principles_practice.SRP.SRPGoodExample;

namespace unit_tests_nunit_examples.solid_tests
{

    internal class FakeEmployeeReport: IEmployeeReport
    {
        public bool reported = false;
        public FakeEmployeeReport() { }

        public override void GenerateReport(Employee em)
        {
           //report generated
           reported = true;
        }
    }

    [TestFixture]
    public class OcpGoodExample_IsShould
    {

        [Test]
        public void EmployeeReport_GenerateReport_ShouldGenerateReport()
        {
            var mockEmployeeReport = new FakeEmployeeReport();
            var stubEmployee = new Employee();

            mockEmployeeReport.GenerateReport(stubEmployee);
            
            Assert.IsTrue(mockEmployeeReport.reported);
        }

    }
}
