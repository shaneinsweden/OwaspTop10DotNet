using System;
using Xunit;
using ErrorReportingService.Controllers;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace ErrorReportingServices.Test
{
    public class ReportingServiceTests
    {
        [Fact]
        public void ReportingService_Get_ReturnsValues()
        {
            //arrange
            ValuesController vc = new ValuesController();

            //act
            var result = vc.Get(10);

            //assert
            Assert.Equal("value", result);
           
        }

        [Fact]
        public void ReportingService_Post_ReturnsValues()
        {
            //arrange
            ValuesController vc = new ValuesController();
            ValidationException error = new ValidationException("Something bad has happened");

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            string exceptionJsonData = JsonConvert.SerializeObject(error, settings);

            //act
            vc.Post(exceptionJsonData);

            //assert

        }

        [Fact]
        public void ReportingService_PostComplex_ReturnsValues()
        {
            //arrange
            ValuesController vc = new ValuesController();

            ValidationException error = new ValidationException("Something bad has happened");

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string exceptionJsonData = JsonConvert.SerializeObject(error, settings);

            //act
            vc.Post(exceptionJsonData);

            //assert

        }

        [Fact]
        public void ReportingService_PostFileInfo_ReturnsValues()
        {
            //arrange
            ValuesController vc = new ValuesController();

            FileInfo fi = new FileInfo("webb.config");

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            string exceptionJsonData = Newtonsoft.Json.JsonConvert.SerializeObject(fi, settings);

            //act
            vc.Post(exceptionJsonData);

            //assert

        }
    }
}
