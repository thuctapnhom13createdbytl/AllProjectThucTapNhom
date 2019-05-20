USE QuanLiThuVien
GO

CREATE PROC [dbo].[prc_Delete_PhieuMuon]
@SoPhieuMuon CHAR(10)
AS 
	DELETE dbo.ThongTinMuonTra WHERE SoPhieuMuon = @SoPhieuMuon
	DELETE dbo.PhieuMuon WHERE SoPhieuMuon = @SoPhieuMuon
GO


CREATE PROC [dbo].[prc_Update_PhieuMuon]
@NgayMuon Date,
@NgayHenTra date,
@MaNhanVien CHAR(10),
@MaDocGia char(10),
@SoPhieuMuon CHAR(10)
AS 
	UPDATE dbo.PhieuMuon SET NgayMuon = @NgayMuon, NgayHenTra = @NgayHenTra, MaNhanVien = @MaNhanVien, MaDocGia = @MaDocGia
	WHERE SoPhieuMuon = @SoPhieuMuon
GO

CREATE PROC [dbo].[prc_Insert_PhieuMuon]
@NgayMuon Date,
@NgayHenTra date,
@MaNhanVien CHAR(10),
@MaDocGia char(10),
@SoPhieuMuon CHAR(10)
AS 
	INSERT dbo.PhieuMuon
	        ( SoPhieuMuon ,
	          NgayMuon ,
	          NgayHenTra ,
	          MaNhanVien ,
	          MaDocGia
	        )
	VALUES  ( @SoPhieuMuon , -- SoPhieuMuon - char(10)
	          @NgayMuon , -- NgayMuon - date
	          @NgayHenTra , -- NgayHenTra - date
	          @MaNhanVien , -- MaNhanVien - char(10)
	          @MaDocGia  -- MaDocGia - char(10)
	        )
GO

CREATE PROC [dbo].[prc_Select_ThongTinMuonTra]
AS 
	SELECT tt.*, ds.TenDauSach FROM ThongTinMuonTra tt INNER JOIN CuonSach cs ON tt.MaCuonSach = cs.MaCuonSach
	INNER JOIN DauSach ds ON cs.MaDauSach = ds.MaDauSach
GO	

