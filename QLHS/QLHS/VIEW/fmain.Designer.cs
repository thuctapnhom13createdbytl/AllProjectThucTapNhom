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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDiem.BackgroundImage = global::QLHS.Properties.Resources.icons8_report_card_96;
            this.btnDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.Gold;
            this.btnDiem.Location = new System.Drawing.Point(452, 122);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(118, 97);
            this.btnDiem.TabIndex = 0;
            this.btnDiem.Text = "ĐIỂM";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHocSinh.BackgroundImage = global::QLHS.Properties.Resources.icons8_student_male_96;
            this.btnHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.ForeColor = System.Drawing.Color.Gold;
            this.btnHocSinh.Location = new System.Drawing.Point(12, 122);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(118, 97);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "HỌC SINH";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.fHocSinh_Click);
            // 
            // btnLop
            // 
            this.btnLop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLop.BackgroundImage = global::QLHS.Properties.Resources.icons8_classroom_100;
            this.btnLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.Color.Gold;
            this.btnLop.Location = new System.Drawing.Point(156, 122);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(118, 97);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "LỚP";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLop.UseVisualStyleBackColor = false;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGiaoVien.BackgroundImage = global::QLHS.Properties.Resources.icons8_school_director_96;
            this.btnGiaoVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Gold;
            this.btnGiaoVien.Location = new System.Drawing.Point(302, 122);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(118, 97);
            this.btnGiaoVien.TabIndex = 3;
            this.btnGiaoVien.Text = "GIÁO VIÊN";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ ĐIỂM HỌC SINH\r\nTHCS LÊ QUÝ ĐÔN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLHS.Properties.Resources.thai2_1483_1440041682;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.btnLop);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnDiem);
            this.Name = "fmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Hoc Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Label label1;
    }
}

