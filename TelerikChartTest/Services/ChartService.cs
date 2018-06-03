using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikChartTest.Models;

namespace TelerikChartTest.Services
{
    public static class ChartService
    {

        //TODO: Ne znam dal ce se morati menjati za svaki chart???
        public static ObservableCollection<ChartModel> GetThredLine()
        {
            var data = new ObservableCollection<ChartModel>();

            for (int j = 0; j < 24; j++)
            {
                data.Add(new ChartModel {  Value = j, ProcesTime = DateTime.Now.AddMinutes(j) });
            }

            for (int j = 25; j < 176; j++)
            {
                data.Add(new ChartModel { Value = j-22, ProcesTime = DateTime.Now.AddMinutes(j) });
            }

            return data;
        }
    }
}
