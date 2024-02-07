using Calendar.Services;
using Moq.AutoMock;
using Xunit;
using Microsoft.TeamFoundation.Framework.Common;

namespace UnitTests
{
    public class CalendarServiceTests
    {
        private readonly ICalendarService _calendarService;
        private readonly AutoMocker _mock = new();

        public CalendarServiceTests()
        {
            _calendarService = _mock.CreateInstance<CalendarService>();
        }
        [Fact]
        public void IsItWednesday_WhenIsNotWednesday_ReturnFalse()
        {
            //Arrange
            var test = new DateTime(2024, 02, 02);
            _mock.GetMock<ITimeProvider>().Setup(e => e.Now).Returns(test);

            //Act
            var result = _calendarService.IsItWednesday();

            //Assert
            Assert.Equal(result, test);
        }
        [Fact]
        public void IsItWednesday_WhenIsNotWednesday_ReturnTrue()
        {
            //Arrange
            _mock.GetMock<ITimeProvider>().Setup(e => e.Now).Returns(new DateTime(2024, 02, 07));

            //Act
            var result = _calendarService.IsItWednesday();

            //Assert
           
        }
    }
}