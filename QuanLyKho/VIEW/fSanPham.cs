using QuanLyKho.DAO;
using QuanLyKho.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.VIEW
{
    public partial class fSanPham: MetroFramework.Forms.MetroForm
    {
        BindingSource DanhSachSP = new BindingSource();
        BindingSource DanhSachLSP = new BindingSource();
        BindingSource DanhSachNSX = new BindingSource();
        public fSanPham()
        {
            InitializeComponent();
            Load();
            
        }
        //lấy tất cả dữ liệu đưa vào dataGridView
        void Load()
        {
            dtgvSanPham.DataSource = DanhSachSP;
            dtgvLSP.DataSource = DanhSachLSP;
            dtgvNSX.DataSource = DanhSachNSX;
            LayTatCaSP();
            LayTatCaLSP();
            LayTatCaNSX();
            loadcbNSX(cbTenNhaSanXuat);
            loadcbLSP(cbLoaiSanPham);
            bindingSanPham();
            bindingLoaiSP();
            bindingNSX();
        }
        #region load
        void LayTatCaSP()
        {
            DanhSachSP.DataSource = SanPham_DAO.Instance.LayTatCaSanPham();
        }
        void LayTatCaLSP()
        {
            DanhSachLSP.DataSource = LoaiSanPham_DAO.Instance.LayTatCaLoaiSanPham();
        }
        void LayTatCaNSX()
        {
            DanhSachNSX.DataSource = NhaSanXuat_DAO.Instance.LayTatCaNSX();
        }
        void loadcbNSX(ComboBox cb)
        {
            cb.DataSource = NhaSanXuat_DAO.Instance.LayTatCaNSX();
            cb.DisplayMember = "TenNSX";
            cb.ValueMember = "MaNSX";
        }
        void loadcbLSP(ComboBox cb)
        {
            cb.DataSource = LoaiSanPham_DAO.Instance.LayTatCaLoaiSanPham();
            cb.DisplayMember = "TenLSP";
            cb.ValueMember = "MaLSP";
        }
        #endregion

        #region binding
        void bindingSanPham()
        {
            txtDonGia.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            txtMaSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtTenSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtThongSoKyThuat.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "ThongSoKyThuat", true, DataSourceUpdateMode.Never));
            nrudSoLuong.DataBindings.Add(new Binding("Value", dtgvSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            cbLoaiSanPham.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "tenLoaiSP", true, DataSourceUpdateMode.Never));
            cbTenNhaSanXuat.DataBindings.Add(new Binding("Text", dtgvSanPham.DataSource, "TenNSX", true, DataSourceUpdateMode.Never));
        }
        void bindingLoaiSP()
        {
            txtMaLSP.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "MaLSP", true, DataSourceUpdateMode.Never));
            txtTenLSP.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "TenLSP", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dtgvLSP.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }
        void bindingNSX()
        {
            txtMa_NSX.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "MaNSX", true, DataSourceUpdateMode.Never));
            txtTen_NSX.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "TenNSX", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "DiaChiNSX", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "sdtNSX", true, DataSourceUpdateMode.Never));
            txtWebsite.DataBindings.Add(new Binding("Text", dtgvNSX.DataSource, "WebsiteNSX", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region event
        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenLSP.Text == "")
                {
                    MessageBox.Show("Không được để trống tên loại sản phẩm");
                }
                else
                {
                    bool them = LoaiSanPham_DAO.Instance.ThemLoaiSanPham(txtTenLSP.Text.ToString(), txtGhiChu.Text.ToString());
                    if (them)
                    {
                        MessageBox.Show("Thêm loại sản phẩm thành công");
                    } else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaLSP();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuyLSP_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            txtMaLSP.Text = "";
            txtTenLSP.Text = "";
        }

        private void btnCapNhatLSP_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtTenLSP.Text == "")
                    {
                        MessageBox.Show("Không được để trống tên loại sản phẩm");
                        return;
                    }
                    if (txtMaLSP.Text == "")
                    {
                        MessageBox.Show("phải chọn 1 loại sản phẩm để cập nhật");
                        return;
                    }
                    else
                    {
                        bool sua = LoaiSanPham_DAO.Instance.SuaLoaiSanPham(Convert.ToInt16(txtMaLSP.Text), txtTenLSP.Text.ToString(), txtGhiChu.Text.ToString());
                        if (sua)
                        {
                            MessageBox.Show("Cập nhật loại sản phẩm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    LayTatCaLSP();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (txtMaLSP.Text == "")
                    {
                        MessageBox.Show("Chọn 1 loại sản phẩm để xóa");
                    }
                    else
                    {
                        bool xoa = LoaiSanPham_DAO.Instance.XoaLoaiSanPham(Convert.ToInt16(txtMaLSP.Text));
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    LayTatCaLSP();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnTimKiemLSP_Click(object sender, EventArgs e)
        {
            List<LoaiSanPham_DTO> SP = LoaiSanPham_DAO.Instance.TimKiemLSP(txtTimKiemLSP.Text.ToString());
            if(SP.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào.");
            } else
            {
                this.DanhSachLSP.DataSource = SP;
            }
             
        }

        private void txtTimKiemLSP_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemLSP.Text == "")
            {
                LayTatCaLSP();
            }
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen_NSX.Text == "")
                {
                    MessageBox.Show("Không được để trống tên nhà sản xuất");
                }
                else
                {
                    bool them = NhaSanXuat_DAO.Instance.ThemNSX(txtTen_NSX.Text.ToString(), txtDiaChi.Text.ToString(),txtSDT.Text.ToString(),txtWebsite.Text.ToString());
                    if (them)
                    {
                        MessageBox.Show("Thêm nhà sản xuất thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaNSX();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuyNSX_Click(object sender, EventArgs e)
        {
            txtTen_NSX.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtWebsite.Text = "";
            txtMa_NSX.Text = "";
        }

        private void btnXoaNSX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    if (txtMa_NSX.Text == "")
                    {
                        MessageBox.Show("Chọn 1 nhà sản xuất để xóa");
                    }
                    else
                    {
                        bool xoa = NhaSanXuat_DAO.Instance.XoaNSX(Convert.ToInt16(txtMa_NSX.Text));
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    LayTatCaNSX();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void btnSuaNSX_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtTen_NSX.Text == "")
                    {
                        MessageBox.Show("Không được để trống tên nhà sản xuất");
                        return;
                    }
                    if (txtMa_NSX.Text == "")
                    {
                        MessageBox.Show("phải chọn 1 nhà sản suất để cập nhật");
                        return;
                    }
                    else
                    {
                        bool sua = NhaSanXuat_DAO.Instance.SuaNSX(Convert.ToInt16(txtMa_NSX.Text), txtTen_NSX.Text.ToString(), txtDiaChi.Text.ToString(), txtSDT.Text.ToString(), txtWebsite.Text.ToString());
                        if (sua)
                        {
                            MessageBox.Show("Cập nhật nhà sản xuất thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    LayTatCaNSX();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnTimKiemNSX_Click(object sender, EventArgs e)
        {
            List<NhaSanXuat_DTO> NSX = NhaSanXuat_DAO.Instance.TimKiemNSX(txtTimKiemNSX.Text.ToString());
            if (NSX.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy nhà sản xuất nào.");
            }
            else
            {
                this.DanhSachNSX.DataSource = NSX;
            }
        }

        private void txtTimKiemNSX_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemNSX.Text == "")
            {
                LayTatCaNSX();
            }
        }
        #endregion

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSanPham.Text == "")
                {
                    MessageBox.Show("Không được để trống tên sản phẩm");
                }
                else
                {
                    bool them = SanPham_DAO.Instance.ThemSanPham(txtTenSanPham.Text.ToString(), Convert.ToInt32(cbTenNhaSanXuat.SelectedValue),txtThongSoKyThuat.Text.ToString(), Convert.ToInt32(cbLoaiSanPham.SelectedValue), Convert.ToDecimal(txtDonGia.Text), Convert.ToInt32(nrudSoLuong.Value));
                    if (them)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaSP();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = "";
            txtMaSanPham.Text = "";
            txtThongSoKyThuat.Text = "";
            txtDonGia.Text = "";
            //cbTenNhaSanXuat.SelectedText = "Chưa có tên nhà sản xuất";
            //cbTenNhaSanXuat.SelectedValue = "";
            //cbLoaiSanPham.SelectedText = "Chưa có loại sản phẩm";
            //cbLoaiSanPham.SelectedValue = "";
            loadcbLSP(cbLoaiSanPham);
            loadcbNSX(cbTenNhaSanXuat);
            nrudSoLuong.Value = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtTenSanPham.Text == "")
                    {
                        MessageBox.Show("Không được để trống tên sản phẩm");
                        return;
                    }
                    if (txtMaSanPham.Text == "")
                    {
                        MessageBox.Show("phải chọn 1 sản phẩm để cập nhật");
                        return;
                    }
                    else
                    {
                        bool sua = SanPham_DAO.Instance.SuaSanPham(Convert.ToInt16(txtMaSanPham.Text), txtTenSanPham.Text.ToString(), Convert.ToInt32(cbTenNhaSanXuat.SelectedValue), txtThongSoKyThuat.Text.ToString(), Convert.ToInt32(cbLoaiSanPham.SelectedValue), Convert.ToDecimal(txtDonGia.Text), Convert.ToInt32(nrudSoLuong.Value));
                        if (sua)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    LayTatCaSP();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    if (txtMaSanPham.Text == "")
                    {
                        MessageBox.Show("Chọn 1 sản phẩm để xóa");
                    }
                    else
                    {
                        bool xoa = SanPham_DAO.Instance.XoaSanPham(Convert.ToInt32(txtMaSanPham.Text));
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    LayTatCaSP();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SanPham_DTO> SP = SanPham_DAO.Instance.TimKiemSP(txtTimKiem.Text.ToString());
            if (SP.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào.");
            }
            else
            {
                this.DanhSachSP.DataSource = SP;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                LayTatCaSP();
            }
        }

        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
