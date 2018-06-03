using System;
using System.Collections.ObjectModel;
using TelerikChartTest.Helpers;
using TelerikChartTest.Models;
using TelerikChartTest.Services;

namespace TelerikChartTest.ViewModels
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
        }

        internal void AddEventChart()
        {
            EventData.Add(new ChartEvent
            {
                EventStart = Data[Data.Count-1].ProcesTime,
                EventEnd = Data[Data.Count-1].ProcesTime,
                EventDescription = string.Format("Prvi korak", Environment.NewLine),
                Value = 44d
            });
        }


        internal void AddToChart()
        {
            Data.Add(new ChartModel { ProcesTime = new DateTime(2017, 1, 1, hh, min, 0), Value = GetRandomNumber(20, 80) });

            min = ++min;
            if (min == 60)
            {
                hh = ++hh;
                min = 0;
            }
        }

        int hh = 0;
        int min = 0;




        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        private ObservableCollection<ChartModel> data;
        public ObservableCollection<ChartModel> Data => data ?? (data = new ObservableCollection<ChartModel>());

        private ObservableCollection<ChartEvent> eventData;
        public ObservableCollection<ChartEvent> EventData => eventData ?? (eventData = new ObservableCollection<ChartEvent>());

    }
}
