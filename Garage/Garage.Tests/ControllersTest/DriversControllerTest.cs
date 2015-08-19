using System.Collections.Generic;
using System.Web.Mvc;
using Garage.BLL.Abstract;
using Garage.BLL.DTO;
using Garage.WebUI.Controllers;
using Garage.WebUI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Garage.Tests.ControllersTest
{
    [TestClass]
    public class DriversControllerTest
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            // Arrange
            var mock = new Mock<IService<DriverDTO>>();
            mock.Setup(a => a.GetAll()).Returns(new List<DriverDTO>());
            DriversController controller = new DriversController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void DetailsViewModelNotNull()
        {
            // Arrange
            DriverDTO driver = new DriverDTO();
            var mock = new Mock<IService<DriverDTO>>();
            mock.Setup(a => a.GetCurrent(driver.Id)).Returns(new DriverDTO());
            DriversController controller = new DriversController(mock.Object);

            // Act
            ViewResult result = controller.Details(driver.Id) as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void CreateViewModelNotNull()
        {
            // Arrange
            string expected = "Edit";
            var mock = new Mock<IService<DriverDTO>>();
            DriversController controller = new DriversController(mock.Object);

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.ViewName);
        }

        [TestMethod]
        public void EditViewModelNotNull()
        {
            // Arrange
            DriverDTO driver = new DriverDTO();
            var mock = new Mock<IService<DriverDTO>>();
            mock.Setup(a => a.GetCurrent(driver.Id)).Returns(new DriverDTO());
            DriversController controller = new DriversController(mock.Object);

            // Act
            ViewResult result = controller.Edit(driver.Id) as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void EditPostAction_RedirectToIndexView()
        {
            // Arrange
            string expected = "Index";
            DriverViewModel driver = new DriverViewModel();
            var mock = new Mock<IService<DriverDTO>>();
            DriversController controller = new DriversController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Edit(driver) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void DeletePostAction_RedirectToIndexView()
        {
            // Arrange
            string expected = "Index";
            DriverDTO driver = new DriverDTO();
            var mock = new Mock<IService<DriverDTO>>();
            mock.Setup(a => a.Delete(driver.Id)).Returns(new DriverDTO());
            DriversController controller = new DriversController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Delete(driver.Id) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void DeletePostAction_DeleteModel()
        {
            // Arrange
            DriverDTO driver = new DriverDTO();
            var mock = new Mock<IService<DriverDTO>>();
            DriversController controller = new DriversController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Delete(driver.Id) as RedirectToRouteResult;

            //Assert
            mock.Verify(a => a.Delete(driver.Id));
        }
    }
}
