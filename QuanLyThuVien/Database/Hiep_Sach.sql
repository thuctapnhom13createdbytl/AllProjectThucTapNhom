use QLTV
go

-- tạo proc lấy tất cả thông tin đầu sách
alter proc LayTatCaDauSach
as
begin
	select DauSach.*, TenNXB, TheLoai.TenTheLoai from 
	DauSach left join NhaXuatBan on DauSach.MaNXB = NhaXuatBan.MaNXB left join TheLoai on TheLoai.MaTheLoai = DauSach.MaTheLoai
end

go
----tạo proc update đầu sách


--tạo trigger xóa đầu sách
create trigger XoaDauSach on DauSach instead of delete
as
declare @maDS char(10)
begin
	select @maDS = MaDauSach from deleted
	delete from VietSach where MaDauSach = @maDS
	update CuonSach set MaDauSach = null where MaDauSach = @maDS
	delete from DauSach where MaDauSach = @maDS
end  
go
-- tạo proc tìm kiếm đầu sách
create proc TimKiemDauSach(@param nvarchar(255))
as
begin
	select DauSach.*, TenNXB, TheLoai.TenTheLoai from 
	DauSach left join NhaXuatBan on DauSach.MaNXB = NhaXuatBan.MaNXB left join TheLoai on TheLoai.MaTheLoai = DauSach.MaTheLoai
	where TenDauSach like N'%'+@param+'%'
end
go