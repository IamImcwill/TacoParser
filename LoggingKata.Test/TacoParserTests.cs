using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", -84.60189)]
        [InlineData("33.757265,-87.064921,Taco Bell Dor...", -87.064921)]
        [InlineData("33.352214,-84.124288,Taco Bell Locust Grov...", -84.124288)]
        [InlineData("33.796264,-84.224516,Taco Bell Stone Mountain...", -84.224516)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            TacoParser taco = new TacoParser();

            //Act
            ITrackable obj = taco.Parse(line);
            double actual = obj.Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", 33.858498)]
        [InlineData("33.757265,-87.064921,Taco Bell Dor...", 33.757265)]
        [InlineData("33.352214,-84.124288,Taco Bell Locust Grov...", 33.352214)]
        [InlineData("33.796264,-84.224516,Taco Bell Stone Mountain...", 33.796264)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            TacoParser taco = new TacoParser();

            //Act
            ITrackable obj = taco.Parse(line);
            double actual = obj.Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
