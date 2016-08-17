using System;
using System.Windows.Forms;
using TypeLib.Core;
using TypeLib.Service;
using UtilLib.ControlLib;

namespace UiForm.Sample
{
    public partial class Templete_View : Form, ISampleView
    {
        #region Controller I/F
        private ISampleController _iController;
        #endregion

        #region Implementation IView

        #region BindList Code
        public enProjectCode ProjectCode { get; private set; }
        public enUiTypeCode UiTypeCode { get; private set; }
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

        #region Grid Control
        #endregion

        #region Creator
        public Templete_View(ISampleController iController, enProjectCode projectcode, enUiTypeCode uiTypeCode)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            ProjectCode = projectcode;
            UiTypeCode = uiTypeCode;

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
