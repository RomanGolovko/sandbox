using System.Collections.Generic;
using Garage.BLL.Concrete;
using Garage.DAL.Abstract;
using Garage.DAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Garage.Tests.BLLTest
{
    [TestClass]
    public class VehicleServiceTests
    {
        [TestMethod]
        public void CanGetCurrentVehicle()
        {
            //Arrange
            Vehicle vehicle = new Vehicle();
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Vehicles.GetCurrent(vehicle.Id)).Returns(new Vehicle());
            VehicleService service = new VehicleService(mock.Object);

            //Act
            var result = service.GetCurrent(vehicle.Id);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanSearchVehicles()
        {
            // Arrange
            string str = "bmw";
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Vehicles.GetAll()).Returns(new List<Vehicle>());
            VehicleService service = new VehicleService(mock.Object);

            //Act
            var result = service.Search(str);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanGetAllVehicles()
        {
            // Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Vehicles.GetAll()).Returns(new List<Vehicle>());
            VehicleService service = new VehicleService(mock.Object);

            //Act
            var result = service.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanDeleteVehicle()
        {
            // Arrange
            Vehicle vehicle = new Vehicle();
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Vehicles.Delete(vehicle.Id)).Returns(new Vehicle());
            VehicleService service = new VehicleService(mock.Object);

            //Act
            var result = service.Delete(vehicle.Id);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
