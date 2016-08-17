using System.Data;
using System.Runtime.Serialization;
using TypeLib.DbLib.Process;

namespace TypeLib.DbLib
{
    [DataContract]
    [KnownType(typeof(DbParameterORA))]
    [KnownType(typeof(DbParameterSQL))]
    public abstract class DbParameter
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Size { get; set; }
        [DataMember]
        public ParameterDirection Direction { get; set; }
        [DataMember]
        public object Value { get; set; }
    }
}
