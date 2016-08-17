using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Core;
using TypeLib.DbLib;
using TypeLib.OriginType;
using TypeLib.Service;
using UtilLib.ControlLib;

namespace UiForm.Sample
{
    class TempleteController : ISampleController
    {
        #region Implementation IController for MVC Pattern

        public event EventHandler ParentCallEvent;
        public event EventHandler SendMessage;

        public AppConfigurator AppMain { get; set; }
        public IDataModel iDataModel { get; private set; }
        public IWaitFormShowable iWaitForm { get; set; }

        #region void Init()
        public void Init()
        {
            #region Bindding Object Generate            
            #endregion            
        }
        #endregion

        #region Get Bind Item
        public T GetBindItem<T>(enProjectCode projectCode, enUiTypeCode uiTypeCode)
        {
            if (AppMain.TblBindList.ContainsKey(projectCode) && AppMain.TblBindList[projectCode].TblBindList.ContainsKey(uiTypeCode))
            {
                return (T)AppMain.TblBindList[projectCode].TblBindList[uiTypeCode];
            }
            return default(T);
        }
        #endregion

        #region BindingList<T> GetBindList<T>(enProjectCode projectCode, enUiTypeCode uiTypeCode)
        public BindingList<T> GetBindList<T>(enProjectCode projectCode, enUiTypeCode uiTypeCode)
        {
            if (AppMain.TblBindList.ContainsKey(projectCode) && AppMain.TblBindList[projectCode].TblBindList.ContainsKey(uiTypeCode))
            {
                return (BindingList<T>)AppMain.TblBindList[projectCode].TblBindList[uiTypeCode];
            }
            return null;
        }
        #endregion

        #region bool InputValueCheck(Enum fieldId, string value)
        public bool InputValueCheck(Enum fieldId, string value)
        {
            bool retValue = false;
            UiType.enCheckField fieldType = (UiType.enCheckField)fieldId;

            switch (fieldType)
            {

            }
            return retValue;
        }
        #endregion

        #region bool UpdateValue(Enum fieldId, object value)
        bool UpdateValue(Enum fieldId, object value)
        {
            List<string> inList = value as List<string>;
            if ((_sendMessageData != null) && (inList != null))
            {

            }

            return true;
        }
        #endregion

        #region void CallBackFunc(object sender, EventArgs e)
        public void CallBackFunc(object sender, EventArgs e)
        {
            UiLibMessage msg = e as UiLibMessage;
            if (msg != null)
            {
                if (msg.Code is enEventCode)
                {
                    enEventCode inCode = (enEventCode)msg.Code;
                    switch (inCode)
                    {
                    }
                }                
                else
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

        public OriginType Solution { get; set; }

        #region Creator
        public TempleteController(OriginType solution, IDbProcess DbConnection)
        {
            Solution = solution;

            #region DB Connection
            iDataModel = new SampleDataModel();
            #endregion
        }
        #endregion

        #region Event Message
        private UiLibMessage _sendMessageData = new UiLibMessage();
        private UiLibMessage _sendMessageDataParent = new UiLibMessage();
        #endregion

        #region Detail Function for CallbackFunc
        private void SampleFunction(ISampleView sender, UiLibMessage msg)
        {
        }
        #endregion

        #region Private Function

        #endregion
    }
}
