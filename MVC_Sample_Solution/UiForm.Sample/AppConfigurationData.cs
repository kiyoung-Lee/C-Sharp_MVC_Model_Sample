using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UiForm.Sample
{
    [DataContract]
    public class AppConfigurationData
    {
        //[DataMember]
        //public ServerInformation WorkLoadManager { get; set; }

        //[DataMember]
        //public ConfigData DbConfig { get; set; }

        //[DataMember]
        //public Dictionary<string, string> TblConfigurationData { get; set; }

        //public AppConfigurationData()
        //{
        //    TblConfigurationData = new Dictionary<string, string>();

        //    DbConfig = new ConfigData()
        //    {
        //        Name = "MainFrame",
        //        GroupName = "MainFrame",
        //        DbInfo = new DbConnectionInfo()
        //        {
        //            IP = UiLibWords.DB_IP,
        //            PORT = UiLibWords.DB_PORT,
        //            SERVICE_NAME = UiLibWords.DB_SERVICENAME,
        //            USER = UiLibWords.DB_USER,
        //            PASSWORD = UiLibWords.DB_PASSWORD
        //        }
        //    };

        //    TblConfigurationData = new Dictionary<string, string>()
        //    {
        //        {UiLibWords.KEY_PROXY_CHECK, UiLibWords.VALUE_PROXY_CHECK},
        //        {UiLibWords.KEY_WORKPATH, Directory.GetCurrentDirectory()},
        //        {UiLibWords.KEY_GENERATE_RESULTPATH, UiLibWords.VALUE_GENERATE_RESULTPATH},
        //        {UiLibWords.KEY_DRIVEPATH, UiLibWords.VALUE_DRIVEPATH },
        //        {UiLibWords.KEY_ROOTPATH, UiLibWords.VALUE_ROOTPATH },
        //        {UiLibWords.KEY_YAMLPATH, UiLibWords.VALUE_YAMLPATH },

        //        {UiLibWords.KEY_LOGPATH, UiLibWords.VALUE_LOGPATH },
        //        {UiLibWords.KEY_RESULTPATH, UiLibWords.VALUE_RESULTPATH },
        //        {UiLibWords.KEY_SPECTRUMPATH, UiLibWords.VALUE_SPECTRUMPATH },
        //        {UiLibWords.KEY_WORKLOAD_NAME,"" }
        //    };
        //}
    }
}
