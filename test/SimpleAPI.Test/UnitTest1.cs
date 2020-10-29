using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        private static ILogger<WeatherForecastController> _logger;
        WeatherForecastController controller = new WeatherForecastController(_logger);

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get();
            Assert.NotEmpty(returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
