using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Core
{
    public enum enErrorCode : int
    {
        [Description("Success")]
        SUCCESS = 0,

        [Description("Invalid DB Connection String")]
        TYPE_DB_INVALID_CONNECTION_STRING = 0x01010001,

        [Description("Invalid Input Parameter")]
        TYPE_DB_INVALID_PRAMETER = 0x01010002,
    }
}
