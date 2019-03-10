using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.DAO;
using QuanLyKho.DTO;

namespace QuanLyKho.VIEW
{
    public partial class fNhanVien : Form
    {
        BindingSource DanhSachNV = new BindingSource();
        //BindingSource DanhSach
        public fNhanVien()
        {
            InitializeComponent();
            Load();
        }

        //lấy tất cả dữ liệu đưa vào DG

            void Load()
        {
            dtgvNhanVien.DataSource = DanhSachNV;
            LayTatCaNV();
            loadcbGioiTinh(cbGioiTinh);
            bindingNhanVien();
        }

        void LayTatCaNV()
        {
            DanhSachNV.DataSource = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
        }

        void loadcbGioiTinh(ComboBox cb)
        {
            cb.DataSource = NhanVien_DAO.Instance.LoadDanhSachNhanVien();
            cb.DisplayMember = "GioiTinh";
            cb.ValueMember = "Ma_NV";
        }

        void bindingNhanVien()
        {
            txtMaNhanVien.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "Ma_NV", true, DataSourceUpdateMode.Never));
            txtTenNhanVien.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "Ten_NV", true, DataSourceUpdateMode.Never));
            txtSdtNhanVien.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "SDT_NV", true, DataSourceUpdateMode.Never));
            txtEmailNhanVien.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "Email_NV", true, DataSourceUpdateMode.Never));
            dtpkNSNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "Ngaysinh_NV", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenNhanVien.Text == "")
                {
                    MessageBox.Show("Điền Tên Nhân Viên");
                }
                else
                {
                    bool them = NhanVien_DAO.Instance.ThemNhanVien(txtTenNhanVien.Text,cbGioiTinh.Text, dtpkNSNV.Value, txtSdtNhanVien.Text , txtEmailNhanVien.Text);
                    if (them)
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                LayTatCaNV();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNhanVien.Text == "")
                {
                    MessageBox.Show("Điền Tên Nhân Viên");
                }
                else
                {
                    bool sua = NhanVien_DAO.Instance.SuaNhanVien(Convert.ToInt16(txtMaNhanVien.Text), txtTenNhanVien.Text, cbGioiTinh.Text, dtpkNSNV.Value, txtSdtNhanVien.Text, txtEmailNhanVien.Text);
                    if (sua)
                    {
                        MessageBox.Show("Cập Nhật Thàng Công");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại");
                    }
                }
                LayTatCaNV();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNhanVien.Text =="")
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
                else
                {
                    bool xoa = NhanVien_DAO.Instance.XoaNhanVien(Convert.ToInt16(txtMaNhanVien.Text));
                    if(xoa)
                    {
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Xoá Thất Bại");
                    }
                }
                LayTatCaNV();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<NhanVien_DTO> NV = NhanVien_DAO.Instance.TimKiemNV(txtTimKiemNhanVien.Text.ToString());
            if(NV.Count<= 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
            else
            {
                this.DanhSachNV.DataSource = NV;
            }
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemNhanVien.Text=="")
            {
                LayTatCaNV();
            }
        }
    }
}
