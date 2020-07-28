using SimpleAPI.Controllers;
using System;
using System.Linq;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            int expectedCount = 5;
            var arr = controller.Get();
            Assert.Equal(arr.Count(), expectedCount);
        }
    }
}
