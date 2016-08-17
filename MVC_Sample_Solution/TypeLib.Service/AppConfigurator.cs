using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Service
{
    public abstract class AppConfigurator
    {
        public ISampleView Owner { get; protected set; }

        public Dictionary<string, string> TblConfig { get; protected set; }
        public Dictionary<Type, object> TblBindProperty { get; protected set; }
        public Dictionary<enProjectCode, BindListCollection> TblBindList { get; protected set; }
        public Dictionary<string, ISampleController> TblSubController { get; protected set; }
        public Dictionary<enUiTypeCode, List<ISampleView>> TblGridView { get; protected set; }
        public Dictionary<enChartCode, List<ISampleView>> TblChartView { get; protected set; }

        public abstract void Init();
        public abstract void StoreConfig();
        public abstract void CallBackFunc(object sender, EventArgs e);

        public virtual List<string> GetRefMaterialList()
        {
            return null;
        }
    }
}
