using System;
using System.Collections.Generic;
using BLL.Concrete;
using DAL.Abstract;
using DAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests.BLL
{
    [TestClass]
    public class BugReportServiceTest
    {
        [TestMethod]
        public void Can_Get_All_Bug_Reports()
        {
            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.BugReports).Returns(new List<BugReport>());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.GetBugReports();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Get_Current_Bug_Reports()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.BugReports).Returns(new List<BugReport>());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.GetCurrentBugReports(report.assignedTo);
            var emptyResult = service.GetCurrentBugReports("");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(emptyResult);
        }

        [TestMethod]
        public void Can_Catch_Validation_Exception_In_GetCurrentBugReports()
        {
            // Arrange
            // - create variables / создаем переменные
            string wrongQuery = "Abc";
            string message = "";

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            try
            {
                service.GetCurrentBugReports(wrongQuery);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            // Assert
            Assert.AreEqual(string.Format("There is no bug reports assigned to, or added by {0}", wrongQuery), message);
        }

        [TestMethod]
        public void Can_Add_Bug_Report()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.AddBugReport(report));

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Assert
            mock.Verify();  // при отсутствии параметров вызывается выражение из mock.Setup
        }

        [TestMethod]
        public void Can_Delete_Bug_Report()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.DeleteBugReport(report.Id)).Returns(new BugReport());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.DeleteBugReport(report.Id);

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Catch_Validation_Exception_In_DeleteBugReport_Method()
        {
            // Arrange
            // - create variable / создаем переменную
            string message = "";

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            try
            {
                service.DeleteBugReport(null);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            // Assert
            Assert.AreEqual("Bug report id not set", message);
        }
    }
}
