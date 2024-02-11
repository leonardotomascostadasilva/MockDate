
namespace Calendar.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly TimeProvider _timeProvider;

        public CalendarService(TimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public DateTime IsItWednesday()
        {
            var result = _timeProvider.GetUtcNow();

            return result.DateTime;
        }
    }
}
