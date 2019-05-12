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
    public partial class fThongTinLopHoc : Form
    {
        BindingSource DanhSachDiem = new BindingSource();
        int IDLopHoc;
        int tempMaDiem = 0;
        public fThongTinLopHoc(int idLopHoc,string TenLop)
        {
            InitializeComponent();
            
            this.IDLopHoc = idLopHoc;
            this.lbTenLop.Text = TenLop;
            load();
        }
        void load()
        {
            LayDanhSachHS();
            dtgvDiem.DataSource = DanhSachDiem;
            loadCBHocKi(cbHK);
            loadCBMonHoc(cbMonHoc);
        }
        void LayDanhSachHS()
        {
            dtgvHS.DataSource = HocSinh_DAO.Instance.LayHocSinhTheoLop(this.IDLopHoc);
        }
        void loadCBHocKi(ComboBox cb)
        {
            cb.DataSource = HocKi_DAO.Instance.LayTatCahocKy();
            cb.DisplayMember = "TenHocKy";
            cb.ValueMember = "MaHocKy";
        }
        void loadCBMonHoc(ComboBox cb)
        {
            cb.DataSource = MonHoc_DAO.Instance.LayTatCaMonHoc();
            cb.DisplayMember = "TenMonHoc";
            cb.ValueMember = "MaMonHoc";
        }
        private void dtgvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvHS.Rows[index];
                int maHS = Convert.ToInt32(dr.Cells["MaHocSinh"].Value);
                DanhSachDiem.DataSource = Diem_DAO.Instance.LayDiemTheoHS(maHS,Convert.ToInt16(cbHK.SelectedValue));

            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvHS.DataSource = HocSinh_DAO.Instance.TimKiemHSTheoLop(txtTimKiem.Text, IDLopHoc);
        }

        private void cbHK_SelectedValueChanged(object sender, EventArgs e)
        {
            if(dtgvHS.SelectedCells.Count > 0)
            {
                int index = dtgvHS.SelectedCells[0].RowIndex;
                DataGridViewRow dr = dtgvHS.Rows[index];
                int maHS = Convert.ToInt32(dr.Cells["MaHocSinh"].Value);
                DanhSachDiem.DataSource = Diem_DAO.Instance.LayDiemTheoHS(maHS, Convert.ToInt16(cbHK.SelectedValue));
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tempMaDiem != 0) {
                    MessageBox.Show("Điểm môn đã tồn tại, nếu muốn sửa vui lòng chọn Cập nhật");
                    return;
                }
                if (dtgvHS.SelectedCells.Count > 0)
                {
                    int index = dtgvHS.SelectedCells[0].RowIndex;
                    DataGridViewRow dr = dtgvHS.Rows[index];
                    int maHS = Convert.ToInt32(dr.Cells["MaHocSinh"].Value);
                    double diem15 = txtDiem15.Text != "" ? Convert.ToDouble(txtDiem15.Text) : 0;
                    double diemGiuaKi = txtDiemGiuaKi.Text != "" ? Convert.ToDouble(txtDiemGiuaKi.Text) : 0;
                    double diemCuoiKi = txtDiemCuoiKi.Text != "" ? Convert.ToDouble(txtDiemCuoiKi.Text) : 0;
                    if(diem15 <0 || diem15 >10 || diemGiuaKi <0|| diemGiuaKi>10|| diemCuoiKi <0 || diemCuoiKi > 10)
                    {
                        MessageBox.Show("điểm phải lớn hơn 0 và nhỏ hơn 10", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int them = Diem_DAO.Instance.ThemDiem(Convert.ToInt32(cbMonHoc.SelectedValue),Convert.ToInt32(cbHK.SelectedValue), maHS,diem15, diemGiuaKi, diemCuoiKi);
                    if(them != -1)
                    {
                        MessageBox.Show("thêm thành công");
                        DanhSachDiem.DataSource = Diem_DAO.Instance.LayDiemTheoHS(maHS, Convert.ToInt32(cbHK.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("thêm thành thất bại");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dr = dtgvDiem.Rows[index];
                cbMonHoc.Text = dr.Cells["TenMonHoc"].Value.ToString();
                txtDiem15.Text = dr.Cells["Diem15"].Value.ToString();
                txtDiemGiuaKi.Text = dr.Cells["DiemGiuaKy"].Value.ToString();
                txtDiemCuoiKi.Text = dr.Cells["DiemThi"].Value.ToString();
                txtDiemTB.Text = dr.Cells["TrungBinh"].Value.ToString();
                this.tempMaDiem = Convert.ToInt32(dr.Cells["MaDiemMon"].Value);
            }
            catch
            {
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.tempMaDiem = 0;
            txtDiem15.Text = "";
            txtDiemGiuaKi.Text = "";
            txtDiemCuoiKi.Text = "";
            txtDiemTB.Text = "";
            loadCBMonHoc(cbMonHoc);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var xacnhan = MessageBox.Show("bạn có chắc chắn muốn xóa điểm của môn: " + cbMonHoc.Text,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(xacnhan == DialogResult.Yes)
                {
                    int xoa = Diem_DAO.Instance.XoaDiem(tempMaDiem);
                    if(xoa > 0)
                    {
                        MessageBox.Show("xóa thành công!");
                        if (dtgvHS.SelectedCells.Count > 0)
                        {
                            int index = dtgvHS.SelectedCells[0].RowIndex;
                            DataGridViewRow dr = dtgvHS.Rows[index];
                            int maHS = Convert.ToInt32(dr.Cells["MaHocSinh"].Value);
                            DanhSachDiem.DataSource = Diem_DAO.Instance.LayDiemTheoHS(maHS, Convert.ToInt32(cbHK.SelectedValue));
                        }
                    }
                    else
                    {
                        MessageBox.Show("xóa thất bại!");
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("xóa thất bại!");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(tempMaDiem == 0)
                {
                    MessageBox.Show("Điểm môn học chưa tồn tại, nếu muốn thêm điểm vui lòng chọn Thêm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtgvHS.SelectedCells.Count > 0)
                {
                    int index = dtgvHS.SelectedCells[0].RowIndex;
                    DataGridViewRow dr = dtgvHS.Rows[index];
                    int maHS = Convert.ToInt32(dr.Cells["MaHocSinh"].Value);
                    double diem15 = txtDiem15.Text != "" ? Convert.ToDouble(txtDiem15.Text) : 0;
                    double diemGiuaKi = txtDiemGiuaKi.Text != "" ? Convert.ToDouble(txtDiemGiuaKi.Text) : 0;
                    double diemCuoiKi = txtDiemCuoiKi.Text != "" ? Convert.ToDouble(txtDiemCuoiKi.Text) : 0;
                    if (diem15 < 0 || diem15 > 10 || diemGiuaKi < 0 || diemGiuaKi > 10 || diemCuoiKi < 0 || diemCuoiKi > 10)
                    {
                        MessageBox.Show("điểm phải lớn hơn 0 và nhỏ hơn 10", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int them = Diem_DAO.Instance.CapNhatDiem(tempMaDiem,Convert.ToInt32(cbMonHoc.SelectedValue),Convert.ToInt32(cbHK.SelectedValue),maHS,diem15,diemGiuaKi,diemCuoiKi);
                    if (them != -1)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        DanhSachDiem.DataSource = Diem_DAO.Instance.LayDiemTheoHS(maHS, Convert.ToInt32(cbHK.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành thất bại");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thành thất bại");
                return;
            }
        }

        private void txtDiem15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiemGiuaKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiemCuoiKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiem15_TextChanged(object sender, EventArgs e)
        {
            double diem15 = txtDiem15.Text != "" ? Convert.ToDouble(txtDiem15.Text) : 0;
            double diemGiuaKi = txtDiemGiuaKi.Text != "" ? Convert.ToDouble(txtDiemGiuaKi.Text) : 0;
            double diemCuoiKi = txtDiemCuoiKi.Text != "" ? Convert.ToDouble(txtDiemCuoiKi.Text) : 0;
            txtDiemTB.Text = Math.Round((diem15 + diemGiuaKi * 2 + diemCuoiKi * 3) / 6, 1).ToString();
        }

        private void txtDiemGiuaKi_TextChanged(object sender, EventArgs e)
        {
            double diem15 = txtDiem15.Text != "" ? Convert.ToDouble(txtDiem15.Text) : 0;
            double diemGiuaKi = txtDiemGiuaKi.Text != "" ? Convert.ToDouble(txtDiemGiuaKi.Text) : 0;
            double diemCuoiKi = txtDiemCuoiKi.Text != "" ? Convert.ToDouble(txtDiemCuoiKi.Text) : 0;
            txtDiemTB.Text = Math.Round((diem15 + diemGiuaKi * 2 + diemCuoiKi * 3) / 6, 1).ToString();
        }

        private void txtDiemCuoiKi_TextChanged(object sender, EventArgs e)
        {
            double diem15 = txtDiem15.Text != "" ? Convert.ToDouble(txtDiem15.Text) : 0;
            double diemGiuaKi = txtDiemGiuaKi.Text != "" ? Convert.ToDouble(txtDiemGiuaKi.Text) : 0;
            double diemCuoiKi = txtDiemCuoiKi.Text != "" ? Convert.ToDouble(txtDiemCuoiKi.Text) : 0;
            txtDiemTB.Text = Math.Round((diem15 + diemGiuaKi * 2 + diemCuoiKi * 3) / 6, 1).ToString();
        }
    }
}
