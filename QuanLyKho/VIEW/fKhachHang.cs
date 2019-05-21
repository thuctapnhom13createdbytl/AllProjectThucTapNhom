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
    public partial class fKhachHang : MetroFramework.Forms.MetroForm
    {
        BindingSource DanhSachKH = new BindingSource();
        public fKhachHang()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgKhacHang.DataSource = DanhSachKH;
            LayTatCaKH();
            bindingKhachHang();


        }
        void LayTatCaKH()
        {
            DanhSachKH.DataSource = KhachHang_DAO.Instance.LoadToanBoKhachHang();
        }

        void bindingKhachHang()
        {
            txtMaKH.DataBindings.Add(new Binding("Text",dtgKhacHang.DataSource, "Ma_KH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dtgKhacHang.DataSource, "Ten_KH", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgKhacHang.DataSource, "DiaChi_KH", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgKhacHang.DataSource, "SDT_KH", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dtgKhacHang.DataSource, "Email_KH", true, DataSourceUpdateMode.Never));
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKH.Text == "" )
                {
                    MessageBox.Show("Không được để trống tên khách hàng");
                }
                else
                {
                    bool them = KhachHang_DAO.Instance.ThemKhachHang(txtTenKH.Text,txtDiaChi.Text,txtSDT.Text,txtEmail.Text);
                    if (them)
                    {
                        MessageBox.Show("Thêm khách hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaKH();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Chọn 1 khách hàng để xóa");
                }
                else
                {
                    var xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng: " + txtTenKH.Text, "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(xacnhan == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        bool xoa = KhachHang_DAO.Instance.XoaKhachHang(Convert.ToInt32(txtMaKH.Text));
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công");
                            LayTatCaKH();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Không được để trống tên khách hàng");
                    return;
                }
                if(txtMaKH.Text == "")
                {
                    MessageBox.Show("Phải chọn 1 khách hàng để cập nhật");
                    return;
                }
                else
                {
                    bool sua = KhachHang_DAO.Instance.CapNhatKhachhang(Convert.ToInt32(txtMaKH.Text),txtTenKH.Text.ToString(), txtDiaChi.Text.ToString(), txtSDT.Text,txtEmail.Text.ToString());
                    if (sua)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                LayTatCaKH();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<KhachHang_DTO> KH = KhachHang_DAO.Instance.TimKiemKH(txtTimKiemKH.Text.ToString());
            if (KH.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng nào.");
            }
            else
            {
                this.DanhSachKH.DataSource = KH;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
    }
}
