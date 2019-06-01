create PROC LoadTatCaPhongBan
AS
BEGIN
	SELECT dbo.PHONGBAN.MaPB,TenPB,MaTP,NgayNhanChuc, HoTen AS TenTP
	FROM dbo.PHONGBAN, dbo.NHANVIEN
	WHERE MaTP = MaNV
END

create  PROC LoadComboBoxTenTruongPhong
AS
BEGIN
	SELECT MaNV,HoTen 
	FROM dbo.NHANVIEN
END

create PROC XoaPhongBanTheoMa
@maPB INT
AS
BEGIN
	UPDATE dbo.DUAN SET MaPB = NULL WHERE MaPB = @maPB
    DELETE dbo.PHONGBAN
	WHERE MaPB = @maPB
END

LoadTatCaPhongBan