using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Core
{
    public class UiLibMessage : EventArgs
    {
        public const int LibView = 0x1000000;
        public const int MainFrame = 0x2000000;

        public Enum Code { get; set; }
        public List<object> Parameters { get; private set; }

        public UiLibMessage()
        {
            Parameters = new List<object>();
        }

        public static string GetViewCode(string groupName, string viewName)
        {
            return string.Format("{0}::{1}", groupName, viewName);
        }
    }
}
