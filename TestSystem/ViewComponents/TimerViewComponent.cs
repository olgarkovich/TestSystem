using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSystem.ViewComponents
{
    public class TimerViewComponent
    {
        ITimeService timeService;
        public TimerViewComponent(ITimeService service)
        {
            timeService = service;
        }
        public string Invoke()
        {
            return $"Текущее время: {timeService.GetTime()}";
        }
    }

    public interface ITimeService
    {
        public string GetTime();
    }
    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
