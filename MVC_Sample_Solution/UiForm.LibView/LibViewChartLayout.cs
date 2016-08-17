using System;
using TypeLib.Core;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewChartLayout : DevExpress.XtraEditors.XtraUserControl, ISampleView
    {
        #region Controller I/F
        private IMireroController _iController;
        #endregion

        #region Implementation IView

        #region BindList Code
        public enProjectCode ProjectCode { get; private set; }
        public enUiTypeCode UiTypeCode { get; private set; }
        public enChartCode ChartCode_1 { get; private set; }
        public enChartCode ChartCode_2 { get; private set; }
        #endregion

        #region void UpdateView(object sender, EventArgs e)
        public void UpdateView(object sender, EventArgs e)
        {
            UiLibMessage msg = e as UiLibMessage;
            if (msg != null)
            {
                if (msg.Code is UiType.enEventCode)
                {
                    UiType.enEventCode inCode = (UiType.enEventCode)msg.Code;

                    switch (inCode)
                    {
                        
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Event Handler & Message
        public event EventHandler SendMessage;
        private UiLibMessage _sendMessageData;
        #endregion

        #region Selection Mode
        private bool _isManualMode;
        #endregion

        #region Chart Control
        //GridControl _gridControl;
        //GridView _gridView;
        LibViewChart Chart_1;
        LibViewChart Chart_2;
        #endregion

        #region Creator
        public LibViewChartLayout(ISampleController iController, enChartCode chartCode_1, enChartCode chartCode_2)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            ChartCode_1 = chartCode_1;
            ChartCode_2 = chartCode_2;

            #region Docking Panel UI
            FormUtil.AddDockUserControl(splitContainerControl.Panel1, new UiForm.LibView.LibViewChart(_iController, ChartCode_1));
            FormUtil.AddDockUserControl(splitContainerControl.Panel2, new UiForm.LibView.LibViewChart(_iController, ChartCode_2));
            #endregion

            this.Load += UiLoad;
            SendMessage += iController.CallBackFunc;
            _iController.SendMessage += UpdateView;
            this.Disposed += UiDisposed;
            #endregion
        }

        public LibViewChartLayout(ISampleController iController, LibViewChart chart_1, LibViewChart chart_2)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            Chart_1 = chart_1;
            Chart_2 = chart_2;

            #region Docking Panel UI
            FormUtil.AddDockUserControl(splitContainerControl.Panel1, Chart_1);
            FormUtil.AddDockUserControl(splitContainerControl.Panel2, Chart_2);
            #endregion

            this.Load += UiLoad;
            SendMessage += iController.CallBackFunc;
            _iController.SendMessage += UpdateView;
            this.Disposed += UiDisposed;
            #endregion
        }
        #endregion

        #region Implement Dispose
        private void UiDisposed(object sender, EventArgs e)
        {
            this.Load -= UiLoad;
            SendMessage -= _iController.CallBackFunc;
            _iController.SendMessage -= UpdateView;
        }
        #endregion

        #region Event Handler Available Check
        private bool IsAvailableEventHandler
        {
            get
            {
                return (object.ReferenceEquals(SendMessage, null) == false) ? true : false;
            }
        }
        #endregion

        #region Ui Event Process

        #region void UiLoad(object sender, EventArgs e)
        private void UiLoad(object sender, EventArgs e)
        {
            

            #region Link Event
            this.SizeChanged += LibViewChartLayout_SizeChanged;
            #endregion
        }
        #endregion

        #region Event Function

        #endregion

        #endregion

        #region void LibViewChartLayout_SizeChanged(object sender, EventArgs e)
        private void LibViewChartLayout_SizeChanged(object sender, EventArgs e)
        {
            splitContainerControl.SplitterPosition = splitContainerControl.Height / 2;
        }
        #endregion
    }
}
