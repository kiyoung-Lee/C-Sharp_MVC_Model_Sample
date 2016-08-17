using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Core
{
    public interface IDataModel
    {
        bool InitDataModel(string option);
        Dictionary<string, object> Parameters { get; }
        IList ExecuteCommand(string cmd, IList paramList);
    }
}
