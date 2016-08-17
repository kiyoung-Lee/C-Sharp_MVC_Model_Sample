using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TypeLib.Core;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public partial class LibViewChart : DevExpress.XtraEditors.XtraUserControl, ISampleView
    {
        #region Controller I/F
        private IMireroController _iController;
        #endregion

        #region Implementation IView

        #region BindList Code
        public enProjectCode ProjectCode { get; private set; }
        public enUiTypeCode UiTypeCode { get; private set; }
        public enChartCode ChartCode; 
        private UiType.ChartData _chartData;
        #endregion

        #region void UpdateView(object sender, EventArgs e)
        public void UpdateView(object sender, EventArgs e)
        {
            UiLibMessage msg = e as UiLibMessage;
            if (msg != null)
            {
                if (msg.Code is UiType.enEventCode)
                {
                    UiType.enEventCode inCode = (UiType.enEventCode)msg.Code;

                    switch (inCode)
                    {
                        case UiType.enEventCode.Lib_Chart_BeginUpdate:
                            chartControl.BeginInit();
                            break;

                        case UiType.enEventCode.Lib_Chart_EndUpdate:
                            chartControl.EndInit();
                            break;

                        case UiType.enEventCode.Lib_ChangeChart:
                            {
                                _chartData = TblChartCode.GetChartData(ChartCode);
                                Lib_ChangeChart();
                            }
                            break;

                        case UiType.enEventCode.Lib_Change_SeriesVisible:
                            {
                                _chartData = TblChartCode.GetChartData(ChartCode);
                                Lib_Change_SeriesVisible();
                            }
                            break;

                        case UiType.enEventCode.Lib_Change_SereisThickness:
                            {
                                _chartData = TblChartCode.GetChartData(ChartCode);
                                Lib_Change_SereisThickness();
                            }
                            break;

                        case UiType.enEventCode.Lib_Change_ChartLogScale:
                            {
                                _chartData = TblChartCode.GetChartData(ChartCode);
                                Lib_Change_ChartLogScale(msg);
                            }
                            break;
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Event Handler & Message
        public event EventHandler SendMessage;
        private UiLibMessage _sendMessageData;
        #endregion

        public ChartControl GetChartControl { get { return chartControl; } }

        #region Creator
        public LibViewChart(IMireroController iController, enChartCode chartCode)
        {
            InitializeComponent();

            #region Default Initialize
            _sendMessageData = new UiLibMessage();

            _iController = iController;
            ChartCode = chartCode;
            _chartData = TblChartCode.GetChartData(chartCode);

            #region TblChart Assign
            if (_iController.AppMain.TblChartView.ContainsKey(chartCode))
            {
                if (_iController.AppMain.TblChartView[chartCode] == null)
                    _iController.AppMain.TblChartView[chartCode] = new List<IMireroView>();

                _iController.AppMain.TblChartView[chartCode].Add(this);
            }
            else
            {
                _iController.AppMain.TblChartView.Add(chartCode, new List<IMireroView>());
                _iController.AppMain.TblChartView[chartCode].Add(this);
            }
            #endregion           

            this.Load += UiLoad;
            SendMessage += iController.CallBackFunc;
            _iController.SendMessage += UpdateView;
            this.Disposed += UiDisposed;
            #endregion
        }
        #endregion

        #region Implement Dispose
        private void UiDisposed(object sender, EventArgs e)
        {
            this.Load -= UiLoad;
            SendMessage -= _iController.CallBackFunc;
            _iController.SendMessage -= UpdateView;

            if (_iController.AppMain.TblChartView.ContainsKey(ChartCode))
                _iController.AppMain.TblChartView[ChartCode].Remove(this);
        }
        #endregion

        #region Event Handler Available Check
        private bool IsAvailableEventHandler
        {
            get
            {
                return (object.ReferenceEquals(SendMessage, null) == false) ? true : false;
            }
        }
        #endregion

        #region Ui Event Process

        #region void UiLoad(object sender, EventArgs e)
        private void UiLoad(object sender, EventArgs e)
        {
            //chartControl.Legend.UseCheckBoxes = true;
            chartControl.Legend.Visible = false;
            //chartControl.CrosshairOptions.ShowCrosshairLabels = false;
            chartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
            chartControl.CustomDrawCrosshair += chartControl_CustomDrawCrosshair;
            chartControl.CacheToMemory = true;

            chartControl.RefreshDataOnRepaint = false;
            chartControl.RuntimeHitTesting = false;
        }
        #endregion        

        #endregion        

        #region Implement Call Back Function

        #region void InitChartView()
        private void Lib_ChangeChart()
        {
            try
            {
                if (_chartData == null)
                {
                    return;
                }

                // Series Process 
                chartControl.Series.Clear();

                int idx = 0;

                foreach (var dicItem in _chartData.SereisDic)
                {
                    var item = (SeriesItem)dicItem.Value;
                    idx = chartControl.Series.Add(dicItem.Key, item.ChartType);

                    switch (item.ChartType)
                    {
                        case ViewType.Line:
                            {
                                chartControl.Series[idx].DataSource = item.Datas;
                                chartControl.Series[idx].ArgumentDataMember = "X";
                                chartControl.Series[idx].ValueDataMembers.AddRange(new string[] { "Y" });
                                chartControl.Series[idx].Visible = item.isVisible;
                                if(dicItem.Value.SeriesColor != null)
                                    chartControl.Series[idx].View.Color = dicItem.Value.SeriesColor;
                                (chartControl.Series[0].View as LineSeriesView).LineStyle.Thickness = item.SeriesThickness;
                                (chartControl.Series[0].View as LineSeriesView).LineStyle.DashStyle = item.DashStyle;
                            }
                            break;

                        case ViewType.RangeArea:
                            {
                                chartControl.Series[idx].DataSource = (item.Datas.Cast<UiType.ChartRangeValue>().ToList());
                                chartControl.Series[idx].ArgumentDataMember = "X";
                                chartControl.Series[idx].ValueDataMembers.AddRange(new string[] { "YErrorUpper", "YErrorUnder" });
                                chartControl.Series[idx].Visible = item.isVisible;
                                if(dicItem.Value.SeriesColor != null)
                                    chartControl.Series[idx].View.Color = dicItem.Value.SeriesColor;
                            }
                            break;

                        case ViewType.Point:
                            {
                                chartControl.Series[idx].DataSource = item.Datas;
                                chartControl.Series[idx].ArgumentDataMember = "X";
                                chartControl.Series[idx].ValueDataMembers.AddRange(new string[] { "Y" });
                                chartControl.Series[idx].Visible = item.isVisible;
                            }
                            break;

                        case ViewType.Bar:
                            {
                                chartControl.Series[idx].DataSource = item.Datas;
                                chartControl.Series[idx].ArgumentDataMember = "X";
                                chartControl.Series[idx].ValueDataMembers.AddRange(new string[] { "Y" });
                            }
                            break;
                    }
                }

                if (chartControl.Diagram != null)
                {
                    ((XYDiagram)chartControl.Diagram).EnableAxisXScrolling = true;
                    ((XYDiagram)chartControl.Diagram).EnableAxisXZooming = true;
                    ((XYDiagram)chartControl.Diagram).EnableAxisYScrolling = true;
                    ((XYDiagram)chartControl.Diagram).EnableAxisYZooming = true;

                    ((XYDiagram)chartControl.Diagram).AxisX.VisualRange.Auto = true;
                    ((XYDiagram)chartControl.Diagram).AxisY.VisualRange.Auto = true;
                    if(ChartCode == enChartCode.MeasuredSpectrum_1 || ChartCode == enChartCode.MeasuredSpectrum_2)
                        ((XYDiagram)chartControl.Diagram).AxisY.WholeRange.SetMinMaxValues(-1, 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region void Lib_Change_SeriesVisible()
        private void Lib_Change_SeriesVisible()
        {
            try
            {
                if (_chartData == null)
                {
                    return;
                }

                // Series Process 
                foreach (var dicItem in _chartData.SereisDic)
                {
                    if (chartControl.Series.Any(item => item.Name.Equals(dicItem.Key)))
                    {
                        chartControl.Series[dicItem.Key].Visible = dicItem.Value.isVisible;
                        if(_chartData.SereisDic[dicItem.Key].ChartType == ViewType.Line)
                            (chartControl.Series[dicItem.Key].View as LineSeriesView).LineStyle.DashStyle = dicItem.Value.DashStyle;
                    }
                }

                if (chartControl.Diagram != null)
                {
                    ((XYDiagram)chartControl.Diagram).AxisX.VisualRange.Auto = true;
                    ((XYDiagram)chartControl.Diagram).AxisY.VisualRange.Auto = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region void Lib_Change_SereisThickness()
        private void Lib_Change_SereisThickness()
        {
            try
            {
                if (_chartData == null)
                {
                    return;
                }

                // Series Process 
                foreach (var dicItem in _chartData.SereisDic)
                {
                    if (chartControl.Series.Any(item => item.Name.Equals(dicItem.Key)))
                    {
                        (chartControl.Series[dicItem.Key].View as LineSeriesView).LineStyle.Thickness = dicItem.Value.SeriesThickness;
                        (chartControl.Series[dicItem.Key].View as LineSeriesView).LineStyle.DashStyle = dicItem.Value.DashStyle;
                    }
                }

                if (chartControl.Diagram != null)
                {
                    ((XYDiagram)chartControl.Diagram).AxisX.VisualRange.Auto = true;
                    ((XYDiagram)chartControl.Diagram).AxisY.VisualRange.Auto = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region void Lib_Change_ChartLogScale(UiLibMessage msg)
        private void Lib_Change_ChartLogScale(UiLibMessage msg)
        {
            try
            {
                if (_chartData != null && msg.Parameters.Count == 2)
                {
                    if (chartControl.Diagram != null)
                    {
                        var ChartFlag = Convert.ToBoolean(msg.Parameters[0]);
                        var LogBaseScale = Convert.ToInt32(msg.Parameters[1]);

                        ((XYDiagram)chartControl.Diagram).AxisY.Logarithmic = ChartFlag;
                        ((XYDiagram)chartControl.Diagram).AxisY.LogarithmicBase = LogBaseScale;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #endregion

        #region Event Function

        #region void chartControl_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e)
        private void chartControl_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e)
        {
            foreach (CrosshairElement element in e.CrosshairElements)
            {
                var seriesName = element.Series.Name;
                SeriesPoint currentPoint = element.SeriesPoint;

                if (currentPoint.Tag.GetType() == typeof(ChartValue))
                {
                    ChartValue chartValue = (ChartValue)currentPoint.Tag;
                    element.LabelElement.Text = seriesName + ": " + chartValue.Y.ToString();
                }
            }
        }
        #endregion

        #endregion
    }
}
