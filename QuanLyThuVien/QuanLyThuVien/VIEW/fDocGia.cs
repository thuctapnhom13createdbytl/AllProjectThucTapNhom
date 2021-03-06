﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DTO;
using QuanLyThuVien.DAO;

namespace QuanLyThuVien.VIEW
{
    public partial class fDocGia : Form
    {
        BindingSource DanhSachDG = new BindingSource();
        BindingSource DanhSachTTV = new BindingSource();
        public fDocGia()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgDocGia.DataSource = DanhSachDG;
            dtgTheThuVien.DataSource = DanhSachTTV;
            LayTatCaDG();
            LayTatCaTTV();
            bingdingDocGia();
            bingdingTheThuVien();
            loadcbTenDocGia(cbTenDocGia);
        }

        void LayTatCaDG()
        {
            DanhSachDG.DataSource = DocGia_DAO.Instance.LoadToanBoDocGia();
     
        }
        void LayTatCaTTV()
        {
            DanhSachTTV.DataSource = TheThuVien_DAO.Instance.LoadToanBoTheThuVien();
        }

        void bingdingDocGia()
        {
            tbMaDG.DataBindings.Add(new Binding("Text", dtgDocGia.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
            tbTenDG.DataBindings.Add(new Binding("Text", dtgDocGia.DataSource, "TenDocGia", true, DataSourceUpdateMode.Never));
            tbDiaChiDG.DataBindings.Add(new Binding("Text", dtgDocGia.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            tbSDTDG.DataBindings.Add(new Binding("Text", dtgDocGia.DataSource, "SDT", true, DataSourceUpdateMode.Never));
        }

        void bingdingTheThuVien()
        {
            tbSoThe.DataBindings.Add(new Binding("Text", dtgTheThuVien.DataSource, "SoThe", true, DataSourceUpdateMode.Never));
            dtpNgayBatDau.DataBindings.Add(new Binding("Text", dtgTheThuVien.DataSource, "NgayBatDau", true, DataSourceUpdateMode.Never));
            dtpNgayKetThuc.DataBindings.Add(new Binding("Text", dtgTheThuVien.DataSource, "NgayKetThuc", true, DataSourceUpdateMode.Never));
            cbTenDocGia.DataBindings.Add(new Binding("Text", dtgTheThuVien.DataSource, "MaDocGia", true, DataSourceUpdateMode.Never));
        }


        void loadcbTenDocGia(ComboBox cb)
        {
            cb.DataSource = DocGia_DAO.Instance.LoadToanBoDocGia();
            cb.DisplayMember = "TenDocGia";
            cb.ValueMember = "MaDocGia";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTenDG.Text == "")
                {
                    MessageBox.Show("Điền thông tin đọc giả");
                }
                else
                {
                    bool them = DocGia_DAO.Instance.ThemDocGia(tbMaDG.Text, tbTenDG.Text, tbDiaChiDG.Text, tbSDTDG.Text);
                    if(them)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaDG();
               
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
                if (tbTenDG.Text == "")
                {
                    MessageBox.Show("Điền thông tin đọc giả");
                }
                else
                {
                    bool sua = DocGia_DAO.Instance.CapNhatDocGia(tbMaDG.Text.ToString(), tbTenDG.Text.ToString(), tbDiaChiDG.Text.ToString(), tbSDTDG.Text.ToString());
                    if (sua)
                    {
                        MessageBox.Show("Cập nhật đọc giả thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                LayTatCaDG();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaDG.Text == "")
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                bool xoa = DocGia_DAO.Instance.XoaDocGia(tbMaDG.Text);
                if (xoa)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            LayTatCaDG();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            List<DocGia_DTO> DSDG = DocGia_DAO.Instance.TimKiemDG(tbTimKiem.Text.ToString());
            if (DSDG.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy đọc giả.");
            }
            else
            {
                this.DanhSachDG.DataSource = DSDG;
            }
        }

        private void button1_Click(object sender, EventArgs e) //btn Tìm kiếm the thu vien
        {
            List<TheThuVien_DTO> TTV = TheThuVien_DAO.Instance.TimKiemTTV(tbTimKiemTTV.Text);
            if (tbTimKiemTTV.Text == "")
            {
                LayTatCaTTV();
            }
            else if (TTV.Count <= 0 )
            {
                MessageBox.Show("Không tìm thấy.");
                LayTatCaTTV();
            }
            else
            {
                this.DanhSachTTV.DataSource = TTV;
            }
        }

        private void btnThemTTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSoThe.Text == "")
                {
                    MessageBox.Show("Điền số thẻ thư viện");
                }
                else
                {
                    bool them = TheThuVien_DAO.Instance.ThemTheThuVien(tbSoThe.Text, dtpNgayBatDau.Value, dtpNgayKetThuc.Value, Convert.ToString(cbTenDocGia.SelectedValue));
                    if (them)
                    {
                        MessageBox.Show("Thêm thẻ thư viện thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                LayTatCaTTV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhatTheTTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSoThe.Text == "")
                {
                    MessageBox.Show("Điền số thẻ thư viện");
                }
                else
                {
                    bool sua = TheThuVien_DAO.Instance.CapNhatTheThuVien(tbSoThe.Text.ToString(),dtpNgayBatDau.Value, dtpNgayKetThuc.Value, cbTenDocGia.Text.ToString());
                    if (sua)
                    {
                        MessageBox.Show("Cập nhật thẻ thư viện thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                LayTatCaTTV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTTV_Click(object sender, EventArgs e)
        {
            if (tbSoThe.Text == "")
            {
                MessageBox.Show("Chọn thẻ thư viện để xóa");
            }
            else
            {
                bool xoa = TheThuVien_DAO.Instance.XoaTheThuVien(tbSoThe.Text);


                if (xoa)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            LayTatCaTTV();
        }

        private void tbTimKiemTTV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
