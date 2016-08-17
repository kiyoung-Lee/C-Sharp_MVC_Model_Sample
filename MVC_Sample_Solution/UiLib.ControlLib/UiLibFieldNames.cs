using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib.ControlLib
{
    public static class UiLibFieldNames
    {
        private static Dictionary<string, string> _tblNameString;

        static UiLibFieldNames()
        {
            _tblNameString = new Dictionary<string, string>();

            _tblNameString.Add("DeviceInfoView_IsLoad", "  ");
            _tblNameString.Add("DeviceInfoView_RegisteredDate", "Date");

            _tblNameString.Add("StepInfoView_IsLoad", "  ");
            _tblNameString.Add("StepInfoView_RegisteredDate", "Date");

            _tblNameString.Add("RecipeInfoView_IsLoad", "  ");
            _tblNameString.Add("RecipeInfoView_RegisteredDate", "Date");

            _tblNameString.Add("GridViewSolutions_IsLoad", "  ");
            _tblNameString.Add("GridViewSolutions_RegisteredDate", "Date");

            _tblNameString.Add("GridViewHistories_IsLoad", "  ");
            _tblNameString.Add("GridViewHistories_RegisteredDate", "Date");

            _tblNameString.Add("GridViewMaterials_IsLoad", "  ");
            _tblNameString.Add("GridViewMaterials_DrawColor", "Color");
            _tblNameString.Add("GridViewMaterials_RegisteredDate", "Date");

            _tblNameString.Add("GridViewConditions_IsLoad", "  ");
            _tblNameString.Add("GridViewConditions_RegisteredDate", "Date");

            _tblNameString.Add("GridViewSpectrums_IsLoad", "  ");
            _tblNameString.Add("GridViewSpectrums_RegisteredDate", "Date");

            _tblNameString.Add("GridViewParametersFit_InitialValue", "Initial Value");
            _tblNameString.Add("GridViewParametersFit_PriorValue", "Prior\nValue");
            _tblNameString.Add("GridViewParametersFit_PriorWidth", "Prior\nWidth");
            _tblNameString.Add("GridViewParametersFit_PosteriorValue", "Posterior\nValue");
            _tblNameString.Add("GridViewParametersFit_PosteriorWidth", "Posterior\nWidth");

            _tblNameString.Add("GridViewParametersMeta_VirtualValue", "Virtual Value");
            _tblNameString.Add("GridViewParametersMeta_StepID", "Step ID");
            _tblNameString.Add("GridViewParametersMeta_EquipID", "Equip ID");
            _tblNameString.Add("GridViewParametersMeta_RecipeID", "Recipe ID");
            _tblNameString.Add("GridViewParametersMeta_LotID", "Lot ID");
            _tblNameString.Add("GridViewParametersMeta_SlotID", "Slot ID");
            _tblNameString.Add("GridViewParametersMeta_SiteID", "Site ID");
            _tblNameString.Add("GridViewParametersMeta_PointID", "Point ID");

            _tblNameString.Add("GridViewSampling_Polar_Angle", "Polar_Angle\nValue");
            _tblNameString.Add("GridViewSampling_Polar_Setting", "Polar_Angle\nSetting");
            _tblNameString.Add("GridViewSampling_Azimuthal_Angle", "Azimuthal_Angle\nValue");
            _tblNameString.Add("GridViewSampling_Azimuthal_Setting", "Azimuthal_Angle\nSetting");
            _tblNameString.Add("GridViewSampling_Wavelength", "Wavelength\nValue");
            _tblNameString.Add("GridViewSampling_Wavelength_Setting", "Wavelength\nSetting");
            _tblNameString.Add("GridViewSampling_Offset", "Offset");
            _tblNameString.Add("GridViewSampling_Scale", "Scale");
            _tblNameString.Add("GridViewSampling_Weight", "Weight");

            //_tblNameString.Add("GridViewResultSummary_", "");
        }

        public static string GetColumnNameString(string moduleName, string propertyName)
        {
            string keyString = String.Format("{0}_{1}", moduleName, propertyName);
            if (_tblNameString.ContainsKey(keyString) == true)
            {
                return _tblNameString[keyString];
            }

            return propertyName;
        }
    }
}
