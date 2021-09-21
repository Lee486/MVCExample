using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcExample.Models.ViewModels
{
    public class TimeSeriesData
    {
        public string name { get; set; }
        public List<TimeSeriesDatum> data { get; set; }

        public TimeSeriesData()
        {
            data = new List<TimeSeriesDatum>();
        }
    }

    public class TimeSeriesDatum
    {
        public double production { get; set; }
        public DateTime date { get; set; }

    }
}
