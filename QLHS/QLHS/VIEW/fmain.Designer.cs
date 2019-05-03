namespace QLHS
{
    partial class fmain
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
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(339, 148);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(75, 23);
            this.btnDiem.TabIndex = 0;
            this.btnDiem.Text = "ĐIỂM";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(339, 217);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(75, 23);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "HỌC SINH";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.fHocSinh_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(338, 286);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(75, 23);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(350, 352);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(75, 23);
            this.btnGiaoVien.TabIndex = 3;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.btnLop);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnDiem);
            this.Name = "fmain";
            this.Text = "Quan Ly Hoc Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
    }
}

