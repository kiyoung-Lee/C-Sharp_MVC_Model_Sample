using System;
using TypeLib.Core;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewProperty : DevExpress.XtraEditors.XtraUserControl, ISampleView
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
                        case UiType.enEventCode.Lib_Change_Config:
                            propertyGridControl.Refresh();
                            break;

                        case UiType.enEventCode.Lib_Change_SelectObj_TrainConfig:
                            {
                                Lib_Change_SelectObj_TrainConfig();
                            }
                            break;
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

        #region Bind Object
        private Type _bindType;
        private object _propertyItem;
        #endregion

        #region Grid Control
        //GridControl _gridControl;
        //GridView _gridView;
        public PropertyGridControl GetPropertyGrid { get { return propertyGridControl; } }
        public object GetSelectObject { get { return _propertyItem; } }
        #endregion

        #region Creator
        public LibViewProperty(ISampleController iController, Type bindType)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();
            _iController = iController;

            _bindType = bindType;
            if (_iController.AppMain.TblBindProperty.ContainsKey(_bindType))
            {
                _propertyItem = _iController.AppMain.TblBindProperty[_bindType];
            }

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
            #region Data Binding
            if (_propertyItem != null)
            {
                propertyGridControl.SelectedObject = _propertyItem;
                propertyGridControl.ExpandAllRows();
            }
            #endregion            
        }
        #endregion

        #region Event Function
        private void Lib_Change_SelectObj_TrainConfig()
        {
            if (_iController.AppMain.TblBindProperty.ContainsKey(_bindType))
            {
                _propertyItem = _iController.AppMain.TblBindProperty[_bindType];
            }
            propertyGridControl.SelectedObject = _propertyItem;
            propertyGridControl.ExpandAllRows();
        }
        #endregion

        #endregion
    }
}
