using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Core
{
    [DataContract]
    public class ConfigData
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string GroupName { get; set; }

        [DataMember]
        public DbConnectionInfo DbInfo { get; set; }
    }
}
