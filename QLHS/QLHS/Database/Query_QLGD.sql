alter PROC LoadDiemHocSinh @tenhs nvarchar(100)
AS
BEGIN
SELECT dbo.DiemMon.MaDiemMon, dbo.MonHoc.TenMonHoc, dbo.DiemMon.TrungBinh, dbo.HocSinh.TenHocSinh, dbo.HocKi.TenHocKy, Diem15, DiemGiuaKy, DiemThi
FROM dbo.Lop, dbo.HocSinh, dbo.DiemMon, dbo.HocKi, dbo.MonHoc
WHERE dbo.DiemMon.MaMonHoc =  dbo.MonHoc.MaMonHoc AND dbo.DiemMon.MaHocKy = dbo.HocKi.MaHocKy AND dbo.DiemMon.MaHocSinh = dbo.HocSinh.MaHocSinh AND dbo.HocSinh.MaLop = dbo.Lop.MaLop
END
EXEC dbo.LoadDiemHocSinh

alter PROC TimKiemHocSinh @diemhs nvarchar(100)
AS
begin
SELECT dbo.DiemMon.MaDiemMon, dbo.MonHoc.MaMonHoc, dbo.DiemMon.TrungBinh, dbo.HocSinh.MaHocSinh, dbo.HocKi.MaHocKy, Diem15, DiemGiuaKy, DiemThi,dbo.MonHoc.TenMonHoc, dbo.HocKi.TenHocKy, dbo.HocSinh.TenHocSinh
FROM dbo.Lop, dbo.HocSinh, dbo.DiemMon, dbo.HocKi, dbo.MonHoc
WHERE dbo.DiemMon.MaMonHoc =  dbo.MonHoc.MaMonHoc AND dbo.DiemMon.MaHocKy = dbo.HocKi.MaHocKy AND dbo.DiemMon.MaHocSinh = dbo.HocSinh.MaHocSinh AND dbo.HocSinh.MaLop = dbo.Lop.MaLop AND dbo.HocSinh.TenHocSinh LIKE @diemhs
END

EXEC TimKiemHocSinh N'%%'

SELECT DISTINCT dbo.MonHoc.MaMonHoc, dbo.MonHoc.TenMonHoc FROM dbo.MonHoc LEFT JOIN dbo.DiemMon ON DiemMon.MaMonHoc = MonHoc.MaMonHoc
SELECT DISTINCT dbo.HocKi.MaHocKy,dbo.HocKi.TenHocKy FROM dbo.HocKi LEFT JOIN dbo.DiemMon ON DiemMon.MaHocKy = HocKi.MaHocKy


CREATE TRIGGER XoaDiem2 ON DiemMon INSTEAD of DELETE
AS DECLARE @madiemmon INT
BEGIN 
		SELECT @madiemmon = MaDiemMon FROM deleted
		DELETE FROM dbo.DiemMon WHERE MaDiemMon = @madiemmon
END

DELETE FROM dbo.DiemMon WHERE MaDiemMon = 1
UPDATE dbo.DiemMon SET MaDiemMon = , MaMonHoc = , MaHocKy, TrungBinh, MaHocSinh, Diem15, DiemGiuaKy, DiemThi