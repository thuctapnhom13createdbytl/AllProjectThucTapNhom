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
    public partial class fDiem : Form
    {
        BindingSource DSDiem = new BindingSource();
        public fDiem()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            LayTatCaDiem();
            dtgDiem.DataSource = DSDiem;
            bindingDiem();
            cbLoadTenMonHoc(cbTenMonHoc);
            cbLoadHocKi(cbTenHocKy);
        }

        void LayTatCaDiem()
        {
            DSDiem.DataSource = Diem_DAO.Instance.TimKiemDiemHS("");
        }


        void bindingDiem()
        {
            txtMaDiem.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "MaDiemMon", true, DataSourceUpdateMode.Never));
            txtTenHocSinh.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "TenHocSinh", true, DataSourceUpdateMode.Never));
            cbTenMonHoc.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "TenMonhoc", true, DataSourceUpdateMode.Never));
            txtDiemGK.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "DiemGiuaKy", true, DataSourceUpdateMode.Never));
            txtDiem15.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "Diem15", true, DataSourceUpdateMode.Never));
            txtDiemThi.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "DiemThi", true, DataSourceUpdateMode.Never));
            txtDiemTB.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "TrungBinh", true, DataSourceUpdateMode.Never));
            cbTenHocKy.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "TenHocKy", true, DataSourceUpdateMode.Never));
            txtMaHocSinh.DataBindings.Add(new Binding("Text", dtgDiem.DataSource, "MaHocSinh", true, DataSourceUpdateMode.Never));
        }

        void cbLoadTenMonHoc(ComboBox cb)
        {
            cb.DataSource = MonHoc_DAO.Instance.LayTatCaMonHoc_Diem();
            cb.DisplayMember = "TenMonHoc";
            cb.ValueMember = "MaMonHoc";
        }

        void cbLoadHocKi(ComboBox cb)
        {
            cb.DataSource = HocKi_DAO.Instance.LoadTatCaHocKi_Diem();
            cb.DisplayMember = "TenHocKy";
            cb.ValueMember = "MaHocKy";
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
         
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Có Chắc Bạn Muốn Cập Nhật", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (txtTenHocSinh.Text == "")
                    {
                        MessageBox.Show("Không để trống tên học sinh");
                    }
                    else
                    {
                        bool sua = Diem_DAO.Instance.SuaDiem(Convert.ToInt16(txtMaDiem.Text), Convert.ToDouble(txtDiemTB.Text), Convert.ToDouble(txtDiem15.Text), Convert.ToDouble(txtDiemGK.Text), Convert.ToDouble(txtDiemThi.Text));
                        if (sua)
                        {
                            MessageBox.Show("Cập nhật thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    LayTatCaDiem();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    if(txtMaDiem.Text == "")
                    {
                        MessageBox.Show("Chọn môn học");
                    }
                    else
                    {
                        bool xoa = Diem_DAO.Instance.XoaDiem(Convert.ToInt16(txtMaDiem.Text));
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    LayTatCaDiem();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

