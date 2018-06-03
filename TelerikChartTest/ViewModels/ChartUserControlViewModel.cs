using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Chart;
using TelerikChartTest.Helpers;
using TelerikChartTest.Models;

namespace TelerikChartTest.ViewModels
{
    public class ChartUserControlViewModel : Observable
    {
        public ChartUserControlViewModel()
        {
        }

        internal void UpdateValues(ChartDataContext chartDataContext)
        {
            var item = chartDataContext.ClosestDataPoint.DataPoint.DataItem as ChartModel;
            //this.DateLabel = item.ProcesTime.ToString("hh:mm");

            this.TValue = item.Value;

            this.AvValue = (double)chartDataContext.DataPoints.Where(c => c.Series is IndicatorBase).First().DataPoint.Label;
        }

        private ChartDataContext trackBallContext;
        public ChartDataContext TrackBallContext
        {
            get => trackBallContext;
            set => Set(ref trackBallContext, value);
        }

        private string dateLabel;
        public string DateLabel
        {
            get => dateLabel;
            set => Set(ref dateLabel, value);
        }

        private double tValue;
        public double TValue
        {
            get => tValue;
            set => Set(ref tValue, value);
        }

        private double avValue;
        public double AvValue
        {
            get => avValue;
            set => Set(ref avValue, value);
        }
    }
}
