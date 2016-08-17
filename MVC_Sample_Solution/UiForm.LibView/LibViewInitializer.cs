using System.ComponentModel;
using TypeLib.OriginType;
using TypeLib.Service;

namespace Mirero.Wiener.UiForm.LibView
{
    public class LibViewInitializer
    {
        public AppConfigurator AppMain { get; set; }
        public OriginType Solution { get; set; }

        #region void Init()
        public void Init()
        {

            #region Bindding Object Generate
            BindListCollection bindListCollection = new BindListCollection();
            AppMain.TblBindList.Add(enProjectCode.LibView_Main, bindListCollection);
            #endregion
        }
        #endregion

        #region Creator
        public LibViewInitializer(OriginType solution)
        {
            Solution = solution;
        }
        #endregion
    }
}
