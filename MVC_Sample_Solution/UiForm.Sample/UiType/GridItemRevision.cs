using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilLib.ControlLib;

namespace UiForm.Sample.UiType
{
    public class GridItemRevision : NotifyPropertyChangeBase
    {
        internal static InputValueCheck ValueChecker;

        #region Origin Data Field
        
        #endregion

        #region Value Check Flag
        internal bool IsUpdateField { get; set; }
        #endregion

        #region History Load Status
        private bool _isLoad;
        [DisplayName(" ")]
        public bool IsLoad
        {
            get { return _isLoad; }
            internal set { _isLoad = value; }
        }
        #endregion

        #region History Name
        public string Name
        {
            get; set;
        }
        #endregion

        #region Device Registered Date
        [DisplayName("Created Date")]
        public string RegisteredDate
        {
            get; set;
        }
        #endregion

        #region Creator
        public GridItemRevision()
        {
        }
        #endregion
    }
}
