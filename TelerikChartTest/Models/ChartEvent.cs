using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikChartTest.Helpers;

namespace TelerikChartTest.Models
{
    public class ChartEvent : Observable
    {
        public ChartEvent()
        {
        }

        public ChartEvent(DateTime time, string description)
        {
            _timeOfEvent = time;
            _eventDescription = description;
        }

        public ChartEvent(object eventStart, object eventEnd, string eventDescription)
        {
            _timeOfEvent = eventStart;
            _eventEnd = eventEnd;
            _eventDescription = eventDescription;
        }

        private string _eventDescription;
        public string EventDescription
        {
            get => _eventDescription;
            set => Set(ref _eventDescription, value);
        }

        private object _timeOfEvent;
        public object EventStart
        {
            get => _timeOfEvent;
            set => Set(ref _timeOfEvent, value);
        }

        private object _eventEnd;
        public object EventEnd
        {
            get => _eventEnd;
            set => Set(ref _eventEnd, value);
        }

        private double _value;
        public double Value
        {
            get => _value;
            set => Set(ref _value, value);
        }
    }
}
