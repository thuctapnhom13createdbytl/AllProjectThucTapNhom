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

namespace QuanLiNhanVien.GUI
{
    public partial class ucThanNhan : UserControl
    {
        public ucThanNhan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucThanNhan uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucThanNhan>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }
    }
}
