using QLHS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.VIEW
{
    public partial class fGVCN : Form
    {
        BindingSource DSGV = new BindingSource();
        int MaLop;
        public fGVCN(int MaLop)
        {
            InitializeComponent();
            this.MaLop = MaLop;
            load();
        }
        void load()
        {
            dtgvGVCN.DataSource = DSGV;
            DSGV.DataSource = GiaoVien_DAO.Instance.TimKiemGV("");
            bindingGV();
        }
        void bindingGV()
        {
            txtMaGV.DataBindings.Add(new Binding("Text", dtgvGVCN.DataSource, "MaGiaoVien", true, DataSourceUpdateMode.Never));
            txtTenGV.DataBindings.Add(new Binding("Text", dtgvGVCN.DataSource, "TenGiaoVien", true, DataSourceUpdateMode.Never));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSGV.DataSource = GiaoVien_DAO.Instance.TimKiemGV(txtTimKiem.Text);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int them = GVCN_DAO.Instance.ThemGVCN(this.MaLop, Convert.ToInt32(txtMaGV.Text));
            if(them > -1)
            {
               var mess =  MessageBox.Show("Chọn giáo viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
               if(mess == DialogResult.OK)
                {
                    this.Close();
                }
            } else
            {
                MessageBox.Show("chọn thất bại");
            }
        }
    }
}
