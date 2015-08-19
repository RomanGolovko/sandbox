using System.Collections.Generic;
using Garage.BLL.Concrete;
using Garage.DAL.Abstract;
using Garage.DAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Garage.Tests.BLLTest
{
    [TestClass]
    public class DriverServiceTest
    {
        [TestMethod]
        public void CanGetCurrentDriver()
        {
            //Arrange
            Driver driver = new Driver();
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Drivers.GetCurrent(driver.Id)).Returns(new Driver());
            DriverService service = new DriverService(mock.Object);

            //Act
            var result = service.GetCurrent(driver.Id);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanGetAllDrivers()
        {
            // Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Drivers.GetAll()).Returns(new List<Driver>());
            DriverService service = new DriverService(mock.Object);

            //Act
            var result = service.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanDeleteDriver()
        {
            // Arrange
            Driver driver = new Driver();
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(a => a.Drivers.Delete(driver.Id)).Returns(new Driver());
            DriverService service = new DriverService(mock.Object);

            //Act
            var result = service.Delete(driver.Id);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
