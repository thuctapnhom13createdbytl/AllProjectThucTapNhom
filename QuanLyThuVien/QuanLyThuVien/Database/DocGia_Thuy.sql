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
	INSERT INTO DocGia VALUES(@MaDocGia,@tenDocGia,@DiaChi,@SDT)
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
SELECT SoThe, NgayBatDau, NgayKetThuc,dbo.DocGia.TenDocGia
FROM dbo.TheThuVien LEFT JOIN dbo.DocGia ON DocGia.MaDocGia = TheThuVien.MaDocGia
END

LayTatCaTheThuVien

CREATE PROC ThemTheThuVien(@sothe CHAR(10),@ngaybatdau date,@ngayketthuc date,@madocgia CHAR(10))
AS
BEGIN
	INSERT INTO TheThuVien VALUES(@sothe,@ngaybatdau,@ngayketthuc,@madocgia)
END



CREATE trigger xoaTheThuVien on TheThuVien instead of delete
 as declare @sothe CHAR(10)
 begin
 select @sothe = SoThe from deleted
 delete from dbo.TheThuVien where SoThe = @sothe
 END
 SELECT * FROM dbo.TheThuVien
insert into TheThuVien values('1123         ','12/12/2019','5/20/2019','1 123        ')

select * from TheThuVien where SoThe like '10'

update TheThuVien set NgayBatDau ='12/12/2019', NgayKetThuc = '5/20/2019', MaDocGia = (select DocGia.MaDocGia from DocGia where DocGia.TenDocGia like N'Bùi Đình Thủy') where SoThe = '10'
update TheThuVien set ngaybatdau ='12/12/2019', ngayketthuc = '5/20/2019', MaDocGia = (select DocGia.MaDocGia from DocGia where DocGia.TenDocGia like N'Nguyễn Văn A') where sothe = '10'
select * from TheThuVien
select * from DocGia

select * from TheThuVien where soThe like '11'


create proc TimKiemTheThuVien(@sothe char(10) )
as
begin
SELECT SoThe, NgayBatDau, NgayKetThuc,dbo.DocGia.TenDocGia
FROM dbo.TheThuVien LEFT JOIN dbo.DocGia ON DocGia.MaDocGia = TheThuVien.MaDocGia where  SoThe like @sothe;
end

TimKiemTheThuVien'12'