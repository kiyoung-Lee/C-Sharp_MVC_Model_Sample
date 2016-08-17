using DevExpress.XtraCharts;
using Mirero.Wiener.TypeLib.Client;
using Mirero.Wiener.UiLib.ControlLib;
using System.Collections.Generic;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public static class TblChartCode
    {
        private static Dictionary<enChartCode, UiType.ChartData> _tblChartCode = new Dictionary<enChartCode, UiType.ChartData>();

        static TblChartCode()
        {
            #region Material
            UiType.ChartData inData = new LibView.UiType.ChartData()
            {
                XAxis = UiLibWords.AXIS_WAVELENGTH,
                YAxis = UiLibWords.AXIS_NK
            };
            inData.SereisDic.Add(UiLibWords.SERIES_N, new UiType.SeriesItem());
            inData.SereisDic.Add(UiLibWords.SERIES_K, new UiType.SeriesItem());
            _tblChartCode.Add(enChartCode.Material_NK, inData);


            inData = new LibView.UiType.ChartData()
            {
                XAxis = UiLibWords.AXIS_WAVELENGTH,
                YAxis = UiLibWords.AXIS_REAL_IMAGE
            };
            inData.SereisDic.Add(UiLibWords.SERIES_REAL, new UiType.SeriesItem());
            inData.SereisDic.Add(UiLibWords.SERIES_IMAGE, new UiType.SeriesItem());
            _tblChartCode.Add(enChartCode.Material_RealImaginary, inData);
            #endregion

            #region Spectrum
            _tblChartCode.Add(enChartCode.MeasuredSpectrum_1, new LibView.UiType.ChartData());
            _tblChartCode.Add(enChartCode.MeasuredSpectrum_2, new LibView.UiType.ChartData());
            #endregion

            #region Jacobian
            _tblChartCode.Add(enChartCode.Jacobian_1, new LibView.UiType.ChartData());
            _tblChartCode.Add(enChartCode.Jacobian_2, new LibView.UiType.ChartData());
            #endregion

            #region Correlation
            _tblChartCode.Add(enChartCode.Measured_Correlation, new LibView.UiType.ChartData());
            #endregion

            #region Fit - Monitoring
            inData = new LibView.UiType.ChartData()
            {
                XAxis = UiLibWords.AXIS_ITER,
                YAxis = UiLibWords.AXIS_QUALITY
            };
            inData.SereisDic.Add(UiLibWords.SERIES_CHISQ, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_CHISQ].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_CHISQ_DOF, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_CHISQ_DOF].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_PVALUE, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_PVALUE].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_RHO, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_RHO].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_MU, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MU].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_NU, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_NU].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_GOF, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_GOF].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_MSE, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MSE].ChartType = ViewType.Point;

            _tblChartCode.Add(enChartCode.Fit_Monitoring, inData);
            #endregion

            #region Generate
            _tblChartCode.Add(enChartCode.GenerateResult_1, new LibView.UiType.ChartData());
            _tblChartCode.Add(enChartCode.GenerateResult_2, new LibView.UiType.ChartData());
            #endregion

            #region Train - Result
            _tblChartCode.Add(enChartCode.TrainResult_1, new LibView.UiType.ChartData());
            _tblChartCode.Add(enChartCode.TrainResult_2, new LibView.UiType.ChartData());
            #endregion

            #region Train - Validate
            _tblChartCode.Add(enChartCode.TrainValidate_1, new LibView.UiType.ChartData());
            _tblChartCode.Add(enChartCode.TrainValidate_2, new LibView.UiType.ChartData());
            #endregion

            #region Train - Quality
            inData = new LibView.UiType.ChartData()
            {
                XAxis = UiLibWords.AXIS_ITER,
                YAxis = UiLibWords.AXIS_QUALITY
            };
            inData.SereisDic.Add(UiLibWords.SERIES_MSE_AUG, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MSE_AUG].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_MSE_IN, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MSE_IN].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_MSE_OUT, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MSE_OUT].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_RHO, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_RHO].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_MU, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_MU].ChartType = ViewType.Point;
            inData.SereisDic.Add(UiLibWords.SERIES_NU, new UiType.SeriesItem());
            inData.SereisDic[UiLibWords.SERIES_NU].ChartType = ViewType.Point;

            _tblChartCode.Add(enChartCode.Train_Monitoring, inData);
            #endregion
        }

        public static UiType.ChartData GetChartData(enChartCode code)
        {
            return (_tblChartCode.ContainsKey(code)) ? _tblChartCode[code] : null;
        }

        public static bool IsExist(enChartCode code)
        {
            return _tblChartCode.ContainsKey(code);
        }
    }
}
