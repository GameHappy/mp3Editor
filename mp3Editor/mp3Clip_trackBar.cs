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

    class mp3Clip_trackBar :TrackBar
    {
        public mp3Clip_trackBar() : base() { }

    }
}
