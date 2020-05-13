using PlantsApp.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace XUnitTestProject1
{
    public class Tests
    {
        [Fact]
        public void CheckWeatherCorrectlyParseJSON()
        {
            var json = @"{'weather':[{'id':500,'main':'Rain','description':'light rain','icon':'10n'}],'main':{'temp':284.45,'feels_like':280.49,'temp_min':283.15,'temp_max':285.15,'pressure':1010,'humidity':58},'name':'Wrocław'}";
            var weather = new Weather(json);

            Assert.Equal(284.45, weather.Temperature, 2);
            Assert.Equal(58, weather.Humidity);
            Assert.True(weather.WeatherType.Equals("Rain"));
            Assert.True(weather.Description.Equals("light rain"));
            Assert.True(weather.City.Equals("Wrocław"));
        }
    }
}