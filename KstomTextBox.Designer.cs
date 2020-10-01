namespace fruslib
{
    partial class KstomTextBox
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
            this.pnl_TextHolder = new System.Windows.Forms.Panel();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.pnl_Highlight = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.pnl_TextHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.backPanel.Controls.Add(this.pnl_TextHolder);
            this.backPanel.Controls.Add(this.pnl_Highlight);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(288, 39);
            this.backPanel.TabIndex = 0;
            // 
            // pnl_TextHolder
            // 
            this.pnl_TextHolder.Controls.Add(this.txt_Content);
            this.pnl_TextHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TextHolder.Location = new System.Drawing.Point(0, 0);
            this.pnl_TextHolder.Name = "pnl_TextHolder";
            this.pnl_TextHolder.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_TextHolder.Size = new System.Drawing.Size(288, 36);
            this.pnl_TextHolder.TabIndex = 1;
            // 
            // txt_Content
            // 
            this.txt_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.txt_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Content.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Content.Location = new System.Drawing.Point(3, 3);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(282, 27);
            this.txt_Content.TabIndex = 2;
            this.txt_Content.TextChanged += new System.EventHandler(this.TextChange);
            this.txt_Content.Enter += new System.EventHandler(this.FocusEnter);
            this.txt_Content.Leave += new System.EventHandler(this.FocusLeave);
            this.txt_Content.MouseEnter += new System.EventHandler(this.HoverColorSet);
            this.txt_Content.MouseLeave += new System.EventHandler(this.HoverColorRemove);
            // 
            // pnl_Highlight
            // 
            this.pnl_Highlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_Highlight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Highlight.Location = new System.Drawing.Point(0, 36);
            this.pnl_Highlight.Name = "pnl_Highlight";
            this.pnl_Highlight.Size = new System.Drawing.Size(288, 3);
            this.pnl_Highlight.TabIndex = 0;
            // 
            // KstomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Name = "KstomTextBox";
            this.Size = new System.Drawing.Size(288, 39);
            this.backPanel.ResumeLayout(false);
            this.pnl_TextHolder.ResumeLayout(false);
            this.pnl_TextHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel pnl_Highlight;
        private System.Windows.Forms.Panel pnl_TextHolder;
        private System.Windows.Forms.TextBox txt_Content;
    }
}
