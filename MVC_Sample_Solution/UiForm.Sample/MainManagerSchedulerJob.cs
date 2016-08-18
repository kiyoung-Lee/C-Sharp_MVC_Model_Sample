using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TypeLib.Core;

namespace UiForm.Sample
{
    public class MainManagerSchedulerJob : IDisposable
    {
        private int _id;
        private int _pid;

        #region Schedule Period Time
        protected int _checkTime;
        #endregion

        #region Report Event Handler
        public event EventHandler ReportCallEvent;
        #endregion

        #region Report Event Message
        private UiLibMessage _sendProxyMessageData = new UiLibMessage();
        private UiLibMessage _sendJobCheckMessageData = new UiLibMessage();
        #endregion

        #region Syncronized Context
        SynchronizationContext syncContext;
        #endregion

        #region Thread Object
        Thread proxyThread = null;
        Thread jobCheckThread = null;
        #endregion

        #region Thread Event Object
        protected ManualResetEvent _proxyThreadHandle;
        protected ManualResetEvent _jobCheckThreadHandle;
        #endregion

        #region Lock Object
        private readonly object _workLoadSeerviceLock = new Object();
        private readonly object _workLoadSeerviceInfoLock = new Object();
        private readonly object _jobCheckThreadLock = new Object();
        #endregion

        #region Proxy Thread Variable
        protected int _threadStatusProxy = 0;
        protected int _threadStatusJobCheck = 0;
        #endregion

        #region WorkLoad Manager Server Proxy Table
        private bool _workLoadServiceAlive;
        //private ServerInformation _workLoadServiceInfo;
        //private WienerServiceProxyCommonServer _workLoadService;
        #endregion

        #region Configuration
        private static AppConfigurationData _config;
        #endregion

        #region iDataModel
        public IDataModel iDataModel { get; private set; }
        #endregion

        #region Implementation IDisposable
        public void Dispose()
        {
            if (this._proxyThreadHandle != null)
            {
                _proxyThreadHandle.Set();
                _proxyThreadHandle.Dispose();
                Interlocked.Exchange(ref _threadStatusProxy, 0);
                proxyThread.Join();
                _proxyThreadHandle = null;
            }

            if (_jobCheckThreadHandle != null)
            {
                _jobCheckThreadHandle.Set();
                _jobCheckThreadHandle.Dispose();
                Interlocked.Exchange(ref this._threadStatusJobCheck, 0);
                jobCheckThread.Join();
                _jobCheckThreadHandle = null;
            }
        }
        #endregion

        #region Creator
        public MainManagerSchedulerJob(IDataModel DataModel)
        {
            syncContext = SynchronizationContext.Current;

            #region DB Connection
            iDataModel = DataModel;
            #endregion
        }
        #endregion

        #region Implementation IWorkManagerJob

        #region bool StartManager(int checkTime, AppConfigurationData config)
        public bool StartManager(int checkTime, AppConfigurationData config)
        {
            //_checkTime = checkTime;
            //_config = config;
            //#region Service Information Setting
            //if ((_config == null) || (_config.WorkLoadManager == null))
            //{
            //    return false;
            //}

            //lock (_workLoadSeerviceInfoLock)
            //{
            //    _workLoadServiceInfo = _config.WorkLoadManager;
            //}
            //#endregion

            //#region Proxy Thread Start
            //if (this._threadStatusProxy == 0)
            //{
            //    _proxyThreadHandle = new ManualResetEvent(true);
            //    proxyThread = new Thread(this.WorkThreadProxy);
            //    proxyThread.Start();
            //}
            //#endregion

            //#region Job Check Thread Start
            //if (_threadStatusJobCheck == 0)
            //{
            //    _jobCheckThreadHandle = new ManualResetEvent(true);
            //    jobCheckThread = new Thread(this.JobCheckThread);
            //    jobCheckThread.Start();
            //}
            //#endregion

            return true;
        }
        #endregion

