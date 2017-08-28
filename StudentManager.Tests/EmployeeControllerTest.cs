using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManager.Web.Controllers;
using System.Web.Mvc;
using Telerik.JustMock;
using StudentManager.Web.Models;
using System.Linq;

namespace StudentManager.Tests
{
    /// <summary>
    /// Summary description for EmployeeControllerTest
    /// </summary>
    [TestClass]
    public class EmployeeControllerTest
    {
        #region "Local Variables and Declarations"
        
        private List<Employee> mockEmployeeList = new List<Employee>()
        {
            new Employee{
                ID = 1,
                FirstName = "Allan",
                LastName = "Wilkins",
                JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age = 23
            },

            new Employee{
                ID = 2,
                FirstName = "Carson",
                LastName = "Jenkins",
                JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age = 45
            },

            new Employee{
                ID = 3,
                FirstName = "Carson",
                LastName = "Jake",
                JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age = 37
            },
            new Employee{
                ID = 4,
                FirstName = "Laura",
                LastName = "Paul",
                JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                Age = 26
            }
        };

        #endregion

        #region "Constructor"
        
        public EmployeeControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region "Test Methods"

        [TestMethod]
        public void Index_Action_Not_Null()
        {
            //Arrange 
            EmployeeController controller = new EmployeeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index_Returns_All_Employees_in_DB()
        {
            //Arrange
            var employeeRepository = Mock.Create<IRepository>();
            Mock.Arrange(() => employeeRepository.GetAll()).
                Returns(mockEmployeeList)
                .MustBeCalled();

            //Act
            EmployeeController controller = new EmployeeController(employeeRepository);
            ViewResult result = controller.Index();
            var model = result.Model as IEnumerable<Employee>;

            //Assert
            Assert.AreEqual(4, model.Count());
        }
        [TestMethod]
        public void Find_By_FirstName_Returns_All_by_Name_in_DB()
        {
            //Arrange
            var employeeRepository = Mock.Create<IRepository>();
            Mock.Arrange(() => employeeRepository.GetAll()).
                Returns(mockEmployeeList)
                .MustBeCalled();

            //Act
            EmployeeController controller = new EmployeeController(employeeRepository);
            ViewResult result = controller.FindByName("Carson");
            var model = result.Model as IEnumerable<Employee>;

            //Assert
            Assert.AreEqual(2, model.Count());
            Assert.AreEqual("Jenkins", model.ToList()[0].LastName);
            Assert.AreEqual("Jake", model.ToList()[1].LastName);
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

    }
}
