using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib.ControlLib
{
    public static class UiLibSeriesColorIndex
    {
        static Dictionary<string, Color> ColorTable;
        static Random random;

        static UiLibSeriesColorIndex()
        {
            ColorTable = new Dictionary<string, Color>();
            random = new Random();
        }

        public static Color GetSeriesColor(string key)
        {
            if (ColorTable.ContainsKey(key))
                return ColorTable[key];
            else
            {
                var R = random.Next(1, 255);
                var G = random.Next(1, 255);
                var B = random.Next(1, 255);

                var retColor = Color.FromArgb(R, G, B);
                ColorTable.Add(key, retColor);
                return retColor;
            }
        }
    }
}