        #region bool StopManager()
        public bool StopManager()
        {
            #region Proxy Thrad Stop
            if (this._threadStatusProxy > 0)
            {
                _proxyThreadHandle.Reset();
                Interlocked.Exchange(ref this._threadStatusProxy, 0);
                _proxyThreadHandle.Dispose();
                _proxyThreadHandle = null;
            }
            #endregion

            return true;
        }
        #endregion

        public void SetSolutionId(int id, int Pid)
        {
            _id = id;
            _pid = Pid;
        }

        #region void StartPollingThread()
        public void StartPollingThread()
        {
            // Polling 시작
            Interlocked.Exchange(ref _threadStatusJobCheck, 1);
            _jobCheckThreadHandle.Set();
        }
        #endregion

        #endregion

        #region Implementation WorkThreadProxy
        protected void WorkThreadProxy(object threadParam)
        {
            //#region 스레드 시작 상태 플레그 설정
            //if (this._threadStatusProxy == 0)
            //{
            //    Interlocked.Exchange(ref this._threadStatusProxy, 1);
            //}
            //#endregion

            //WienerServiceCallback callbackObj = new WienerServiceCallback();
            //AsyncWienerServiceCallback callbackHandler = new AsyncWienerServiceCallback(syncContext, callbackObj);
            //callbackObj.ReportCallEvent += this.CallBackFunc;
            //InstanceContext instanceContext = new InstanceContext(callbackHandler);

            //WienerServiceProxyCommonServer proxy = new WienerServiceProxyCommonServer(instanceContext, UtilFuncNet.InitNetTcpBinding(), new EndpointAddress(this._workLoadServiceInfo.GetServerURL("DISTRIBUTOR_2")));
            //while (this._threadStatusProxy == 1)
            //{
            //    try
            //    {
            //        _proxyThreadHandle.WaitOne();
            //        if (proxy.State == CommunicationState.Opened)
            //        {
            //            var tt = proxy.IsAlive();

            //            this._workLoadServiceAlive = true;
            //            if (ReportCallEvent != null)
            //            {
            //                _sendProxyMessageData.Parameters.Clear();
            //                _sendProxyMessageData.Code = enEventCode.RootCall_Alive;
            //                ReportCallEvent(this, _sendProxyMessageData);
            //            }
            //            Thread.Sleep(_checkTime);
            //            continue;
            //        }

            //        if (proxy.State != CommunicationState.Created)
            //        {
            //            proxy = null;
            //            proxy = new WienerServiceProxyCommonServer(instanceContext, UtilFuncNet.InitNetTcpBinding(), new EndpointAddress(this._workLoadServiceInfo.GetServerURL("DISTRIBUTOR_2")));
            //        }

            //        //var config = ItemConfiguration.Instance;
            //        //proxy.ChannelFactory.Credentials.Windows.ClientCredential = new System.Net.NetworkCredential(config.MasterUser, config.MasterPassword);
            //        proxy.Open();

            //        lock (_workLoadSeerviceLock)
            //        {
            //            _workLoadService = proxy;
            //        }

            //        this._workLoadServiceAlive = true;
            //        if (ReportCallEvent != null)
            //        {
            //            _sendProxyMessageData.Parameters.Clear();
            //            _sendProxyMessageData.Code = enEventCode.RootCall_Connect;
            //            ReportCallEvent(this, _sendProxyMessageData);
            //        }
            //        Console.WriteLine("{0} : Client Connect OK", this._workLoadServiceInfo.GetServerURL("DISTRIBUTOR_2"));
            //        Thread.Sleep(_checkTime);
            //    }
            //    catch (Exception ex)
            //    {
            //        if (proxy != null)
            //        {
            //            proxy.Abort();
            //            proxy.Close();
            //            (proxy as IDisposable).Dispose();
            //            _workLoadService = null;
            //        }

            //        this._workLoadServiceAlive = false;
            //        if (ReportCallEvent != null)
            //        {
            //            _sendProxyMessageData.Parameters.Clear();
            //            _sendProxyMessageData.Code = enEventCode.RootCall_Disconnect;
            //            ReportCallEvent(this, _sendProxyMessageData);
            //        }
            //        Thread.Sleep(_checkTime);
            //        //Console.WriteLine("{0} : Client Connect Fail : {1}", serverInfo.GetServerURL("AgentService"), ex.Message);
            //    }
            //}

            //if (proxy != null)
            //{
            //    proxy.Close();
            //    (proxy as IDisposable).Dispose();
            //    proxy = null;
            //    _workLoadService = null;

            //    this._workLoadServiceAlive = false;
            //    if (ReportCallEvent != null)
            //    {
            //        _sendProxyMessageData.Parameters.Clear();
            //        _sendProxyMessageData.Code = enEventCode.RootCall_Disconnect;
            //        ReportCallEvent(this, _sendProxyMessageData);
            //    }
            //}
            //Console.WriteLine("{0} : Connect Manager Thread Exit", this._workLoadServiceInfo.GetServerURL("DISTRIBUTOR_2"));
        }
        #endregion

