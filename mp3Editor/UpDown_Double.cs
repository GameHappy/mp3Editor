using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace mp3Editor
{
    [DesignerCategory("Code")]
    [DefaultProperty("Value")]
    [DefaultEvent("ValueChanged")]
    [ToolboxItem(typeof(ToolboxItem))]
    [ToolboxBitmap(typeof(ProgressBar))]
    public class UpDown_Double : NumericUpDown
    {
        #region ctor
        public UpDown_Double() : base() { }
        #endregion
        #region Properties
        #endregion
    }
}