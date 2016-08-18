using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Core;
using TypeLib.OriginType;
using TypeLib.Service;

namespace UiForm.Sample
{
    public class MainAppConfigurator : AppConfigurator
    {
        public OriginType Type { get; private set; }
        public MainManagerSchedulerJob JobManager { get; private set; }
        public IDataModel iDataModel { get; private set; }

        #region override void CallBackFunc(object sender, EventArgs e)
        public override void CallBackFunc(object sender, EventArgs e)
        {
            UiLibMessage receiveMessage = e as UiLibMessage;

            if ((receiveMessage != null) && (receiveMessage.Code is enEventCode))
            {
                switch ((enEventCode)receiveMessage.Code)
                {
                    default:
                        {
                            DefaultRootCallMsg(receiveMessage);
                        }
                        break;                    
                }
            }
        }
        #endregion

        #region override void Init()
        public override void Init()
        {
            var DataModel = (SampleDataModel)iDataModel;
            DataModel.InitDataModel(string.Empty);

            //string configFileURL = Path.Combine(Directory.GetCurrentDirectory(), UiLibWords.FILE_CONFIG);
            //if (File.Exists(configFileURL))
            //{
            //    ConfigData = UtilFuncFile.ObjectFromXmlFile<AppConfigurationData>(configFileURL);
            //}
            //else
            //{
            //    // Default Configuration
            //    ConfigData = new AppConfigurationData();
            //    ConfigData.ToXmlFile<AppConfigurationData>(configFileURL);
            //}

            #region Configuration Object Initialize
            InitConfiguration();
            #endregion

            if (TblSubController == null)
            {
                TblSubController = new Dictionary<string, ISampleController>();
            }
            ISampleController controller = null;            

            #region Network Initailze
            JobManager = new MainManagerSchedulerJob(DataModel);
            JobManager.ReportCallEvent += CallBackFunc;            
            #endregion
        }
        #endregion

        #region override void StoreConfig()
        public override void StoreConfig()
        {

        }
        #endregion

        #region Creator
        public MainAppConfigurator(OriginType type, ISampleView owner)
        {
            Type = type;
            Owner = owner;

            iDataModel = new SampleDataModel();
            TblConfig = new Dictionary<string, string>();
            TblBindProperty = new Dictionary<Type, object>();
            TblBindList = new Dictionary<enProjectCode, BindListCollection>();
            TblSubController = new Dictionary<string, ISampleController>();
            TblGridView = new Dictionary<enUiTypeCode, List<ISampleView>>();
            TblChartView = new Dictionary<enChartCode, List<ISampleView>>();
        }
        #endregion

        #region Implement Call Back Function
        private void DefaultRootCallMsg(UiLibMessage msg)
        {
            UiLibMessage sendMessageConfiguration = new UiLibMessage();
            UiLibMessage sendMessageMaterial = new UiLibMessage();
            UiLibMessage sendMessageMeasurement = new UiLibMessage();
            UiLibMessage sendMessageJobManager = new UiLibMessage();
            UiLibMessage sendMessageRecipe = new UiLibMessage();
            UiLibMessage sendMessageStructure = new UiLibMessage();
            UiLibMessage sendMessageGenerate = new UiLibMessage();
            UiLibMessage sendMessageTrain = new UiLibMessage();

            var inCode = (enEventCode)msg.Code;
            sendMessageConfiguration.Code = inCode;
            sendMessageConfiguration.Parameters.Clear();
            sendMessageConfiguration.Parameters.AddRange(msg.Parameters);

            sendMessageMaterial.Code = inCode;
            sendMessageMaterial.Parameters.Clear();
            sendMessageMaterial.Parameters.AddRange(msg.Parameters);

            sendMessageMeasurement.Code = inCode;
            sendMessageMeasurement.Parameters.Clear();
            sendMessageMeasurement.Parameters.AddRange(msg.Parameters);

            sendMessageJobManager.Code = inCode;
            sendMessageJobManager.Parameters.Clear();
            sendMessageJobManager.Parameters.AddRange(msg.Parameters);

            sendMessageRecipe.Code = inCode;
            sendMessageRecipe.Parameters.Clear();
            sendMessageRecipe.Parameters.AddRange(msg.Parameters);

            sendMessageStructure.Code = inCode;
            sendMessageStructure.Parameters.Clear();
            sendMessageStructure.Parameters.AddRange(msg.Parameters);

            sendMessageGenerate.Code = inCode;
            sendMessageGenerate.Parameters.Clear();
            sendMessageGenerate.Parameters.AddRange(msg.Parameters);

            sendMessageTrain.Code = inCode;
            sendMessageTrain.Parameters.Clear();
            sendMessageTrain.Parameters.AddRange(msg.Parameters);

            //TblSubController[UiLibWords.CONTROL_RECIPE].CallBackFunc(this, sendMessageRecipe);

            ////수정 kjh ControllerStructure 병합작업으로 아래 코드는 필요 없다고 생각.
            ////TblSubController[UiLibWords.CONTROL_MATERIAL].CallBackFunc(this, sendMessageMaterial);
            //TblSubController[UiLibWords.CONTROL_MEASUREMENT].CallBackFunc(this, sendMessageMeasurement);
            //TblSubController[UiLibWords.CONTROL_STRUCTRUE].CallBackFunc(this, sendMessageStructure);
            //TblSubController[UiLibWords.CONTROL_CONFIGURATION].CallBackFunc(this, sendMessageConfiguration);
            //TblSubController[UiLibWords.CONTROL_JOBMANAGER].CallBackFunc(this, sendMessageJobManager);
            //TblSubController[UiLibWords.CONTROL_GENERATE].CallBackFunc(this, sendMessageGenerate);
            //TblSubController[UiLibWords.CONTROL_TRAIN].CallBackFunc(this, sendMessageTrain);
        }     
        #endregion

        #region Initialize Function

        private void InitConfiguration()
        {
            //if (!TblConfig.ContainsKey(UiLibWords.PROXY_CHECKTIME))
            //{
            //    TblConfig.Add(UiLibWords.PROXY_CHECKTIME, "2000");
            //}

            //if (!int.TryParse(TblConfig[UiLibWords.PROXY_CHECKTIME], out _checkTime))
            //{
            //    _checkTime = 2000;
            //}

            //if (ConfigData.WorkLoadManager == null)
            //{
            //    ConfigData.WorkLoadManager = new ServerInformation()
            //    {
            //        Name = UiLibWords.PROXY_NAME,
            //        Address = UiLibWords.PROXY_ADDRESS,
            //        Port = 10534,
            //        //Type = enServiceType.WorkLoad
            //    };

            //    string configFileURL = Path.Combine(Directory.GetCurrentDirectory(), UiLibWords.FILE_CONFIG);
            //    ConfigData.ToXmlFile<AppConfigurationData>(configFileURL);
            //}

            //foreach (var item in ConfigData.TblConfigurationData)
            //{
            //    if (TblConfig.ContainsKey(item.Key))
            //    {
            //        TblConfig[item.Key] = item.Value;
            //    }
            //    else
            //    {
            //        TblConfig.Add(item.Key, item.Value);
            //    }
            //}

            //if (TblConfig.ContainsKey(UiLibWords.KEY_WORKLOAD_NAME))
            //{
            //    TblConfig[UiLibWords.KEY_WORKLOAD_NAME] = ConfigData.WorkLoadManager.Name;
            //}
            //else
            //{
            //    TblConfig.Add(UiLibWords.KEY_WORKLOAD_NAME, ConfigData.WorkLoadManager.Name);

            //}
        }

        #endregion
    }
}
