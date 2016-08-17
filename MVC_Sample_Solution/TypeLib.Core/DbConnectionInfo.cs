using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TypeLib.Core
{
    [DataContract]
    public class DbConnectionInfo
    {
        [DataMember]
        public string IP { get; set; }
        [DataMember]
        public string PORT { get; set; }
        [DataMember]
        public string SERVICE_NAME { get; set; }
        [DataMember]
        public string USER { get; set; }
        [DataMember]
        public string PASSWORD { get; set; }
    }
}
