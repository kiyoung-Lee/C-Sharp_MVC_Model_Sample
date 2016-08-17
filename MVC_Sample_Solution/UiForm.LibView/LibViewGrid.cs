using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewGrid : DevExpress.XtraEditors.XtraUserControl, ISampleView
    {
        #region Controller I/F
        private IMireroController _iController;
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
                        case UiType.enEventCode.Redraw:
                            {
                                gridControl.Refresh();
                                gridView.RefreshData();
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

        #region Binding List        
        private IBindingList _bindList;
        public IBindingList _BindList { set { _bindList = value; } }
        #endregion

        #region Grid Control
        #endregion

        #region Creator
        public LibViewGrid(IMireroController iController, enProjectCode projectCode, enUiTypeCode uiTypeCode)
        {

            InitializeComponent();

            #region View & Data Manager Mapping
            _iController = iController;
            ProjectCode = projectCode;
            UiTypeCode = uiTypeCode;

            #region TblGrid Assign
            if (_iController.AppMain.TblGridView.ContainsKey(uiTypeCode))
            {
                if (_iController.AppMain.TblGridView[uiTypeCode] == null)
                    _iController.AppMain.TblGridView[uiTypeCode] = new List<IMireroView>();

                _iController.AppMain.TblGridView[uiTypeCode].Add(this);
            }
            else
            {
                _iController.AppMain.TblGridView.Add(uiTypeCode, new List<IMireroView>());
                _iController.AppMain.TblGridView[uiTypeCode].Add(this);
            }
            #endregion            

            if (_iController.AppMain.TblBindList.ContainsKey(ProjectCode))
            {
                BindListCollection bindListCollection = _iController.AppMain.TblBindList[ProjectCode];

                if (bindListCollection.TblBindList.ContainsKey(UiTypeCode))
                {
                    _bindList = bindListCollection.TblBindList[UiTypeCode] as IBindingList;
                }
            }
            #endregion

            _sendMessageData = new UiLibMessage();
            gridControl.DataSource = _bindList;            

            #region GridView Event Mapping
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

            if (_iController.AppMain.TblGridView.ContainsKey(UiTypeCode))
                _iController.AppMain.TblGridView[UiTypeCode].Remove(this);
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
            gridView.Columns.ToList().ForEach(colItem =>
            {
                colItem.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            });
        }
        #endregion

        #endregion        
    }
}
