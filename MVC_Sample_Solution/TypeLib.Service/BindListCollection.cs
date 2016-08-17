using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Service
{
    public class BindListCollection
    {
        public Dictionary<enUiTypeCode, object> TblBindList { get; private set; }

        public BindListCollection()
        {
            TblBindList = new Dictionary<enUiTypeCode, object>();
        }
    }
}
