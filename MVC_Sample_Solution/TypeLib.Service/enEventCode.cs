using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Service
{
    public enum enEventCode : int
    {
        RootCall_Load = 0,
        RootCall_Unload,
        RootCall_MaterialChange,
        RootCall_Notify,
        RootCall_MaterialDelete,        
    }
}