        #region Implementation JobCheckThread
        protected void JobCheckThread(object threadParam)
        {
            //#region 스레드 시작 상태 플레그 설정
            //if (_threadStatusJobCheck == 0)
            //{
            //    Interlocked.Exchange(ref _threadStatusJobCheck, 2);
            //}
            //#endregion

            //while (_threadStatusJobCheck > 0)
            //{
            //    try
            //    {
            //        if (_threadStatusJobCheck > 1)
            //        {
            //            _jobCheckThreadHandle.Reset();
            //            _jobCheckThreadHandle.WaitOne();
            //        }

            //        if (_threadStatusJobCheck == 1)
            //        {
            //            if (_id >= 0 && _pid >= 0)
            //            {
            //                var jobProcessHis = new DbGetJobProcessHis();
            //                //int lastMonth = DateTime.Now.Month - 1;
            //                //string startDate = DateTime.Now.ToString("yyyy-" + lastMonth + "-dd 00:00:01");
            //                //string endDate = DateTime.Now.AddMinutes(5).ToString(WienerTime.Format);    // DB 시간 여유 맞춤
            //                string startDate = UtilFuncDate.GetStringEndOfDay(UtilFuncDate.GetPreviousMonthDate(DateTime.Now), WienerTime.Format);// 한달 전의 00:00:01
            //                string endDate = UtilFuncDate.GetStringEndOfDay(DateTime.Now, WienerTime.Format);                                                  // 다음 날의 00:00:00

            //                lock (_jobCheckThreadLock)
            //                {
            //                    //DateTime start = Convert.ToDateTime(startDate);
            //                    //jobProcessHis.StartDate = start.ToString(WienerTime.Format);
            //                    jobProcessHis.StartDate = startDate;
            //                    jobProcessHis.EndDate = endDate;
            //                    jobProcessHis.SolId = _id;
            //                    jobProcessHis.SolPid = _pid;
            //                }

            //                var jobList = iDataModel.ExecuteCommand("PKG_JOB_MONITOR_OFFLINE.F_GET_JOB_PROCESS_HIS", new[] { jobProcessHis }).Cast<JobHistory>().ToList();

            //                _sendJobCheckMessageData.Parameters.Clear();
            //                _sendJobCheckMessageData.Code = enEventCode.RootCall_DB_PollingJob;
            //                _sendJobCheckMessageData.Parameters.Add(jobList);
            //                ReportCallEvent(this, _sendJobCheckMessageData);

            //                // 동작중인 Job이 없으면 Polling 중지
            //                if (jobList.Any(jobItem => jobItem.STATUS == enJobStatus.Waiting || jobItem.STATUS == enJobStatus.Running) == false)
            //                    Interlocked.Exchange(ref _threadStatusJobCheck, 2);

            //                Thread.Sleep(500);
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message.ToString());
            //    }
            //}
        }
        #endregion

        #region void CallBackFunc(object sender, EventArgs e)
        public void CallBackFunc(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
