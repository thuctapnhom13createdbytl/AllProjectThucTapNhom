using System;
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
    public partial class frmThemChiTietPhieuMuon : Form
    {
        public frmThemChiTietPhieuMuon()
        {
            InitializeComponent();
        }
        private List<CuonSach_DTO> lstCuonSach;
        private List<CuonSach_DTO> lstCuonSachTrongPhieuMuon;

        private void frmThemChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadCuonSach();
            LoadCuonSachTrongPhieuMuon();
            txtSoPhieuMuon.Text = fThongTinSach.SoPhieuMuon;
            SetCheckedListBox();
        }

        private void SetCheckedListBox()
        {
            if (lstCuonSachTrongPhieuMuon != null)
            {
                for (int i = 0; i < chklstCuonSach.Items.Count; i++)
                {
                    CuonSach_DTO cs = chklstCuonSach.Items[i] as CuonSach_DTO;
                    foreach(CuonSach_DTO obj in lstCuonSachTrongPhieuMuon)
                    {
                        if (cs.MaCuonSach == obj.MaCuonSach)
                        {
                            chklstCuonSach.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void LoadCuonSachTrongPhieuMuon()
        {
            lstCuonSachTrongPhieuMuon = CuonSach_DAO.Instance.LoadCuonSachCuaPhieuMuon(txtSoPhieuMuon.Text);

        }

        private void LoadCuonSach()
        {
            lstCuonSach = CuonSach_DAO.Instance.LoadTatCaCuonSachCheckBoxList();
            chklstCuonSach.DataSource = lstCuonSach;
            chklstCuonSach.DisplayMember = "TenHienThi";
            chklstCuonSach.ValueMember = "MaCuonSach";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<ThongTinMuonTra_DTO> lstThongTin = new List<ThongTinMuonTra_DTO>();
            for(int i = 0; i < chklstCuonSach.CheckedItems.Count; i++)
            {
                ThongTinMuonTra_DTO tt = new ThongTinMuonTra_DTO();
                CuonSach_DTO cs = chklstCuonSach.CheckedItems[i] as CuonSach_DTO;
                tt.MaCuonSach = cs.MaCuonSach;
                tt.SoPhieuMuon = txtSoPhieuMuon.Text;
                lstThongTin.Add(tt);
            }
            int kq = ThongTinMuonTra_DAO.Instance.ThemChiTietPhieuMuon(lstThongTin);
            if (kq > 0)
            {
                MessageBox.Show("Đã thêm chi tiết phiếu mượn");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm chi tiết phiếu mượn thất bại");
            }
        }
    }
}
