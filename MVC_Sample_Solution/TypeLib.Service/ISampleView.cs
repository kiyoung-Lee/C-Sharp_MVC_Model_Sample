using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Service
{
    public interface ISampleView
    {
        enProjectCode ProjectCode { get; }
        enUiTypeCode UiTypeCode { get; }

        bool Enabled { get; set; }
        bool Visible { get; set; }
        bool InvokeRequired { get; }

        void Refresh();
        void UpdateView(object sender, EventArgs e);
    }
}
