using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsManager.CustomComponents
{
    [DefaultEvent("_TextChanged")] // nastavenie defaultneho eventu pri dvojkliku v dizajneri na komponent
    public partial class CustomTextbox : UserControl
    {

        public event EventHandler _TextChanged;
        #region Fields

        private Color reserveColor = Color.Black;
        private Color borderColor = Color.DarkGray;
        private int borderSize = 2;
        private Color borderFocusColor = Color.Indigo;
        private bool isFocused = false;
        private bool underlinedStyle = false;
        private Color placeholderColor = Color.Gray;
        private string placeholderText = string.Empty;
        private bool isPlaceholder = false;
        private bool passwordChar = false;
        private Color backColor = Color.White;
        #endregion

        #region Constructor
        public CustomTextbox()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }


        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder) textBox1.ForeColor = value;
            }
        }

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

 
        public bool PasswordChar { get => passwordChar; set { passwordChar = value; textBox1.UseSystemPasswordChar = value; } }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set => textBox1.Multiline = value;
        }

        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }

        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }

        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; reserveColor = value; } }
 
        public override Font Font
        {
            get => base.Font; set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        public string Texts
        {
            get
            {
                if (isPlaceholder)
                {
                    return "";
                }
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        #endregion

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()) && placeholderText.Trim() != string.Empty)
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = PlaceholderColor;
                if (passwordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = reserveColor;
                if (PasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            textBox1.BackColor = this.BackColor;
            if (isPlaceholder)
            {
                textBox1.ForeColor = PlaceholderColor;
            }
            else
            {
                textBox1.ForeColor = this.ForeColor;
            }
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {

                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void UpdateControlHeight()
        {
            if (this.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                this.Multiline = true;
                this.MinimumSize = new Size(0, textHeight);
                this.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #region Overrides
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        #endregion
        #region Events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
        #endregion
    }
}
