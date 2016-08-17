using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace TypeLib.DbLib.Process
{
    [DataContract]
    public class DbParameterSQL : DbParameter
    {
        [DataMember]
        public SqlDbType Type;
    }
}
