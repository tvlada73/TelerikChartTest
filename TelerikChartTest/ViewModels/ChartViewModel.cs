using System;
using System.Collections.ObjectModel;

using TelerikChartTest.Helpers;
using TelerikChartTest.Models;
using TelerikChartTest.Services;

namespace TelerikChartTest.ViewModels
{
    public class ChartViewModel : Observable
    {
        public ChartViewModel()
        {
      
            foreach (var item in SampleDataService.GetChartSampleData())
            {
                Source.Add(item);
            }
        }


        private ObservableCollection<DataPoint> _Source;
        public ObservableCollection<DataPoint> Source => _Source ?? (_Source = new ObservableCollection<DataPoint>());
        

        int a = 856;

        internal void TestButton()
        {
            Source.Clear();
            Source.Add(new DataPoint { ProcesTime = "23:22", Value = a });
            a = ++a;
        }
    }
}
