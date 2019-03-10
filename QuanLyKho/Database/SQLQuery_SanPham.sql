
select * from NhaSanXuat
insert into NhaSanXuat 
values (N'Nhà sản xuất 2',N'Hà Nam','2222222','22222@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 3',N'Hồ Chí Minh','33333333','333333@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 4',N'Tân Lập - Đan Phượng - Hà Nội','4444444','4444@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 5',N'Tân Hội - Đan Phượng - Hà Nội','555555','55555@gmail.com')
insert into NhaSanXuat values (N'Nhà sản xuất 6',N'Đà Nẵng','66666666','666666@gmail.com')

select * from LoaiSanPham

insert into LoaiSanPham values(N'Loại 2',N'Ghi chú của loại 2')
insert into LoaiSanPham values(N'Loại 3',N'Ghi chú của loại 3')
insert into LoaiSanPham values(N'Loại 4',N'Ghi chú của loại 4')
insert into LoaiSanPham values(N'Loại 5',N'Ghi chú của loại 5')
insert into LoaiSanPham values(N'Loại 6',N'Ghi chú của loại 6')
insert into LoaiSanPham values(N'Loại 7',N'Ghi chú của loại 7')
insert into LoaiSanPham values(N'Loại 8',N'Ghi chú của loại 8')
select * from SanPham
insert into SanPham values(N'Sản phẩm 2',2,N'thông số kỹ thuật 2',2,2,2)
insert into SanPham values(N'Sản phẩm 3',3,N'thông số kỹ thuật 3',3,3,3)
insert into SanPham values(N'Sản phẩm 4',4,N'thông số kỹ thuật 4',4,4,4)
insert into SanPham values(N'Sản phẩm 5',5,N'thông số kỹ thuật 5',5,5,5)
insert into SanPham values(N'Sản phẩm 6',6,N'thông số kỹ thuật 6',6,6,6)
-- tạo proc lấy tất cả sản phẩm---------------------------------------------------
create proc LayTatCaSanPham
as begin
select Ma_Sanpham,TenSanPham, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX,SanPham.Ma_NSX,SanPham.Ma_LoaiSP
from SanPham left join NhaSanXuat on SanPham.Ma_NSX = NhaSanXuat.Ma_NSX left join  LoaiSanPham on SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP
end
------------------------------------------------------------------------------------
LayTatCaSanPham

----------------tạo proc thêm sản phẩm---------------------------------------------------
create proc ThemSanPham(@Ten nvarchar(50), @maNSX int,@thongso nvarchar(255), @maLoai int,@gia int, @soluong int )
as begin 
insert into SanPham values(@Ten,@maNSX,@thongso,@maLoai,@gia,@soluong)
end
-----------------------------------------------------------------------------------------
ThemSanPham N'Sản phẩm 7',6,N'thông số kỹ thuật 6',6,6,6
select * from LoaiSanPham
select * from NhaSanXuat



update LoaiSanPham set TenLoai = N'Loai 1', GhiChu = N'Ghi chú mới sửa của loại 1' where Ma_LoaiSP = 1
SELECT * FROM LoaiSanPham
--------------------tạo trigger xóa loại sản phẩm ---------------------------------------------------
 USE QuanLyKho
 CREATE trigger xoaLSP on LoaiSanPham instead of delete
 as declare @maLSP int
 begin
 select @maLSP = Ma_LoaiSP from deleted
 update SanPham set Ma_LoaiSP = null where SanPham.Ma_LoaiSP = @maLSP
 delete from LoaiSanPham where Ma_LoaiSP = @maLSP
 end
 -----------------------------------------------------------------------------------------------------
 select * from LoaiSanPham
 select * from SanPham
 delete from LoaiSanPham where Ma_LoaiSP = 6
 LayTatCaSanPham
 select Ma_Sanpham,TenSanPham, Thongso_Kt,Gia,SoLuong, TenLoai 
from SanPham left join  LoaiSanPham on SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP
delete from SanPham where Ma_LoaiSP 
select * from LoaiSanPham where TenLoai like N'%1%'
update NhaSanXuat set Ten_NSX = N'1',DiaChi_NSX = N'1',SDT_NSX = '11',Website_NSX = '1@gmail.com' where Ma_NSX = 1

---- tạo trigger xóa nhà sản xuất-----------------------------
 CREATE trigger xoaNSX on NhaSanXuat instead of delete
 as declare @maNSX int
 begin
 select @maNSX = Ma_NSX from deleted
 update SanPham set Ma_NSX = null where SanPham.Ma_LoaiSP = @maNSX
 delete from NhaSanXuat where Ma_NSX = @maNSX
 END
 
  CREATE trigger xoaNhanVien on NhanVien instead of delete
 as declare @maNV int
 begin
 select @maNV = Ma_NV from deleted
 update dbo.PhieuNhap set Ma_NV = null where dbo.PhieuNhap.Ma_NV = @maNV
 UPDATE dbo.PhieuXuat SET Ma_NV = NULL WHERE dbo.PhieuXuat.Ma_NV = @maNV
 delete from dbo.NhanVien where Ma_NV = @maNV
 end

 ----------------------------------------------------------------------
 delete from NhaSanXuat where Ma_NSX =1
 select * from NhaSanXuat
 select * from SanPham
 select * from LoaiSanPham

 USE QuanLyKho
LoadToanBoNhanVien
update NhanVien set Ten_NV = N'abv', GioiTinh = N'Nam', Ngaysinh_NV = '1998-02-02', SDT_NV ='123123', Email_NV='1313' where Ma_NV = 2

CREATE PROC ThemNhanVien (@tenNV nvarchar(50), @gioitinh nvarchar(10), @ngaysinh date, @sdtNV varchar(50), @emailNV varchar(255))
as begin 
INSERT INTO dbo.NhanVien VALUES(@tenNV, @gioitinh, @ngaysinh, @sdtNV, @emailNV)
END
