--LoadToanBoPhieuXuat

create proc LayPhieuNhap
as
begin
select PhieuNhap.*,NhaSanXuat.Ten_NSX,NhanVien.Ten_NV from PhieuNhap,NhaSanXuat,NhanVien
where PhieuNhap.Ma_NSX = NhaSanXuat.Ma_NSX and PhieuNhap.Ma_NV = NhanVien.Ma_NV
end

LayPhieuNhap

create proc LayCTPhieuNhapTheoMa(@MaPN int)
as
begin
	select CT_PhieuNhap.*,TenSanPham
	from CT_PhieuNhap,SanPham
	where CT_PhieuNhap.Ma_PN = @MaPN and CT_PhieuNhap.Ma_Sanpham = SanPham.Ma_Sanpham
end

LayCTPhieuNhapTheoMa 1061


insert into PhieuNhap(Ma_NV,Ma_NSX,Ngaynhap) values()
select * from PhieuNhap
select max(Ma_PN) as Ma_PN from PhieuNhap

insert into CT_PhieuNhap(Ma_PN,Ma_Sanpham,SoLuong,DonGia) values ()
select * from SanPham where SanPham.Ma_NSX = 1
select * from SanPham where SanPham.Ma_NSX = 15

create proc SPTheoNSX(@MaNSX int)
as begin
select Ma_Sanpham,SanPham.Ma_LoaiSP,TenSanPham, SanPham.Ma_NSX, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX 
from SanPham,NhaSanXuat,LoaiSanPham 
where SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP and SanPham.Ma_NSX = NhaSanXuat.Ma_NSX and SanPham.Ma_NSX = @MaNSX
end
update SanPham set SoLuong = SanPham.SoLuong+1 where SanPham.Ma_Sanpham = 1

create proc LayPhieuXuat
as
begin
	select PhieuXuat.*, Ten_KH,Ten_NV from PhieuXuat, KhachHang,NhanVien
	where PhieuXuat.Ma_KH = KhachHang.Ma_KH and PhieuXuat.Ma_NV = NhanVien.Ma_NV 
end

create proc LayCTPhieuXuat(@MaPX int)
as
begin
select CT_PhieuXuat.*,TenSanPham from CT_PhieuXuat,SanPham
where CT_PhieuXuat.Ma_Sanpham = SanPham.Ma_Sanpham and CT_PhieuXuat.Ma_PX = @MaPX 
end

LayCTPhieuXuat 1
select * from CT_PhieuXuat
select * from PhieuXuat
insert into PhieuXuat(Ma_NV,Ma_KH,Ngayxuat)
select max(Ma_PX) as Ma_PX from PhieuXuat 
insert into CT_PhieuXuat(Ma_PX,Ma_Sanpham,Soluong,Dongia) 
select * from SanPham
select * from PhieuNhap
select * from CT_PhieuNhap
alter proc XuatHoaDonNhap(@MaPN int)
as
begin
	select PhieuNhap.Ma_NV,PhieuNhap.Ma_NSX,Ngaynhap,CT_PhieuNhap.*,TenSanPham,Ten_NV,Ten_NSX,(CT_PhieuNhap.SoLuong*CT_PhieuNhap.DonGia) as TongTien 
	from PhieuNhap, CT_PhieuNhap,NhaSanXuat,NhanVien,SanPham
	where PhieuNhap.Ma_PN = CT_PhieuNhap.Ma_PN
	and PhieuNhap.Ma_NSX = NhaSanXuat.Ma_NSX
	and PhieuNhap.Ma_NV = NhanVien.Ma_NV
	and CT_PhieuNhap.Ma_Sanpham = SanPham.Ma_Sanpham
	and PhieuNhap.Ma_PN = @MaPN
end

XuatHoaDonNhap 1018
select * from PhieuXuat
select * from CT_PhieuXuat
create proc LayHoaDonXuat(@MaPX int)
as
begin
	select CT_PhieuXuat.*,PhieuXuat.Ma_NV,PhieuXuat.Ma_KH,PhieuXuat.Ngayxuat,Ten_KH,Ten_NV,TenSanPham, (CT_PhieuXuat.Soluong * CT_PhieuXuat.Dongia) as TongTien
	 from PhieuXuat,CT_PhieuXuat,NhanVien,KhachHang,SanPham
	 where PhieuXuat.Ma_PX = CT_PhieuXuat.Ma_PX
	 and PhieuXuat.Ma_KH = KhachHang.Ma_KH
	 and PhieuXuat.Ma_NV = NhanVien.Ma_NV
	 and PhieuXuat.Ma_PX = @MaPX
	 and CT_PhieuXuat.Ma_Sanpham = SanPham.Ma_Sanpham
end

LayHoaDonXuat 1011

-- TRUNCATE TABLE CT_PhieuXuat

-- TRUNCATE TABLE CT_PhieuNhap

--delete from PhieuXuat

--delete from PhieuNhap

