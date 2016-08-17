using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Core;

namespace TypeLib.Service
{
    public interface ISampleController
    {
        event EventHandler ParentCallEvent;
        event EventHandler SendMessage;

        IDataModel iDataModel { get; }
        AppConfigurator AppMain { get; set; }

        T GetBindItem<T>(enProjectCode projectCode, enUiTypeCode uiTypeCode);
        BindingList<T> GetBindList<T>(enProjectCode projectCode, enUiTypeCode uiTypeCode);
        bool InputValueCheck(Enum fieldId, string value);

        void Init();
        void CallBackFunc(object sender, EventArgs e);
    }
}
