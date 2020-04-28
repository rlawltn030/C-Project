namespace Hotel_Management_System
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.고객관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객관리ToolStripMenuItem,
            this.방관리ToolStripMenuItem,
            this.예약관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 고객관리ToolStripMenuItem
            // 
            this.고객관리ToolStripMenuItem.Name = "고객관리ToolStripMenuItem";
            this.고객관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.고객관리ToolStripMenuItem.Text = "고객 관리";
            this.고객관리ToolStripMenuItem.Click += new System.EventHandler(this.고객관리ToolStripMenuItem_Click);
            // 
            // 방관리ToolStripMenuItem
            // 
            this.방관리ToolStripMenuItem.Name = "방관리ToolStripMenuItem";
            this.방관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.방관리ToolStripMenuItem.Text = "객실 관리";
            this.방관리ToolStripMenuItem.Click += new System.EventHandler(this.방관리ToolStripMenuItem_Click);
            // 
            // 예약관리ToolStripMenuItem
            // 
            this.예약관리ToolStripMenuItem.Name = "예약관리ToolStripMenuItem";
            this.예약관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.예약관리ToolStripMenuItem.Text = "예약 관리";
            this.예약관리ToolStripMenuItem.Click += new System.EventHandler(this.예약관리ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "호텔 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약관리ToolStripMenuItem;
    }
}