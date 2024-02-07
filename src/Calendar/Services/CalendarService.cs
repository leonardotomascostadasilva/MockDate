using Microsoft.TeamFoundation.Framework.Common;

namespace Calendar.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly ITimeProvider _timeProvider;

        public CalendarService(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public DateTime IsItWednesday()
        {
            var result = _timeProvider.Now;
            return result;
        }
    }
}
