using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientDemoBlazor.Models
{
    public class DayForecastModel
    {
        public object Id { get; set; }
        public string Weather_state_name { get; set; }
        public string Applicable_date { get; set; }
        public double Min_temp { get; set; }
        public double Max_temp { get; set; }
    }
}
