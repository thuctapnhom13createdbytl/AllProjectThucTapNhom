USE TTN_QLNV
GO

CREATE PROCEDURE LoadTatCaPhanCongDuAn
AS 
	SELECT pc.MaNV, nv.HoTen, pc.MaDA, da.TenDA, pc.SoGio
	FROM dbo.PHANCONG pc
	INNER JOIN dbo.NHANVIEN nv ON nv.MaNV = pc.MaNV
	INNER JOIN dbo.DUAN da ON da.MaDA = pc.MaDA
GO


CREATE PROCEDURE LoadTatCaDuAn
AS 
	SELECT *
	FROM dbo.DUAN
GO

CREATE PROCEDURE XoaPhanCongDuAn
@MaNV INT, @MaDA INT
AS 
	DELETE dbo.PHANCONG 
	WHERE MaDA = @MaDA AND MaNV = @MaNV
GO

CREATE PROCEDURE LoadComboBoxDuAn
AS
	SELECT MaDA, TenDA
	FROM dbo.DUAN
GO	 

CREATE PROC ThemPhanCong
@MaNV INT, @MaDA INT, @SoGio INT
AS 
	INSERT dbo.PHANCONG
	        ( MaDA, MaNV, SoGio )
	VALUES  ( @MaDA, -- MaDA - int
	          @MaNV, -- MaNV - int
	          @SoGio  -- SoGio - int
	          )
GO

CREATE PROC CapNhatPhanCong
@MaNV INT, @MaDA INT, @SoGio INT
AS 
	UPDATE dbo.PHANCONG SET SoGio = @SoGio WHERE MaNV = @MaNV AND MaDA = @MaDA
GO