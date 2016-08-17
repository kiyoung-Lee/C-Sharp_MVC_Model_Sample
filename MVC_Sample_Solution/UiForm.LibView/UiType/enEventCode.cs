using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiForm.LibView.UiType
{
    public enum enEventCode
    {
        Redraw,

        #region LibView
        Lib_ChangeChart,
        Lib_Change_Config,
        Lib_Change_SelectObj_TrainConfig,
        Lib_Change_SeriesVisible,
        Lib_Change_SereisThickness,
        Lib_Chart_BeginUpdate,
        Lib_Chart_EndUpdate,
        Lib_Change_ChartLogScale,
        #endregion


    }
}
