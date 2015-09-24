using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SEO_Analyzer.BLL.Concrete;
using SEO_Analyzer.DAL.Abstract;
using SEO_Analyzer.DAL.Entities;

namespace SEO_Analyzer.Tests.BLL
{
    [TestClass]
    public class ResultServiceTest
    {
        [TestMethod]
        public void Can_Get_All_Results()
        {
            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(r => r.Results.GetAll()).Returns(new List<Result>());

            // Arrange
            // - create an instance of the Bug Report Service / создаем экземпляр Bug Report Service
            ResultService service = new ResultService(mock.Object);

            // Act
            var output = service.GetResults();

            //Assert
            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void Can_Get_Result()
        {
            // Arrange
            // - create an instance of the Result / создаем экземпляр Result
            Result result = new Result();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(r => r.Results.Get(result.Id)).Returns(new Result());
            mock.Setup(w => w.Words.GetAll()).Returns(new List<Word>());

            // Arrange
            // - create an instance of the Result Service / создаем экземпляр Result Service
            ResultService service = new ResultService(mock.Object);

            // Act
            var output = service.GetResult(result.Id);

            // Assert
            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void Can_Catch_Validation_Exception_With_Null_Id_In_GetResult()
        {
            // Arrange
            // - create variables / создаем переменные
            string message = "";

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IUnitOfWork>();

            // Arrange
            // - create an instance of the Result Service / создаем экземпляр Result Service
            ResultService service = new ResultService(mock.Object);

            // Act
            try
            {
                var output = service.GetResult(null);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            // Assert
            Assert.AreEqual("Result id not set!", message);
        }

        [TestMethod]
        public void Can_Catch_Validation_Exception_With_Wrong_Id_In_GetResult()
        {
            // Arrange
            // - create variables / создаем переменные
            string message = "";
            int wrongId = 8;

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(r => r.Results.Get(-1)).Returns(new Result());

            // Arrange
            // - create an instance of the Result Service / создаем экземпляр Result Service
            ResultService service = new ResultService(mock.Object);

            // Act
            try
            {
                var output = service.GetResult(wrongId);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            // Assert
            Assert.AreEqual("Result not found!", message);
        }

        [TestMethod]
        public void Can_Add_Result()
        {
            // Arrange
            // - create an instance of the Result / создаем экземпляр Result
            Result result = new Result();

            // Arrange
            // - create the mock repository / создаем макет репозитория
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(r => r.Results.Create(result));

            // Arrange
            // - create an instance of the Result Service / создаем экземпляр Result Service
            ResultService service = new ResultService(mock.Object);

            // Assert
            mock.Verify();  // при отсутствии параметров вызывается выражение из mock.Setup
        }
    }
}
