using Calendar.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_calendarService.IsItWednesday());
        }
    }
}
