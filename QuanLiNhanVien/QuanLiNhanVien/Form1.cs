using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using QuanLiNhanVien.GUI;

namespace QuanLiNhanVien
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain _frmMain;
        public static frmMain FrmMain
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new frmMain();
                }
                return _frmMain;
            }
        }

        public MetroPanel MetroContainer
        {
            get
            {
                return this.mPanelMain;
            }
            set
            {
                this.mPanelMain = value;
            }
        }
 
        private void frmMain_Load(object sender, EventArgs e)
        {
            _frmMain = this; // gán thuộc tính frmMain bằng chính nó
            //khởi tạo uc đăng nhập
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            //add uc đăng nhập vào panel chính từ form
            _frmMain.MetroContainer.Controls.Add(ucMenu);
            _frmMain.MetroContainer.Controls["ucMenu"].BringToFront();
        }

        private void mPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
