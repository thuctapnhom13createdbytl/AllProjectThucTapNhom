using QLHS.DAO;
using QLHS.DTO;
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
    public partial class fHocSinh : Form
    {
        BindingSource DSHS = new BindingSource();
        public fHocSinh()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            LayTatCaHS();
            dtgvHocSinh.DataSource = DSHS;
            LoadCbGioiTinh();
            loadCBLop(cbLop);
            bindingHS();
        }
        void LayTatCaHS()
        {
            DSHS.DataSource = HocSinh_DAO.Instance.TimKiemHS(""); 

        }
        void bindingHS()
        {
            txtMaHS.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "MaHocSinh", true, DataSourceUpdateMode.Never));
            txtTenHS.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "TenHocSinh", true, DataSourceUpdateMode.Never));
            cbLop.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "TenLop", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            dtpkNgaySinh.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtDanToc.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "DanToc", true, DataSourceUpdateMode.Never));
            txtTonGiao.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "TonGiao", true, DataSourceUpdateMode.Never));
            txtTenCha.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "TenCha", true, DataSourceUpdateMode.Never));
            txtTenMe.DataBindings.Add(new Binding("Text", dtgvHocSinh.DataSource, "TenMe", true, DataSourceUpdateMode.Never));
        }
        void LoadCbGioiTinh()
        {
            string[] arr = { "Nam", "Nữ" };
            cbGioiTinh.DataSource = arr;
        }
        void loadCBLop(ComboBox cb)
        {
            cb.DataSource = Lop_DAO.Instance.LayTatCaLop();
            cb.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DSHS.DataSource = HocSinh_DAO.Instance.TimKiemHS(txtTimKiem.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            cbLop.Text = "";
            LoadCbGioiTinh();
            dtpkNgaySinh.Text = DateTime.Now.ToShortDateString() ;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            txtTenCha.Text = "";
            txtTenMe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenHS.Text == "")
                {
                    MessageBox.Show("phải nhập tên học sinh","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                int Them = HocSinh_DAO.Instance.ThemHS(Convert.ToInt32(cbLop.SelectedValue), txtTenHS.Text, cbGioiTinh.Text, dtpkNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtTonGiao.Text, txtDanToc.Text, txtTenCha.Text, txtTenMe.Text);
                if(Them > 0)
                {
                    MessageBox.Show("thêm thành công học sinh", "Thông báo!");
                    LayTatCaHS();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int sua = HocSinh_DAO.Instance.SuaHS(Convert.ToInt32(txtMaHS.Text),Convert.ToInt32(cbLop.SelectedValue), txtTenHS.Text, cbGioiTinh.Text, dtpkNgaySinh.Value, txtDiaChi.Text, txtSDT.Text, txtTonGiao.Text, txtDanToc.Text, txtTenCha.Text, txtTenMe.Text);
                if (sua > 0)
                {
                    MessageBox.Show("sửa thành công học sinh", "Thông báo!");
                    LayTatCaHS();
                }
                else
                {
                    MessageBox.Show("sửa thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa học sinh : " + txtTenHS.Text, "xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    int xoa = HocSinh_DAO.Instance.XoaHS(Convert.ToInt32(txtMaHS.Text));
                    if (xoa > 0)
                    {
                        MessageBox.Show("Xóa thành công học sinh", "Thông báo!");
                        LayTatCaHS();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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
