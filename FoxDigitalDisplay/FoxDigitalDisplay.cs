using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.FoxCouncil.FoxDigitalDisplay
{
    [ToolboxItem(true)]
    [Designer(typeof(FoxDigitalDisplayDesigner))]
    public partial class FoxDigitalDisplay : Control
    {
        #region Constants
        private const int DEFAULT_CHAR_WIDTH = 5;
        private const int DEFAULT_CHAR_HEIGHT = 7;
        #endregion

        #region Private Member Variables
        bool m_isChangingDepth = false;

        int m_drawDepth = 2;
        int m_displayWidth = 15;
        int m_displayHeight = 1;
        int m_displayPixelPadding = 1;

        int m_displayStringOffset = 0;

        Color m_displayForeColor = Color.Black;
        Color m_displayBackColor = Color.LightGray;

        Timer m_displayAnimationTimer;
        bool m_displayAnimationDirectionLeft = true;
        #endregion

        #region Public Properties
        [Category("Display Properties")]
        [Description("How many characters to display width wise.")]
        public int DisplayWidth
        {
            get
            {
                return m_displayWidth;
            }

            set
            {
                m_displayWidth = value;
                Width = GetBaseWidth() * m_displayWidth;
                Invalidate();
            }
        }

        [Category("Display Properties")]
        [Description("How many characters to display height wise.")]
        public int DisplayHeight
        {
            get
            {
                return m_displayHeight;
            }

            set
            {
                m_displayHeight = value;
                Height = GetBaseHeight() * m_displayHeight;
                Invalidate();
            }
        }

        [Category("Display Properties")]
        [Description("How thick the characters pixels are.")]
        public int DrawDepth
        {
            get
            {
                return m_drawDepth;
            }
            
            set
            {
                if (value < 1)
                {
                    m_drawDepth = 1;
                }
                else
                {
                    m_drawDepth = value;
                }

                m_isChangingDepth = true;

                DisplayWidth = m_displayWidth;
                DisplayHeight = m_displayHeight;

                m_isChangingDepth = false;

                Invalidate();
            }
        }

        [Category("Display Properties")]
        [Description("How far apart the pixels are.")]
        public int PixelPadding
        {
            get
            {
                return m_displayPixelPadding;
            }

            set
            {
                if (value < 1)
                {
                    m_displayPixelPadding = 1;
                }
                else
                {
                    m_displayPixelPadding = value;
                }

                m_isChangingDepth = true;

                DisplayWidth = m_displayWidth;
                DisplayHeight = m_displayHeight;

                m_isChangingDepth = false;

                Invalidate();
            }
        }

        [Category("Display Properties")]
        [Description("What color the ON pixels are.")]
        public Color DisplayForeColor
        {
            get
            {
                return m_displayForeColor;
            }

            set
            {
                m_displayForeColor = value;
                Invalidate();
            }
        }

        [Category("Display Properties")]
        [Description("What color the OFF pixels are.")]
        public Color DisplayBackColor
        {
            get
            {
                return m_displayBackColor;
            }

            set
            {
                m_displayBackColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Control Subclass Overrides
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override bool AutoSize
        {
            get
            {
                return true;
            }

            set
            {
                base.AutoSize = true;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;

                m_displayStringOffset = 0;

                if (System.Diagnostics.Process.GetCurrentProcess().ProcessName != "devenv")
                {
                    if (value.Length <= DisplayWidth)
                    {
                        m_displayAnimationTimer.Stop();
                    }
                    else
                    {
                        m_displayAnimationTimer.Start();
                    }
                }

                Invalidate();
            }
        }
        #endregion

        #region Constructor
        public FoxDigitalDisplay()
        {
            InitializeComponent();

            m_displayAnimationTimer = new Timer();
            m_displayAnimationTimer.Interval = 1000;
            m_displayAnimationTimer.Tick += DisplayAnimationTimer_Tick;

            DoubleBuffered = true;
        }
        #endregion

        #region Private Methods
        private int GetBaseHeight()
        {
            return (m_drawDepth * DEFAULT_CHAR_HEIGHT + m_displayPixelPadding * DEFAULT_CHAR_HEIGHT) + m_displayPixelPadding;
        }

        private int GetBaseWidth()
        {
            return (m_drawDepth * DEFAULT_CHAR_WIDTH + m_displayPixelPadding * DEFAULT_CHAR_WIDTH) + m_displayPixelPadding;
        }

        private void DisplayAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (m_displayAnimationDirectionLeft)
            {
                if (m_displayStringOffset >= Text.Length - DisplayWidth)
                {
                    m_displayAnimationDirectionLeft = false;
                }
                else
                {
                    m_displayStringOffset++;
                }
            }
            else
            {
                if (m_displayStringOffset == 0)
                {
                    m_displayAnimationDirectionLeft = true;
                }
                else
                {
                    m_displayStringOffset--;
                }
            }            

            Invalidate();
        }

        private void DrawCharacter(Graphics c_graphicsHandle, int c_xOffset, int c_yOffset, int c_charIndex)
        {
            char a_char = char.MinValue;
            bool[] a_font = null;

            if (c_charIndex < Text.Length)
            {
                a_char = Text[c_charIndex + m_displayStringOffset];

                if (FoxDigitalDisplayFont.Regular.ContainsKey(a_char))
                {
                    a_font = FoxDigitalDisplayFont.Regular[a_char];
                }
            }

            Pen a_pen = new Pen(ForeColor);
            SolidBrush a_brushOn = new SolidBrush(DisplayForeColor);
            SolidBrush a_brushOff = new SolidBrush(DisplayBackColor);

            Size a_pixelSize = new Size(m_drawDepth, m_drawDepth);

            // Alright fine, changed...
            int a_totalPixelSize = m_drawDepth + m_displayPixelPadding;

            int a_row = 0;
            int a_col = 0;

            for (int x = 0; x < 35; x++)
            {
                if (a_col == 5)
                {
                    a_col = 0;
                    a_row++;
                }

                Point a_pixelPoint = new Point(c_xOffset + a_col * a_totalPixelSize, c_yOffset + a_row * a_totalPixelSize);
                Rectangle a_pixelRect = new Rectangle(a_pixelPoint, a_pixelSize);

                SolidBrush a_paintingBrush = a_brushOff;

                if (a_font != null && a_font[x])
                {
                    a_paintingBrush = a_brushOn;
                }

                c_graphicsHandle.FillRectangle(a_paintingBrush, a_pixelRect);

                a_col++;
            }
        }
        #endregion

        #region Control Method Overrides
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int a_baseWidth = GetBaseWidth();
            int a_baseHeight = GetBaseHeight();

            if (!m_isChangingDepth)
            {
                m_displayWidth = (int)Math.Floor(width / (decimal)a_baseWidth);
                m_displayHeight = (int)Math.Floor(height / (decimal)a_baseHeight);

                if (m_displayWidth < 1)
                {
                    m_displayWidth = 1;
                }

                if (m_displayHeight < 1)
                {
                    m_displayHeight = 1;
                }
            }

            base.SetBoundsCore(x, y, a_baseWidth * m_displayWidth, a_baseHeight * m_displayHeight, specified);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            int a_totalChars = DisplayWidth * DisplayHeight;

            int a_row = 0;
            int a_col = 0;

            for (int x = 0; x < a_totalChars; x++)
            {
                if (a_col == DisplayWidth)
                {
                    a_col = 0;
                    a_row++;
                }

                DrawCharacter(pe.Graphics, a_col * GetBaseWidth(), a_row * GetBaseHeight(), x);

                a_col++;
            }
        }
        #endregion
    }
}
