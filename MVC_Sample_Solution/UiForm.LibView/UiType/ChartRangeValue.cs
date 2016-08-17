using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiForm.LibView.UiType
{
    public class ChartRangeValue : ChartValue
    {
        public double YError { get; set; }
        public double YErrorUpper { get; set; }
        public double YErrorUnder { get; set; }
    }
}
