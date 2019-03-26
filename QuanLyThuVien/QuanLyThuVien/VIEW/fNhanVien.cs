using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.VIEW
{
    public partial class fNhanVien : Form
    {
        BindingSource DanhSachNV = new BindingSource();
        public fNhanVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgNhanVien.DataSource = DanhSachNV;
            LayTatCaNV();
            bindingNhanVien();
        }
        void LayTatCaNV()
        {
            DanhSachNV.DataSource = NhanVien_DAO.Instance.LoadToanBoNhanVien();
        }
        void bindingNhanVien()
        {
            txt_MaNV.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
            txt_hotenNV.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txt_dcNV.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txt_sdtNV.DataBindings.Add(new Binding("Text", dtgNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_hotenNV.Text == "")
                {
                    MessageBox.Show("Không được để trống tên nhan vien");
                }
                else
                {
                    bool them = NhanVien_DAO.Instance.ThemNhanVien(txt_MaNV.Text, txt_hotenNV.Text, txt_dcNV.Text, txt_sdtNV.Text);
                    if (them)
                    {
                        MessageBox.Show("Thêm nhan vien thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
           // try
          //  {
                if (txt_MaNV.Text == "")
                {
                    MessageBox.Show("Chọn 1 nhan vien để xóa");
                }
                else
                {
                    bool xoa = NhanVien_DAO.Instance.XoaNhanVien(txt_MaNV.Text);
          
              
                    if (xoa)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                LayTatCaNV();

           // }
            /*
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btn_CapNhatNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_hotenNV.Text == "")
                {
                    MessageBox.Show("Không được để trống tên nhan vien");
                }
                else
                {
                    bool sua = NhanVien_DAO.Instance.CapNhatNhanVien(txt_MaNV.Text.ToString(),txt_hotenNV.Text.ToString(), txt_dcNV.Text.ToString(),Convert.ToInt32( txt_sdtNV.Text));
                    if (sua)
                    {
                        MessageBox.Show("Cập nhật nhan vien thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                LayTatCaNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            List<NhanVien_DTO> NV = NhanVien_DAO.Instance.TimKiemNV(txt_timkiemNV.Text.ToString());
            if (NV.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy nhan vien nào.");
            }
            else
            {
                this.DanhSachNV.DataSource = NV;
            }
        }
    }
}
