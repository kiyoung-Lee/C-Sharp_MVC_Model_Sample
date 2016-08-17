using System;
using System.Data;
using System.Data.OracleClient;
using System.Runtime.Serialization;

namespace TypeLib.DbLib.Process
{
    [DataContract]
    public class DbParameterORA : DbParameter
    {
        [DataMember]
        public OracleType Type { get; set; }

        public void InitData()
        {
            Name = string.Empty;
            Size = 0;
            Direction = ParameterDirection.Input;
            Value = null;
            Type = OracleType.VarChar;
        }
    }
}
