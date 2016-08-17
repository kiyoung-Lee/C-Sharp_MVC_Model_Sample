using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Core;
using TypeLib.DbLib;
using TypeLib.DbLib.Process;

namespace UiForm.Sample
{
    public class SampleDataModel : IDataModel
    {
        public IDbProcess _iDb { get; private set; }
        private ConfigData _config;

        private Dictionary<string, object> _parameters = new Dictionary<string, object>();
        public Dictionary<string, object> Parameters
        {
            get { return _parameters; }
            private set
            {
                _parameters = value;
            }
        }

        public bool InitDataModel(string option)
        {
            #region AppConfig File Load
            if (_config == null)
            {
                string fileURL = Path.Combine(Directory.GetCurrentDirectory(), "AppConfig.xml");
                if (!File.Exists(fileURL))
                {
                    _config = new ConfigData()
                    {
                        Name = "LOADER_1",
                        GroupName = "DISTRIBUTOR_1",
                        DbInfo = new DbConnectionInfo()
                        {
                            IP = "192.168.60.214",
                            PORT = "1521",
                            SERVICE_NAME = "WIENER",
                            USER = "wienermgr",
                            PASSWORD = "wienermgr"
                        }
                    };

                    _config.ToXmlFile(fileURL);
                }
                else
                {
                    _config = UtilFuncFile.FromXML(typeof(ConfigData), fileURL) as ConfigData;
                    if ((_config == null) || (string.IsNullOrEmpty(_config.Name)) || (string.IsNullOrEmpty(_config.DbInfo.IP)) ||
                        (string.IsNullOrEmpty(_config.DbInfo.PORT)) || (string.IsNullOrEmpty(_config.DbInfo.SERVICE_NAME)) ||
                        (string.IsNullOrEmpty(_config.DbInfo.USER)) || (string.IsNullOrEmpty(_config.DbInfo.PASSWORD)))
                    {
                        return false;
                    }
                }
            }
            #endregion

            #region Parameter Table Initialize
            Parameters.Add("CONFIG_INFO", _config);
            #endregion

            #region DB Interface Initialize
            _iDb = DbClientORA.iQuery;
            _iDb.SetTCPConnectionString(_config.DbInfo.IP, _config.DbInfo.PORT, _config.DbInfo.SERVICE_NAME,
                _config.DbInfo.USER, _config.DbInfo.PASSWORD);
            #endregion

            return true;
        }

        public IList ExecuteCommand(string cmd, IList paramList)
        {
            #region Parameter Check
            if (!TblKnownParam.Table.ContainsKey(cmd) || !TblQueryContents.Table.ContainsKey(cmd))
            {                
                return null;
            }
            #endregion

            Dictionary<string, DbParameter> inParam = TblKnownParam.Table[cmd];
            string errMsg = string.Empty;
            switch (cmd)
            {
                case "PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_HIS":
                    return null;
                    break;

                default:
                    return null;
            }
        }
    }
}
