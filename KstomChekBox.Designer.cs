namespace fruslib
{
    partial class KstomChekBox
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
            this.lbl_Text = new System.Windows.Forms.Label();
            this.chkHolder = new System.Windows.Forms.Panel();
            this.chkBorder = new System.Windows.Forms.Panel();
            this.chkPnl = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.chkHolder.SuspendLayout();
            this.chkBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.backPanel.Controls.Add(this.lbl_Text);
            this.backPanel.Controls.Add(this.chkHolder);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(123, 40);
            this.backPanel.TabIndex = 0;
            // 
            // lbl_Text
            // 
            this.lbl_Text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Text.ForeColor = System.Drawing.Color.White;
            this.lbl_Text.Location = new System.Drawing.Point(40, 0);
            this.lbl_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(83, 40);
            this.lbl_Text.TabIndex = 1;
            this.lbl_Text.Text = "Valor";
            this.lbl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Text.Click += new System.EventHandler(this.ToggleCheked);
            // 
            // chkHolder
            // 
            this.chkHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.chkHolder.Controls.Add(this.chkBorder);
            this.chkHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkHolder.Location = new System.Drawing.Point(0, 0);
            this.chkHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHolder.Name = "chkHolder";
            this.chkHolder.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.chkHolder.Size = new System.Drawing.Size(40, 40);
            this.chkHolder.TabIndex = 0;
            // 
            // chkBorder
            // 
            this.chkBorder.BackColor = System.Drawing.Color.White;
            this.chkBorder.Controls.Add(this.chkPnl);
            this.chkBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBorder.Location = new System.Drawing.Point(11, 12);
            this.chkBorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBorder.Size = new System.Drawing.Size(18, 16);
            this.chkBorder.TabIndex = 0;
            // 
            // chkPnl
            // 
            this.chkPnl.BackColor = System.Drawing.Color.Green;
            this.chkPnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPnl.Location = new System.Drawing.Point(2, 2);
            this.chkPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPnl.Name = "chkPnl";
            this.chkPnl.Size = new System.Drawing.Size(14, 12);
            this.chkPnl.TabIndex = 0;
            this.chkPnl.Click += new System.EventHandler(this.ToggleCheked);
            // 
            // KstomChekBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KstomChekBox";
            this.Size = new System.Drawing.Size(123, 40);
            this.backPanel.ResumeLayout(false);
            this.chkHolder.ResumeLayout(false);
            this.chkBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Panel chkHolder;
        private System.Windows.Forms.Panel chkBorder;
        private System.Windows.Forms.Panel chkPnl;
    }
}
