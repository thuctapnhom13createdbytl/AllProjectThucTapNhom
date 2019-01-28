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
    public partial class ucDuAn : UserControl
    {
        public ucDuAn()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucDuAn uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucDuAn>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }
    }
}
