namespace fruslib
{
    partial class KstomChekTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backPanel = new System.Windows.Forms.Panel();
            this.pnl_textHolder = new System.Windows.Forms.Panel();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.chkHolder = new System.Windows.Forms.Panel();
            this.chkBorder = new System.Windows.Forms.Panel();
            this.chkPnl = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.pnl_textHolder.SuspendLayout();
            this.chkHolder.SuspendLayout();
            this.chkBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.backPanel.Controls.Add(this.pnl_textHolder);
            this.backPanel.Controls.Add(this.chkHolder);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(164, 49);
            this.backPanel.TabIndex = 1;
            // 
            // pnl_textHolder
            // 
            this.pnl_textHolder.Controls.Add(this.txt_value);
            this.pnl_textHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_textHolder.Location = new System.Drawing.Point(53, 0);
            this.pnl_textHolder.Name = "pnl_textHolder";
            this.pnl_textHolder.Size = new System.Drawing.Size(111, 49);
            this.pnl_textHolder.TabIndex = 1;
            // 
            // txt_value
            // 
            this.txt_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_value.Location = new System.Drawing.Point(0, 0);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(111, 15);
            this.txt_value.TabIndex = 2;
            this.txt_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkHolder
            // 
            this.chkHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.chkHolder.Controls.Add(this.chkBorder);
            this.chkHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkHolder.Location = new System.Drawing.Point(0, 0);
            this.chkHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHolder.Name = "chkHolder";
            this.chkHolder.Padding = new System.Windows.Forms.Padding(15);
            this.chkHolder.Size = new System.Drawing.Size(53, 49);
            this.chkHolder.TabIndex = 0;
            // 
            // chkBorder
            // 
            this.chkBorder.BackColor = System.Drawing.Color.White;
            this.chkBorder.Controls.Add(this.chkPnl);
            this.chkBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBorder.Location = new System.Drawing.Point(15, 15);
            this.chkBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBorder.Size = new System.Drawing.Size(23, 19);
            this.chkBorder.TabIndex = 0;
            this.chkBorder.Click += new System.EventHandler(this.ToggleCheked);
            // 
            // chkPnl
            // 
            this.chkPnl.BackColor = System.Drawing.Color.Green;
            this.chkPnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPnl.Location = new System.Drawing.Point(3, 2);
            this.chkPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPnl.Name = "chkPnl";
            this.chkPnl.Size = new System.Drawing.Size(17, 15);
            this.chkPnl.TabIndex = 0;
            this.chkPnl.Click += new System.EventHandler(this.ToggleCheked);
            // 
            // KstomChekTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Name = "KstomChekTextBox";
            this.Size = new System.Drawing.Size(164, 49);
            this.backPanel.ResumeLayout(false);
            this.pnl_textHolder.ResumeLayout(false);
            this.pnl_textHolder.PerformLayout();
            this.chkHolder.ResumeLayout(false);
            this.chkBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel chkHolder;
        private System.Windows.Forms.Panel chkBorder;
        private System.Windows.Forms.Panel chkPnl;
        private System.Windows.Forms.Panel pnl_textHolder;
        private System.Windows.Forms.TextBox txt_value;
    }
}
