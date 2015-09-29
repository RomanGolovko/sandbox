using System;
using System.Collections.Generic;
using BusinessLayer.Concrete;
using DataLayer.Abstract;
using DataLayer.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests.BusinessLayer
{
    [TestClass]
    public class BugReportServiceTest
    {
        [TestMethod]
        public void Can_Get_All_Reports()
        {
            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.GetAllReports()).Returns(new List<BugReport>());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.GetAllReports();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Get_Searched_Reports()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.GetAllReports()).Returns(new List<BugReport>());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.GetSearchedReports(report.AssignedTo);
            var emptyResult = service.GetSearchedReports("");

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
                service.GetSearchedReports(wrongQuery);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            // Assert
            Assert.AreEqual(string.Format("There is no bug reports assigned to, or added by {0}", wrongQuery), message);
        }

        [TestMethod]
        public void Can_Get_Report_By_Id()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.GetCurrentReport(report.Id)).Returns(new BugReport());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.GetCurrentReport(report.Id);

            // Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void Can_Catch_Validation_Exception_With_Wrong_Id_In_GetCurrentReport()
        //{
        //    // Arrange
        //    // - create variables / создаем переменные
        //    int wrongId = 8;
        //    string message = "";

        //    // Arrange
        //    // - create the mock repository / создаем макет репозитория
        //    var mock = new Mock<IBugReportRepository>();

        //    // Arrange
        //    // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
        //    BugReportService service = new BugReportService(mock.Object);

        //    // Act
        //    try
        //    {
        //        var wrongIdResult = service.GetCurrentReport(wrongId);
        //    }
        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //    }

        //    // Assert
        //    Assert.AreEqual("Bug report not found", message);
        //}

        //[TestMethod]
        //public void Can_Catch_Validation_Exception_With_Null_Id_In_GetCurrentReport()
        //{
        //    // Arrange
        //    // - create variable / создаем переменную
        //    string message = "";

        //    // Arrange
        //    // - create the mock repository / создаем макет репозитория
        //    var mock = new Mock<IBugReportRepository>();
        //    //mock.Setup(r => r.GetCurrentReport(report.Id)).Returns(new BugReport());

        //    // Arrange
        //    // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
        //    BugReportService service = new BugReportService(mock.Object);

        //    // Act
        //    try
        //    {
        //        var wrongIdResult = service.GetCurrentReport(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //    }

        //    // Assert
        //    Assert.AreEqual("Bug report id not set", message);
        //}

        [TestMethod]
        public void Can_Add_Bug_Report()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.CreateReport(report));

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Assert
            mock.Verify();  // при отсутствии параметров вызывается выражение из mock.Setup
        }

        [TestMethod]
        public void Can_Edit_Bug_Report()
        {
            // Arrange
            // - create an instance of the Bug Report / создаем экземпляр Bug Report
            BugReport report = new BugReport();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IBugReportRepository>();
            mock.Setup(r => r.UpdateReport(report));

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
            mock.Setup(r => r.DeleteReport(report.Id)).Returns(new BugReport());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            BugReportService service = new BugReportService(mock.Object);

            // Act
            var result = service.RemoveReport(report.Id);

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
                service.RemoveReport(null);
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
