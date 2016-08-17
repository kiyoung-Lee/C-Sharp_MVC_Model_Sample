using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewNCSChartLayout : DevExpress.XtraEditors.XtraUserControl
    {
        public LibViewNCSChartLayout()
        {
            InitializeComponent();

            this.SizeChanged += LibViewNCSChartLayout_SizeChanged;
        }

        #region void LibViewNCSChartLayout_SizeChanged(object sender, EventArgs e)
        private void LibViewNCSChartLayout_SizeChanged(object sender, EventArgs e)
        {
            splitContainerControl.SplitterPosition = splitContainerControl.Height / 3;
            splitContainerControlSub.SplitterPosition = splitContainerControlSub.Height / 2;
        }
        #endregion
    }
}
