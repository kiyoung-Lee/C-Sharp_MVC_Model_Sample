using System;
using TypeLib.Core;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewResultLayout : DevExpress.XtraEditors.XtraUserControl, ISampleView
    {
        #region Controller I/F
        private ISampleController _iController;
        #endregion

        #region Implementation IView

        #region BindList Code
        public enProjectCode ProjectCode { get; private set; }
        public enUiTypeCode UiTypeCode { get; private set; }
        public enChartCode ChartCode { get; private set; }
        #endregion

        #region void UpdateView(object sender, EventArgs e)
        public void UpdateView(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region Event Handler & Message
        public event EventHandler SendMessage;
        private UiLibMessage _sendMessageData;
        #endregion

        #region Dock Pannel Getter
        public DockPanel getChartDockPanel { get {return dockPanelChart; } }
        public DockPanel getDataDockPanel { get { return dockPanelData; } }
        #endregion

        #region Creator
        public LibViewResultLayout(ISampleController iController)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            //ProjectCode = projectcode;
            //UiTypeCode = uiTypeCode;
            //ChartCode = chartCode;

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

        #region Ui Event Process

        #region void UiLoad(object sender, EventArgs e)
        private void UiLoad(object sender, EventArgs e)
        {
            #region Menu Control UI
            var bitmap16 = UiLibImages.Bitmap16;
            #endregion

            #region Docking Panel UI
            
            #endregion

            #region Link Button Event

            #endregion
        }
        #endregion

        #region Event Function

            #endregion

        #endregion
    }
}
