USE QLTV

--Tạo pro lấy tất cả đọc giả
CREATE PROCEDURE LayTatCaDocGia
AS
BEGIN
SELECT *FROM dbo.DocGia
END

LayTatCaDocGia

--Tạo Pro thêm đọc giả
CREATE PROC [dbo].[ThemDocGia](@MaDocGia CHAR(10),@TenDocGia NVARCHAR(50),@DiaChi NVARCHAR(50),@SDT CHAR(10))
AS
BEGIN
	INSERT INTO NhanVien VALUES(@MaDocGia,@tenDocGia,@DiaChi,@SDT)
END

ThemDocGia '1',N'Bùi Văn Thành',N'Hà Nội','09128312'


--Tạo trigger xóa Đọc Giả
CREATE trigger xoaDocGia on DocGia instead of delete
 as declare @madocgia CHAR(10)
 begin
 select @madocgia = MaDocGia from deleted
 update dbo.TheThuVien set MaDocGia = null where dbo.TheThuVien.MaDocGia = @madocgia
 UPDATE dbo.PhieuMuon SET MaDocGia = NULL WHERE dbo.PhieuMuon.MaDocGia = @madocgia
 delete from dbo.DocGia where MaDocGia = @madocgia
 END

-----------------
 SELECT MaDocGia, TenDocGia, diaChi, SDT
 FROM dbo.DocGia
 WHERE TenDocGia LIKE N'Thành'

 -----------------------------Thẻ thư viện
 --Pro lấy tất cả thẻ thư viện
 CREATE PROCEDURE LayTatCaTheThuVien
AS
BEGIN
SELECT *FROM dbo.TheThuVien
END

LayTatCaTheThuVien


