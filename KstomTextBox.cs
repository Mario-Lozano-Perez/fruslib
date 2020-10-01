using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruslib
{
    public partial class KstomTextBox : UserControl
    {

        public Color BackgroundColor
        {
            get { return backPanel.BackColor; }
            set { backPanel.BackColor = txt_Content.BackColor = pnl_TextHolder.BackColor = value; }
        }

        public Padding OverallPading
        {
            get { return backPanel.Padding; }
            set { backPanel.Padding = value; }
        }

        public Padding TextPadding
        {
            get { return pnl_TextHolder.Padding; }
            set { pnl_TextHolder.Padding = value; }
        }

        public Font TextFont
        {
            get { return txt_Content.Font; }
            set { txt_Content.Font = value; }
        }

        public Color TextColor
        {
            get { return txt_Content.ForeColor; }
            set { txt_Content.ForeColor = value; }
        }

        public string Value
        {
            get { return txt_Content.Text; }
            set { txt_Content.Text = value; }
        }


        public HorizontalAlignment TextAlign
        {
            get { return txt_Content.TextAlign; }
            set { txt_Content.TextAlign = value; }
        }

        public Color UnderBarColor
        {
            get
            {
                return UnderLineBackgraund;
            }
            set
            {
                this.UnderLineBackgraund = value;
                if (!txt_Content.Focused)
                {
                    pnl_Highlight.BackColor = UnderLineBackgraund;
                }
            }
        }

        private Color UnderLineBackgraund { get; set; }
        public Color UnderBarHoverColor { get; set; }
        public Color UnderBarFocusColor { get; set; }

        public Color UnderBarErrorColor { get; set; }
        private bool isError { get; set; }

        public int UnderBarHeight
        {
            get { return pnl_Highlight.Height; }
            set { pnl_Highlight.Height = value; }
        }

        public bool UseSystemPasswordChar
        {
            get { return txt_Content.UseSystemPasswordChar; }
            set { txt_Content.UseSystemPasswordChar = value; }
        }

        public bool Paragraph
        {
            get { return txt_Content.Multiline; }
            set
            {
                txt_Content.Multiline = value;
                txt_Content.Dock = DockStyle.Fill;
            }
        }

        public int TextLetters
        {
            get { return txt_Content.MaxLength; }
            set { txt_Content.MaxLength = value; }
        }
        


        public KstomTextBox()
        {
            InitializeComponent();
            this.isError = false;
            this.UnderBarHoverColor = this.UnderBarFocusColor = this.UnderBarColor = this.UnderBarErrorColor = pnl_Highlight.BackColor;
        }

        private void HoverColorSet(object sender, EventArgs e)
        {
            if (!txt_Content.Focused)
            {
                pnl_Highlight.BackColor = UnderBarHoverColor;
            }
        }


        private void HoverColorRemove(object sender, EventArgs e)
        {
            if (!txt_Content.Focused)
            {
                pnl_Highlight.BackColor = UnderLineBackgraund;
            }
        }

        private void FocusEnter(object sender, EventArgs e)
        {
            pnl_Highlight.BackColor = UnderBarFocusColor;
        }

        private void FocusLeave(object sender, EventArgs e)
        {
            pnl_Highlight.BackColor = UnderLineBackgraund;

        }

        public void IsWrong()
        {
            txt_Content.Focus();
            this.isError = true;
            pnl_Highlight.BackColor = this.UnderBarErrorColor;
        }

        private void TextChange(object sender, EventArgs e)
        {
            if(this.isError == true)
            {
                this.isError = false;
                pnl_Highlight.BackColor = this.UnderBarFocusColor;
            }
        }
    }
}
