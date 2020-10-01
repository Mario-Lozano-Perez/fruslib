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
    public partial class KstomChekBox : UserControl
    {
        public Padding CheckContainerPadding
        {
            get { return chkHolder.Padding; }
            set { chkHolder.Padding = value; }
        }

        public Color SelectedColor { get; set; }

        private bool SelectionHelper { get; set; }
        public bool IsSelected
        {
            get { return this.SelectionHelper; }
            set
            {
                this.SelectionHelper = value;
                if(value == true)
                {
                    chkPnl.BackColor = this.SelectedColor;
                }
                else
                {
                    chkPnl.BackColor = this.BackgroundColor;
                }
            }
        }

        public Color BackgroundColor
        {
            get { return backPanel.BackColor; }
            set
            {
                backPanel.BackColor = lbl_Text.BackColor = chkHolder.BackColor = value;
            }
        }

        public Color CheckBorderColor
        {
            get { return chkBorder.BackColor; }
            set { chkBorder.BackColor = value; }
        }

        public Padding ChkBorderPadding
        {
            get { return chkBorder.Padding; }
            set { chkBorder.Padding = value; }
        }

        public Color TextColor
        {
            get { return lbl_Text.ForeColor; }
            set { lbl_Text.ForeColor = value; }
        }

        public Font TextFont
        {
            get { return lbl_Text.Font; }
            set { lbl_Text.Font = value; }
        }

        public ContentAlignment TextAlignment
        {
            get { return lbl_Text.TextAlign; }
            set { lbl_Text.TextAlign = value; }
        }


        public string Value
        {
            get { return lbl_Text.Text; }
            set { lbl_Text.Text = value; }
        }
        

        public KstomChekBox()
        {
            InitializeComponent();
        }

        private void ToggleCheked(object sender, EventArgs e)
        {
            this.IsSelected = !this.IsSelected;
            CheckChange?.Invoke(this, EventArgs.Empty);
        }

        [Category("Methods")]
        public event EventHandler CheckChange;
    }
}
