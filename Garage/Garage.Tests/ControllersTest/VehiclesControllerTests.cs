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
    public class VehiclesControllerTests
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            // Arrange
            var mock = new Mock<IService<VehicleDTO>>();
            mock.Setup(a => a.GetAll()).Returns(new List<VehicleDTO>());
            VehiclesController controller = new VehiclesController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void SearcViewModelNotNull()
        {
            // Arrange
            string str = "";
            var mock = new Mock<IService<VehicleDTO>>();
            mock.Setup(a => a.Search(str)).Returns(new List<VehicleDTO>());
            VehiclesController controller = new VehiclesController(mock.Object);

            // Act
            PartialViewResult result = controller.Search(str) as PartialViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void DetailsViewModelNotNull()
        {
            // Arrange
            VehicleDTO vehicle = new VehicleDTO();
            var mock = new Mock<IService<VehicleDTO>>();
            mock.Setup(a => a.GetCurrent(vehicle.Id)).Returns(new VehicleDTO());
            VehiclesController controller = new VehiclesController(mock.Object);

            // Act
            ViewResult result = controller.Details(vehicle.Id) as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void CreateViewModelNotNull()
        {
            // Arrange
            string expected = "Edit";
            var mock = new Mock<IService<VehicleDTO>>();
            VehiclesController controller = new VehiclesController(mock.Object);

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
            VehicleDTO vehicle = new VehicleDTO();
            var mock = new Mock<IService<VehicleDTO>>();
            mock.Setup(a => a.GetCurrent(vehicle.Id)).Returns(new VehicleDTO());
            VehiclesController controller = new VehiclesController(mock.Object);

            // Act
            ViewResult result = controller.Edit(vehicle.Id) as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void EditPostAction_RedirectToIndexView()
        {
            // Arrange
            string expected = "Index";
            VehicleViewModel vehicle = new VehicleViewModel();
            var mock = new Mock<IService<VehicleDTO>>();
            VehiclesController controller = new VehiclesController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Edit(vehicle) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void DeletePostAction_RedirectToIndexView()
        {
            // Arrange
            string expected = "Index";
            VehicleDTO vehicle = new VehicleDTO();
            var mock = new Mock<IService<VehicleDTO>>();
            mock.Setup(a => a.Delete(vehicle.Id)).Returns(new VehicleDTO());
            VehiclesController controller = new VehiclesController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Delete(vehicle.Id) as RedirectToRouteResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }

        [TestMethod]
        public void DeletePostAction_DeleteModel()
        {
            // Arrange
            VehicleDTO vehicle = new VehicleDTO();
            var mock = new Mock<IService<VehicleDTO>>();
            VehiclesController controller = new VehiclesController(mock.Object);

            //Act
            RedirectToRouteResult result = controller.Delete(vehicle.Id) as RedirectToRouteResult;

            //Assert
            mock.Verify(a => a.Delete(vehicle.Id));
        }
    }
}
