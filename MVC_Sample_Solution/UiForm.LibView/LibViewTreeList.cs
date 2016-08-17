using System;
using System.ComponentModel;
using TypeLib.Core;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewTreeList : DevExpress.XtraEditors.XtraUserControl, ISampleView
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

        #region Binding List
        private IBindingList _bindList;
        public IBindingList _BindList { set { _bindList = value; } }
        #endregion

        #region Grid Control
        #endregion

        #region Creator
        public LibViewTreeList(ISampleController iController, enProjectCode projectcode, enUiTypeCode uiTypeCode)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            ProjectCode = projectcode;
            UiTypeCode = uiTypeCode;

            if (_iController.AppMain.TblBindList.ContainsKey(ProjectCode))
            {
                BindListCollection bindListCollection = _iController.AppMain.TblBindList[ProjectCode];

                if (bindListCollection.TblBindList.ContainsKey(UiTypeCode))
                {
                    _bindList = bindListCollection.TblBindList[UiTypeCode] as IBindingList;
                }
            }

            treeList.DataSource = _bindList;

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
