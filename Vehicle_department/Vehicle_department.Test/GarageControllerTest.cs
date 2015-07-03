using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Garage.Domain;
using Garage.Infrastructure;

namespace Vehicle_department.Test
{
    [TestClass]
    public class GarageControllerTest
    {
        #region Create
        [TestMethod]
        public void CanAddDriver()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.UpsertDriver("Ivanov Ivan", DateTime.Parse("3.6.1969"),
                "B", "(067) 569-32-23", DateTime.Parse("1.12.2015"), id.ToString(), true);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanAddVehicle()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            Guid driverId = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.UpsertVehicle("BMW 525i", "255-98AA", "Black",
                DateTime.Parse("15.12.2010"), "123456789", "99587", DateTime.Parse("1.12.2015"),
                driverId.ToString(), id.ToString(), true);

            // Assert
            Assert.IsTrue(result);
        }
        #endregion
        #region Read
        [TestMethod]
        public void CanBindDriver()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            string result = "";
            mock.Setup(d => d.Drivers).Returns(new Driver[] {
                new Driver
                {
                Name = "Ivanov Ivan",
                BirthDate = DateTime.Parse("3.6.1969"),
                Category = "B",
                 PhoneNum = "(067) 569-32-23",
                MedicalCertificate = DateTime.Parse("1.12.2015"),
                Id = id
                }
            }.AsQueryable());

            var repository = new GarageContoller(mock.Object);

            // Act
            var bindedDrivers = repository.BindDrivers();
            foreach (var item in bindedDrivers)
                result = item.Name;

            // Assert
            Assert.AreEqual("Ivanov Ivan", result);
        }

        [TestMethod]
        public void CanBindVehicle()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            Guid driverId = Guid.NewGuid();
            string result = "";
            mock.Setup(v => v.Vehicles).Returns(new Vehicle[] {
                new Vehicle
                {
                Brand = "BMV 525i",
                StateNum = "255-98AA",
                Color = "Black",
                ReleaseDate = DateTime.Parse("15.12.2010"),
                VinCode = "123456789",
                Mileage = 99587,
                Insurance = DateTime.Parse("1.12.2015"),
                DriverId = driverId,
                Id = id
                }
            }.AsQueryable());

            var repository = new GarageContoller(mock.Object);

            // Act
            var bindedVehicles = repository.BindVehicles();
            foreach (var item in bindedVehicles)
                result = item.Brand;

            // Assert
            Assert.AreEqual("BMV 525i", result);
        }
        #endregion
        #region Update
        [TestMethod]
        public void CanEditDriver()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.UpsertDriver("Ivanov Stepan", DateTime.Parse("3.6.1969"), 
                "B", "(067) 569-32-23", DateTime.Parse("1.12.2015"), id.ToString(), false);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanEditVehicle()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            Guid driverId = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.UpsertVehicle("BMW 525i", "255-98AA", "Black",
                DateTime.Parse("15.12.2010"), "123456789", "99587", DateTime.Parse("1.12.2015"), 
                driverId.ToString(), id.ToString(), false);

            // Assert
            Assert.IsTrue(result);
        }
        #endregion
        #region Delete
        [TestMethod]
        public void CanDeleteDrive()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.RemoveDriver(id);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanDeleteVehicle()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            Guid id = Guid.NewGuid();
            var repository = new GarageContoller(mock.Object);

            // Act
            var result = repository.RemoveVehicle(id);

            // Assert
            Assert.IsTrue(result);
        }
        #endregion
    }
}
