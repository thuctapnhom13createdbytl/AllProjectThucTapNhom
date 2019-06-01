using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.VIEW
{
    public partial class fSach : Form
    {
        BindingSource DanhSachDauSach = new BindingSource();
        public fSach()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dtgvDauSach.DataSource = DanhSachDauSach;
            LayTatCaTheLoai();
            LayTatCaNXB();
            LayTatCaTG();
            LayTatCaDauSach();
            LayComboboxTheLoai(cbMaTheLoai);
            LayComboboxNXB(cbMaNXB);
            BindingDauSach();
        }
        void LayTatCaTheLoai()
        {
            dtgvTheLoai.DataSource = TheLoai_DAO.Instance.LayTatCaTheLoai();
        }

        void LayTatCaNXB()
        {
            dtgvNXB.DataSource = NhaXuatBan_DAO.Instance.LayTatCaNXB();
        }
        void LayTatCaTG()
        {
            dtgvTG.DataSource = TacGia_DAO.Instance.LayTatCaTacGia();
        }
        void LayTatCaDauSach()
        {
            DanhSachDauSach.DataSource = DauSach_DAO.Instance.LayTatCaDauSach();
        }
        void LayComboboxTheLoai(ComboBox cb)
        {
            cb.DataSource = TheLoai_DAO.Instance.LayTatCaTheLoai();
            cb.DisplayMember = "TenTheLoai";
            cb.ValueMember = "MaTheLoai";
        }
        void LayComboboxNXB(ComboBox cb)
        {
            cb.DataSource = NhaXuatBan_DAO.Instance.LayTatCaNXB();
            cb.DisplayMember = "TenNXB";
            cb.ValueMember = "MaNXB";
        }
        void BindingDauSach()
        {
            txt_MaDauSach.DataBindings.Add(new Binding("Text", dtgvDauSach.DataSource, "MaDauSach", true, DataSourceUpdateMode.Never));
            cbMaNXB.DataBindings.Add(new Binding("Text", dtgvDauSach.DataSource, "TenNXB", true, DataSourceUpdateMode.Never));
            cbMaTheLoai.DataBindings.Add(new Binding("Text", dtgvDauSach.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
            txt_TenDauSach.DataBindings.Add(new Binding("Text", dtgvDauSach.DataSource, "TenDauSach", true, DataSourceUpdateMode.Never));
        }
        private void btnTimKiemTheLoai_Click(object sender, EventArgs e)
        {
            List<TheLoai_DTO> TheLoai = TheLoai_DAO.Instance.TimKiemTheLoai(txtTimKiemTheLoai.Text);
            if(TheLoai.Count <= 0)
            {
                MessageBox.Show("Không thấy thể loại nào");
                dtgvTheLoai.Rows.Clear();
            } else
            {
                dtgvTheLoai.DataSource = TheLoai;
            }
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            List<NhaXuatBan_DTO> NXB = NhaXuatBan_DAO.Instance.TimKiemNXB(txtTimKiemNXB.Text);
            if (NXB.Count <= 0)
            {
                MessageBox.Show("Không thấy nhà xuất bản nào");
                dtgvNXB.Rows.Clear();
            }
            else
            {
                dtgvNXB.DataSource = NXB;
            }
        }

        private void btnTimKiemTG_Click(object sender, EventArgs e)
        {
            List<TacGia_DTO> TG = TacGia_DAO.Instance.TimKiemTG(txtTimKiemTG.Text);
            if (TG.Count <= 0)
            {
                MessageBox.Show("Không thấy tác giả nào");
                dtgvTG.Rows.Clear();
            }
            else
            {
                dtgvTG.DataSource = TG;
            }
        }

        private void btnTimKiemDauSach_Click(object sender, EventArgs e)
        {
            List<DauSach_DTO> DS = DauSach_DAO.Instance.TimKiemDauSach(txtTimKiemDauSach.Text);
            if(DS.Count <= 0)
            {
                MessageBox.Show("không tìn thấy đầu sách nào");
            }
            else
            {
                this.DanhSachDauSach.DataSource = DS;
            }
        }

        private void btnHuyDauSach_Click(object sender, EventArgs e)
        {
            txt_MaDauSach.Text = "";
            txt_TenDauSach.Text = "";
            LayComboboxTheLoai(cbMaTheLoai);
            LayComboboxNXB(cbMaNXB);
        }

        private void btnThemDauSach_Click(object sender, EventArgs e)
        {
            bool check = false;

                if(txt_MaDauSach.Text == "" || txt_TenDauSach.Text == "")
                {
                    MessageBox.Show("không được để trống bất cứ trường nào");
                } else
                {
                    for(int i = 0;i< dtgvDauSach.Rows.Count; i++)
                    {
                        if (txt_MaDauSach.Text.ToString().Equals(Convert.ToString(dtgvDauSach.Rows[i].Cells[0].Value))){
                            MessageBox.Show("Mã đầu sách đã tồn tại");
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        bool them = DauSach_DAO.Instance.ThemDauSach(txt_MaDauSach.Text.ToString(), txt_TenDauSach.Text, cbMaTheLoai.SelectedValue.ToString(), cbMaNXB.SelectedValue.ToString());
                        if (them)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                    LayTatCaDauSach();
                }
            
        }

        private void btnCapNhatDauSach_Click(object sender, EventArgs e)
        {

            if (txt_MaDauSach.Text == "" || txt_TenDauSach.Text == "")
            {
                MessageBox.Show("không được để trống bất cứ trường nào");
            }
            else
            {
                bool CapNhap = DauSach_DAO.Instance.CapNhatDauSach(txt_MaDauSach.Text.ToString(), txt_TenDauSach.Text, cbMaTheLoai.SelectedValue.ToString(), cbMaNXB.SelectedValue.ToString());
                if (CapNhap)
                {
                    MessageBox.Show("cập nhật thành công");
                    LayTatCaDauSach();
                }
            }
        }

        private void btnXoaDauSach_Click(object sender, EventArgs e)
        {
            if (txt_MaDauSach.Text == "")
            {
                MessageBox.Show("phải chọn ít nhất 1 đầu sách để xóa");
            } else
            {
                bool Xoa = DauSach_DAO.Instance.XoaDauSach(txt_MaDauSach.Text);
                if (Xoa)
                {
                    MessageBox.Show("xóa đầu sách thành công");
                    LayTatCaDauSach();
                }
            }
        }
    }
}
