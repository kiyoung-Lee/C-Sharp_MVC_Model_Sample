using System;
using System.Drawing;
using System.Collections.Generic;

namespace UtilLib.ControlLib
{
    public static class UiLibColors
    {
        public static Dictionary<string, Color> ColorTable { get; private set; }

        static UiLibColors()
        {
            ColorTable = new Dictionary<string, Color>();

            ColorTable.Add("GRID_FOCUS_COLOR", System.Drawing.Color.Orange);
            ColorTable.Add("GRID_SELECT_COLOR", System.Drawing.Color.DodgerBlue);
            ColorTable.Add("GRID_CHECKED_COLOR", System.Drawing.Color.Orange);
            ColorTable.Add("GRID_UNCHECKED_COLOR", System.Drawing.Color.SteelBlue);
            ColorTable.Add("GRID_GRAYED_COLOR", System.Drawing.Color.LightGray);
        }

        public static Color Color(string name, Color defaultColor = default(Color))
        {
            return ColorTable.ContainsKey(name) ? ColorTable[name] : defaultColor;
        }
    }
}
