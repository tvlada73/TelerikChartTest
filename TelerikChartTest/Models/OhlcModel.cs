using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikChartTest.Helpers;

namespace TelerikChartTest.Models
{
   public class OhlcModel : Observable
    {
        private static int counter;

        public OhlcModel()
        {
        }

        public OhlcModel(double offset, params double[] values)
        {
            this.open = values[0] + ((counter % 2) == 0 ? offset : -offset);
            this.high = values[1] + 2 * offset;
            this.low = values[2] - 1;
            this.close = values[3] - ((counter % 2) == 0 ? offset : -offset);
            this.volume = values[4];
            this.adjacentClose = values[5] + 2 * offset;

            counter++;
        }

        public OhlcModel(OhlcModel source, double offset)
        {
            date = source.date;
            open = source.open + offset;
            high = source.high + offset;
            low = source.low + offset;
            close = source.close + offset;
            volume = source.volume + offset;
            adjacentClose = source.adjacentClose + offset;
        }


        private DateTime date;
        public DateTime Date
        {
            get => date;
            set => Set(ref date, value);
        }

        private double open;
        public double Open
        {
            get => open;
            set => Set(ref open, value);
        }

        private double high;
        public double High
        {
            get => high;
            set => Set(ref high, value);
        }

        private double low;
        public double Low
        {
            get => low;
            set => Set(ref low, value);
        }

        private double close;
        public double Close
        {
            get => close;
            set => Set(ref close, value);
        }


        private double volume;
        public double Volume
        {
            get => volume;
            set => Set(ref volume, value);
        }


        private double adjacentClose;
        public double AdjacentClose
        {
            get => adjacentClose;
            set => Set(ref adjacentClose, value);
        }
    }
}
