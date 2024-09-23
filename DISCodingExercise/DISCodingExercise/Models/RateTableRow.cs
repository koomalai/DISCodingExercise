using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISCodingExercise.Models
{
    public class RateTableRow
    {
        public string Job { get; set; }
        public string Dept { get; set; }
        public DateTime EffectiveStart {get; set;}
        public DateTime EffectiveEnd {get; set;}
        public double HourlyRate {get; set;}
    }
}
