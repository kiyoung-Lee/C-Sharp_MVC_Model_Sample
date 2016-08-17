using System;
using System.Collections.Generic;

namespace TypeLib.DbLib
{
    public interface IDbProcess
    {
        string ConnectionString { get; set; }
        string SetTCPConnectionString(string host, string port, string servicename, string user, string pass);
        int ExecuteQuery(string cmdString, Dictionary<string, DbParameter> cmdParam, IDbHandler handler, ref string errMsg);
        int ExecuteNonQuery(string cmdString, Dictionary<string, DbParameter> cmdParam, ref string errMsg);
        int ExecuteNonQueryEx(string cmdString, Dictionary<string, DbParameter> cmdParam, ref string errMsg);
    }
}
