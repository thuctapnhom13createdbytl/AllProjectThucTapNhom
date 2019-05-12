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

namespace QLHS
{
    public partial class fGiaoVien : Form
    {
        BindingSource DSGV = new BindingSource();
        public fGiaoVien()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            LayTatCaGV();
            LoadCBMonHoc(cbMonHoc);
            dtgvGiaoVien.DataSource = DSGV;
            BindDingGV();
        }
        void LayTatCaGV()
        {
            DSGV.DataSource = GiaoVien_DAO.Instance.TimKiemGV("");
            
        }
        void LoadCBMonHoc(ComboBox cb)
        {
            cb.DataSource = MonHoc_DAO.Instance.LayTatCaMonHoc();
            cb.DisplayMember = "TenMonHoc";
            cb.ValueMember = "MaMonHoc";
        }
        void BindDingGV()
        {
            txtMaGV.DataBindings.Add(new Binding("Text", dtgvGiaoVien.DataSource, "MaGiaoVien", true, DataSourceUpdateMode.Never));
            txtTenGV.DataBindings.Add(new Binding("Text", dtgvGiaoVien.DataSource, "TenGiaoVien", true, DataSourceUpdateMode.Never));
            cbMonHoc.DataBindings.Add(new Binding("Text", dtgvGiaoVien.DataSource, "TenMonHoc", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvGiaoVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dtgvGiaoVien.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSGV.DataSource = GiaoVien_DAO.Instance.TimKiemGV(txtTimKiem.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            LoadCBMonHoc(cbMonHoc);
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaGV.Text != "")
                {
                    MessageBox.Show("Giáo viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txtTenGV.Text == "")
                {
                    MessageBox.Show("phải nhập tên giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ThemGV = GiaoVien_DAO.Instance.ThemGV(Convert.ToInt32(cbMonHoc.SelectedValue), txtTenGV.Text, txtSDT.Text, txtEmail.Text);
                if(ThemGV == -1)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LayTatCaGV();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenGV.Text == "")
                {
                    MessageBox.Show("phải nhập tên giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ThemGV = GiaoVien_DAO.Instance.SuaGV(Convert.ToInt32(txtMaGV.Text), Convert.ToInt32(cbMonHoc.SelectedValue), txtTenGV.Text, txtSDT.Text, txtEmail.Text);
                if (ThemGV == -1)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LayTatCaGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenGV.Text == "")
                {
                    MessageBox.Show("phải chọn 1 giáo viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên: "+txtTenGV.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    int ThemGV = GiaoVien_DAO.Instance.XoaGV(Convert.ToInt32(txtMaGV.Text));
                    if (ThemGV == -1)
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LayTatCaGV();
                    }
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
