
select * from NhaSanXuat
insert into NhaSanXuat 
values (N'Nhà sản xuất 2',N'Hà Nam','2222222','22222@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 3',N'Hồ Chí Minh','33333333','333333@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 4',N'Tân Lập - Đan Phượng - Hà Nội','4444444','4444@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 5',N'Tân Hội - Đan Phượng - Hà Nội','555555','55555@gmail.com')
insert into NhaSanXuat 
values (N'Nhà sản xuất 6',N'Đà Nẵng','66666666','666666@gmail.com')

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

create proc LayTatCaSanPham
as begin
select Ma_Sanpham,TenSanPham, Thongso_Kt,Gia,SoLuong, TenLoai, Ten_NSX 
from SanPham,NhaSanXuat,LoaiSanPham 
where SanPham.Ma_LoaiSP = LoaiSanPham.Ma_LoaiSP and SanPham.Ma_NSX = NhaSanXuat.Ma_NSX
end
LayTatCaSanPham
create proc ThemSanPham(@Ten nvarchar())
as begin 
end

create proc ThemSanPham(@Ten nvarchar(50), @maNSX int,@thongso nvarchar(255), @maLoai int,@gia int, @soluong int )
as begin 
insert into SanPham values(@Ten,@maNSX,@thongso,@maLoai,@gia,@soluong)
end
ThemSanPham N'Sản phẩm 7',6,N'thông số kỹ thuật 6',6,6,6
