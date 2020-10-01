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
    public partial class KstomChekTextBox : UserControl
    {

        public KstomChekTextBox()
        {
            InitializeComponent();
        }

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
                if (value == true)
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
                backPanel.BackColor = txt_value.BackColor = chkHolder.BackColor = value;
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
            get { return txt_value.ForeColor; }
            set { txt_value.ForeColor = value; }
        }

        public Font TextFont
        {
            get { return txt_value.Font; }
            set { txt_value.Font = value; }
        }

        public HorizontalAlignment TextAlignment
        {
            get { return txt_value.TextAlign; }
            set { txt_value.TextAlign = value; }
        }

        public Padding TextMargin
        {
            get { return pnl_textHolder.Padding; }
            set { pnl_textHolder.Padding = value; }
        }


        public string Value
        {
            get { return txt_value.Text; }
            set { txt_value.Text = value; }
        }

        public bool Editable
        {
            get { return !txt_value.ReadOnly; }
            set { txt_value.ReadOnly = !value; }
        }


        private void ToggleCheked(object sender, EventArgs e)
        {
            if (AllowToggle)
            {
                this.IsSelected = !this.IsSelected;
                CheckChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool AllowToggle { get; set; }


        


        public event EventHandler CheckChange;
    }
}
