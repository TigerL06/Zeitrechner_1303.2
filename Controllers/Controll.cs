using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;

namespace Backend_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controll : ControllerBase
    {
        [HttpPost]
        public IActionResult Time(DateTime time)
        {
            DateTime dateTime = DateTime.Now;
            if (dateTime >= time)
            {
                TimeSpan timedifferenz = dateTime.Subtract(time);
                TimeSpan timedifference = timedifferenz.Duration();
                //ChatGPT
                string zeit = $"{timedifference.Days} Tage, {timedifference.Hours} Stunden, {timedifference.Minutes} Minuten, {timedifference.Seconds} Sekunden";

                return Ok(zeit);
            }
            else
            {
                TimeSpan timedifferenz = time.Subtract(dateTime);
                TimeSpan timedifference = timedifferenz.Duration();
                string zeit = $"{timedifference.Days} Tage, {timedifference.Hours} Stunden, {timedifference.Minutes} Minuten, {timedifference.Seconds} Sekunden";

                return Ok(zeit);
            }
           
     
        }
    }
}
