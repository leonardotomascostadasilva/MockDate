using Calendar.Services;
using Microsoft.Extensions.Time.Testing;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace UnitTests
{
    public class CalendarServiceTests
    {
        private readonly CalendarService _calendarService;
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
           _mock
               .GetMock<TimeProvider>()
               .Setup(e => e.GetUtcNow()).Returns(test);

            //Act
            var result = _calendarService.IsItWednesday();

            //Assert
            Assert.Equal(result, test);
        }
        [Fact]
        public void IsItWednesdayWithFakerMock_WhenIsNotWednesday_ReturnFalse()
        {
            //Arrange
            var test = new DateTime(2024, 02, 02);
            var fakeTime = new FakeTimeProvider(test);
            var calendarService = new CalendarService(fakeTime);   

            //Act
            var result = calendarService.IsItWednesday();

            //Assert
            Assert.Equal(result, test);
        }
    }
}