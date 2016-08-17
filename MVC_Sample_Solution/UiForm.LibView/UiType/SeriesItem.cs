using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiForm.LibView.UiType;

namespace UiForm.LibView.UiType
{
    public class SeriesItem
    {
        //public ViewType ChartType { get; set; }
        public List<ChartValue> Datas { get; set; }
        public bool isVisible { get; set; }
        public Color SeriesColor { get; set; }
        public DashStyle DashStyle { get; set; }
        public int SeriesThickness { get; set; }

        public SeriesItem()
        {
            Datas = new List<ChartValue>();
            isVisible = true;
            DashStyle = DashStyle.Solid;
            SeriesThickness = 3;
        }
    }
}
