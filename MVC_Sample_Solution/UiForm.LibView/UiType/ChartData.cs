using DevExpress.XtraCharts;
using Mirero.Wiener.UiForm.LibView.UiType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiForm.LibView.UiType
{
    public class ChartData
    {
        public string Name;
        public string XAxis;
        public string YAxis;
        public Dictionary<string, SeriesItem> SereisDic = new Dictionary<string, SeriesItem>();
    }
}
