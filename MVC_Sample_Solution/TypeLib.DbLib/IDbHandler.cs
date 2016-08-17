using System;
using System.Collections.Generic;

namespace TypeLib.DbLib
{
    public interface IDbHandler
    {
        bool HandlerQuery(params object[] fieldData);
    }
}
