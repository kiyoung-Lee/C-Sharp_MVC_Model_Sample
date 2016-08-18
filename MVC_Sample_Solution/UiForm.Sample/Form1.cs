using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeLib.OriginType;
using TypeLib.Service;

namespace UiForm.Sample
{
    public partial class Form1 : Form, ISampleView
    {
        #region Implementation IView

        #region BindList Code
        public enProjectCode ProjectCode { get; private set; }
        public enUiTypeCode UiTypeCode { get; private set; }
        #endregion

        #region void UpdateView(object sender, EventArgs e)
        public void UpdateView(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        private OriginType _originType = new OriginType();
        private MainAppConfigurator _controllerMain;

        #region Creator
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Init()
        {
            _controllerMain = new MainAppConfigurator(_originType, this);
            _controllerMain.Init();
        }
    }
}
