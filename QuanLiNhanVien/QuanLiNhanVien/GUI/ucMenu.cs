using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using QuanLiNhanVien.GUI;

namespace QuanLiNhanVien.GUI
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        string ucName = "";
        private void btn_Click(object sender, EventArgs e)
        {
            MetroTile btn = sender as MetroTile;
            ucName = btn.Tag.ToString();// xác định button uc nào được click
            switch (ucName)
            {
                case "ucNhanVien":
                    ucNhanVien ucNhanVien = new ucNhanVien();
                    ucNhanVien.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucNhanVien);
                    frmMain.FrmMain.MetroContainer.Controls["ucNhanVien"].BringToFront();
                    break;
                case "ucPhongBan":
                    ucPhongBan ucPhongBan = new ucPhongBan();
                    ucPhongBan.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucPhongBan);
                    frmMain.FrmMain.MetroContainer.Controls["ucPhongBan"].BringToFront();
                    break;
                case "ucDuAn":
                    ucDuAn ucDuAn = new ucDuAn();
                    ucDuAn.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucDuAn);
                    frmMain.FrmMain.MetroContainer.Controls["ucDuAn"].BringToFront();
                    break;
                case "ucThanNhan":
                    ucThanNhan ucThanNhan = new ucThanNhan();
                    ucThanNhan.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucThanNhan);
                    frmMain.FrmMain.MetroContainer.Controls["ucThanNhan"].BringToFront();
                    break;
                case "ucPhanCong":
                    ucPhanCong ucPhanCong = new ucPhanCong();
                    ucPhanCong.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucPhanCong);
                    frmMain.FrmMain.MetroContainer.Controls["ucPhanCong"].BringToFront();
                    break;
            }
            foreach (ucMenu uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucMenu>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

    }
}
