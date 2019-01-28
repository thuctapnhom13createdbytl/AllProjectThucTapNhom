namespace QuanLiNhanVien
{
    partial class frmMain
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
            this.mPanelMain = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mPanelMain
            // 
            this.mPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanelMain.HorizontalScrollbarBarColor = true;
            this.mPanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelMain.HorizontalScrollbarSize = 10;
            this.mPanelMain.Location = new System.Drawing.Point(20, 60);
            this.mPanelMain.Name = "mPanelMain";
            this.mPanelMain.Size = new System.Drawing.Size(693, 288);
            this.mPanelMain.TabIndex = 0;
            this.mPanelMain.VerticalScrollbarBarColor = true;
            this.mPanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelMain.VerticalScrollbarSize = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 368);
            this.Controls.Add(this.mPanelMain);
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhân Viên";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelMain;
    }
}

