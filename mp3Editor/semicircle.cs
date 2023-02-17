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
    public class semicircle : Label
    {

        #region ctor

        public semicircle() : base() { }

        #endregion

        #region Properties
        private int _value;
        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value < Minimum ? Minimum : value > Maximum ? Maximum : value;
                    Invalidate();
                    OnValueChanged(new EventArgs());
                }
            }
        }

        private int _min;
        [DefaultValue(0)]
        public int Minimum
        {
            get => _min;
            set
            {
                if (_min != value)
                {
                    _min = Math.Max(value, 0);
                    if (value > _value) _value = value;
                    if (value > _max) _max = value;
                    Invalidate();
                }
            }
        }

        private int _max = 100;
        [DefaultValue(100)]
        public int Maximum
        {
            get => _max;
            set
            {
                if (_max != value)
                {
                    if (value < 1) value = 1;
                    if (value < _value) _value = value;
                    _max = value;
                    Invalidate();
                }
            }
        }

        private int _trackSize = 10;
        [DefaultValue(10)]
        public int TrackSize
        {
            get => _trackSize;
            set
            {
                if (_trackSize != value)
                {
                    _trackSize = value;
                    Invalidate();
                }
            }
        }

        private Color _trackColor = Color.Gray;
        [DefaultValue(typeof(Color), "Gray")]
        public Color TrackColor
        {
            get => _trackColor;
            set
            {
                if (_trackColor != value)
                {
                    _trackColor = value;
                    Invalidate();
                }
            }
        }

        private Color _valueColor = Color.FromArgb(255, 128, 0);
        [DefaultValue(typeof(Color), "255, 128, 0")]
        public Color ValueColor
        {
            get => _valueColor;
            set
            {
                if (_valueColor != value)
                {
                    _valueColor = value;
                    Invalidate();
                }
            }
        }

        private bool _showValue;
        [DefaultValue(false)]
        public bool ShowValue
        {
            get => _showValue;
            set
            {
                if (_showValue != value)
                {
                    _showValue = value;
                    Invalidate();
                }
            }
        }

        protected override Size DefaultSize => new Size(100, 100);

        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var r = new Rectangle(_trackSize, _trackSize,
                Math.Max(_trackSize * 2, Width - _trackSize * 2),
                Math.Max(_trackSize * 2, (Height - _trackSize * 2) * 2));

            using (var pnTrack = new Pen(_trackColor, _trackSize))
            {
                g.Clear(BackColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.DrawArc(pnTrack, r, 180, 180);

                if (Value > Minimum)
                {
                    var val = (int)Math.Round(180d / Maximum * Value);
                    pnTrack.Color = _valueColor;
                    // pnTrack.Width -= 2; // uncomment and try...
                    g.DrawArc(pnTrack, r, 180, val);
                }
            }

            if (_showValue)
            {
                TextRenderer.DrawText(g, Value.ToString(), Font, r, ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        #endregion

        #region Events

        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e) =>
            ValueChanged?.Invoke(this, e);

        #endregion
    }
}