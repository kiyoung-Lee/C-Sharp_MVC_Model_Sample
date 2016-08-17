using System;
using System.Data;
using System.Data.OracleClient;
//using Oracle.DataAccess;
//using Oracle.DataAccess.Types;
//using Oracle.DataAccess.Client;
using System.Collections.Generic;
using TypeLib.Core;

namespace TypeLib.DbLib.Process
{
    public class DbClientORA : IDbProcess
    {
        public const int ERR_STR_SIZE = 255;
        //private StringBuilder sqlText = new StringBuilder();

        #region Singleton Pattern
        private static volatile DbClientORA _instance;
        private static object _syncRoot = new Object();
        public static IDbProcess iQuery
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {

                            _instance = new DbClientORA();
                        }
                    }
                }
                return _instance;
            }
        }
        private DbClientORA() { }
        #endregion

        private OracleParameter CreateParameter(string parameterName, OracleType oracleType, ParameterDirection direction)
        {
            OracleParameter param = new OracleParameter(parameterName, oracleType)
            {
                Direction = direction
            };

            if (oracleType == OracleType.VarChar)
            {
                param.DbType = DbType.String;
            }

            return param;
        }

        public string ConnectionString { get; set; }
        public string SetTCPConnectionString(string host, string port, string servicename, string user, string pass)
        {
            ConnectionString = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
                 "(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};", host, port, servicename, user, pass);

            return ConnectionString;
        }

        public int ExecuteQuery(string cmdString, Dictionary<string, DbParameter> cmdParam, IDbHandler handler, ref string errMsg)
        {
            int retValue = 0;
            errMsg = enErrorCode.SUCCESS.GetDescription();

            #region Parameter Check
            if (string.IsNullOrEmpty(ConnectionString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING;
            }

            if (string.IsNullOrEmpty(cmdString) || !TblQueryContents.Table.ContainsKey(cmdString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_PRAMETER.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_PRAMETER;
            }
            #endregion

            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand sqlCommand = new OracleCommand())
                    {
                        OracleTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        sqlCommand.Connection = connection;
                        sqlCommand.Transaction = transaction;

                        try
                        {
                            #region Command Text Generate
                            sqlCommand.CommandText = TblQueryContents.Table[cmdString];
                            sqlCommand.CommandType = CommandType.Text;
                            #endregion

                            #region Default Output Parameter Generate
                            sqlCommand.Parameters.Add(CreateParameter("PO_I_RETURN", OracleType.Int32, ParameterDirection.ReturnValue));

                            OracleParameter inParam = null;
                            inParam = CreateParameter("PO_V_ERR", OracleType.Char, ParameterDirection.Output);
                            inParam.Size = ERR_STR_SIZE;
                            sqlCommand.Parameters.Add(inParam);

                            sqlCommand.Parameters.Add(CreateParameter("PO_CUR", OracleType.Cursor, ParameterDirection.Output));
                            #endregion

                            #region User Parameter Generate
                            foreach (DbParameterORA param in cmdParam.Values)
                            {
                                if (param != null)
                                {
                                    inParam = null;
                                    inParam = CreateParameter(param.Name, param.Type, param.Direction);
                                    if (param.Size > 0)
                                    {
                                        inParam.Size = param.Size;
                                    }

                                    if ((param.Direction == ParameterDirection.Input) || (param.Direction == ParameterDirection.InputOutput))
                                    {
                                        inParam.Value = param.Value;
                                    }

                                    sqlCommand.Parameters.Add(inParam);
                                }
                            }
                            #endregion

                            #region Query Execute
                            using (OracleDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                try
                                {
                                    retValue = Convert.ToInt32(sqlCommand.Parameters["PO_I_RETURN"].Value.ToString());
                                    if (retValue == 0)
                                    {
                                        object[] inData = new object[dataReader.FieldCount];
                                        while (dataReader.Read())
                                        {
                                            for (int idx = 0; idx < dataReader.FieldCount; idx++)
                                            {
                                                inData[idx] = dataReader[idx];
                                            }

                                            handler.HandlerQuery(inData);
                                        }
                                    }
                                    else
                                    {
                                        errMsg = string.Format("{0}", sqlCommand.Parameters["PO_V_ERR"].Value);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
                            }
                            #endregion

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            #region Rollback
                            // Attempt to roll back the transaction. 
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                // This catch block will handle any errors that may have occurred 
                                // on the server that would cause the rollback to fail, such as 
                                // a closed connection.
                            }
                            #endregion

                            throw new Exception(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    retValue = 1;
                    errMsg = ex.Message;
                }
            }

            return retValue;
        }

        public int ExecuteNonQuery(string cmdString, Dictionary<string, DbParameter> cmdParam, ref string errMsg)
        {
            int retValue = 0;
            errMsg = enErrorCode.SUCCESS.GetDescription();

            #region Parameter Check
            if (string.IsNullOrEmpty(ConnectionString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING;
            }

            if (string.IsNullOrEmpty(cmdString) || !TblQueryContents.Table.ContainsKey(cmdString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_PRAMETER.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_PRAMETER;                
            }
            #endregion

            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand sqlCommand = new OracleCommand())
                    {
                        OracleTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        sqlCommand.Connection = connection;
                        sqlCommand.Transaction = transaction;

                        try
                        {
                            #region Command Text Generate
                            sqlCommand.CommandText = TblQueryContents.Table[cmdString];
                            sqlCommand.CommandType = CommandType.Text;
                            #endregion

                            #region Default Output Parameter Generate
                            sqlCommand.Parameters.Add(CreateParameter("PO_I_RETURN", OracleType.Int32, ParameterDirection.ReturnValue));

                            OracleParameter inParam = null;
                            inParam = CreateParameter("PO_V_ERR", OracleType.Char, ParameterDirection.Output);
                            inParam.Size = ERR_STR_SIZE;
                            sqlCommand.Parameters.Add(inParam);
                            #endregion

                            #region User Parameter Generate
                            foreach (DbParameterORA param in cmdParam.Values)
                            {
                                if (param != null)
                                {
                                    inParam = null;
                                    inParam = CreateParameter(param.Name, param.Type, param.Direction);
                                    if (param.Size > 0)
                                    {
                                        inParam.Size = param.Size;
                                    }

                                    if ((param.Direction == ParameterDirection.Input) || (param.Direction == ParameterDirection.InputOutput))
                                    {
                                        inParam.Value = param.Value;
                                    }

                                    sqlCommand.Parameters.Add(inParam);
                                }
                            }
                            #endregion

                            #region Query Execute
                            sqlCommand.ExecuteNonQuery();

                            retValue = Convert.ToInt32(sqlCommand.Parameters["PO_I_RETURN"].Value.ToString());
                            if (retValue == 0)
                            {
                            }
                            else
                            {
                                errMsg = string.Format("{0}", sqlCommand.Parameters["PO_V_ERR"].Value);
                            }
                            #endregion

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            #region Rollback
                            // Attempt to roll back the transaction. 
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                // This catch block will handle any errors that may have occurred 
                                // on the server that would cause the rollback to fail, such as 
                                // a closed connection.
                            }
                            #endregion

                            throw new Exception(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    retValue = 1;
                    errMsg = ex.Message;
                }
            }

            return retValue;
        }

        public int ExecuteNonQueryEx(string cmdString, Dictionary<string, DbParameter> cmdParam, ref string errMsg)
        {
            int retValue = 0;
            errMsg = enErrorCode.SUCCESS.GetDescription();

            #region Parameter Check
            if (string.IsNullOrEmpty(ConnectionString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_CONNECTION_STRING;
            }

            if (string.IsNullOrEmpty(cmdString) || !TblQueryContents.Table.ContainsKey(cmdString))
            {
                errMsg = enErrorCode.TYPE_DB_INVALID_PRAMETER.GetDescription();
                return (int)enErrorCode.TYPE_DB_INVALID_PRAMETER;
            }
            #endregion

            #region Output Parameter Name List
            List<string> outParamListName = new List<string>();
            #endregion

            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand sqlCommand = new OracleCommand())
                    {
                        OracleTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        sqlCommand.Connection = connection;
                        sqlCommand.Transaction = transaction;

                        try
                        {
                            #region Command Text Generate
                            sqlCommand.CommandText = TblQueryContents.Table[cmdString];
                            sqlCommand.CommandType = CommandType.Text;
                            #endregion

                            #region Default Output Parameter Generate
                            sqlCommand.Parameters.Add(CreateParameter("PO_I_RETURN", OracleType.Int32, ParameterDirection.ReturnValue));

                            OracleParameter inParam = null;
                            inParam = CreateParameter("PO_V_ERR", OracleType.Char, ParameterDirection.Output);
                            inParam.Size = ERR_STR_SIZE;
                            sqlCommand.Parameters.Add(inParam);
                            #endregion

                            #region User Parameter Generate  
                            inParam = null;
                            foreach (DbParameterORA param in cmdParam.Values)
                            {
                                if (param != null)
                                {
                                    inParam = null;
                                    inParam = CreateParameter(param.Name, param.Type, param.Direction);
                                    if (param.Size > 0)
                                    {
                                        inParam.Size = param.Size;
                                    }

                                    if ((param.Direction == ParameterDirection.Input) || (param.Direction == ParameterDirection.InputOutput))
                                    {
                                        inParam.Value = param.Value;
                                    }

                                    if ((param.Direction == ParameterDirection.Output) || (param.Direction == ParameterDirection.InputOutput))
                                    {
                                        outParamListName.Add(param.Name);
                                    }

                                    sqlCommand.Parameters.Add(inParam);
                                }
                            }
                            #endregion

                            #region Query Execute
                            sqlCommand.ExecuteNonQuery();

                            retValue = Convert.ToInt32(sqlCommand.Parameters["PO_I_RETURN"].Value.ToString());
                            if (retValue == 0)
                            {
                                foreach (var outParamName in outParamListName)
                                {
                                    if (sqlCommand.Parameters[outParamName].OracleType == OracleType.Char)
                                    {
                                        cmdParam[outParamName].Value = Convert.ToString(sqlCommand.Parameters[outParamName].Value).Trim();
                                    }
                                    else
                                    {
                                        cmdParam[outParamName].Value = sqlCommand.Parameters[outParamName].Value;
                                    }
                                }
                            }
                            else
                            {
                                errMsg = string.Format("{0}", sqlCommand.Parameters["PO_V_ERR"].Value);
                            }
                            #endregion

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            #region Rollback
                            // Attempt to roll back the transaction. 
                            try
                            {
                                transaction.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                // This catch block will handle any errors that may have occurred 
                                // on the server that would cause the rollback to fail, such as 
                                // a closed connection.
                            }
                            #endregion

                            throw new Exception(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    retValue = 1;
                    errMsg = ex.Message;
                }
            }

            return retValue;
        }
    }
}
