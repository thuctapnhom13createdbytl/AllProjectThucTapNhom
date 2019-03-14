--Thêm dữ liệu bảng nhân viên
INSERT INTO dbo.NhanVien
(
    Ten_NV,
    GioiTinh,
    Ngaysinh_NV,
    SDT_NV,
    Email_NV
)
VALUES
(   N'Bùi Đình Thủy',       -- Ten_NV - nvarchar(max)
    N'Nam',       -- GioiTinh - nvarchar(10)
    GETDATE(), -- Ngaysinh_NV - date
    '0986123123',        -- SDT_NV - varchar(50)
    'buidinhthuy@gmail.com'         -- Email_NV - varchar(255)
    )
insert into dbo.NhanVien
(
    Ten_NV,
    GioiTinh,
    Ngaysinh_NV,
    SDT_NV,
    Email_NV
)
VALUES
(   N'Trần Hồng Quân',       -- Ten_NV - nvarchar(max)
    N'Nam',       -- GioiTinh - nvarchar(10)
    '1998-07-07', -- Ngaysinh_NV - date
    '0987124123',        -- SDT_NV - varchar(50)
    'hongquan@gmail.com'         -- Email_NV - varchar(255)
    )
INSERT INTO dbo.NhanVien
(
    Ten_NV,
    GioiTinh,
    Ngaysinh_NV,
    SDT_NV,
    Email_NV
)
VALUES
(   N'Nguyễn Văn Tý',       -- Ten_NV - nvarchar(max)
    N'Nam',       -- GioiTinh - nvarchar(10)
    '1997-02-02', -- Ngaysinh_NV - date
    '098765412',        -- SDT_NV - varchar(50)
    'ty@gmail.com'         -- Email_NV - varchar(255)
    )
INSERT INTO dbo.NhanVien
	( Ten_NV, GioiTinh, Ngaysinh_NV, SDT_NV, Email_NV)
VALUES
	(   N'Trần Thị Tuyết',       -- Ten_NV - nvarchar(max)
	    N'Nữ',       -- GioiTinh - nvarchar(10)
	    '1999-11-19', -- Ngaysinh_NV - date
	    '038912312',        -- SDT_NV - varchar(50)
	    'tuyet@gmail.com'         -- Email_NV - varchar(255)
	   )

 -- tạo trigger xóa nhân viên---------------------------
  CREATE trigger xoaNhanVien on NhanVien instead of delete
 as declare @maNV int
 begin
 select @maNV = Ma_NV from deleted
 update dbo.PhieuNhap set Ma_NV = null where dbo.PhieuNhap.Ma_NV = @maNV
 UPDATE dbo.PhieuXuat SET Ma_NV = NULL WHERE dbo.PhieuXuat.Ma_NV = @maNV
 delete from dbo.NhanVien where Ma_NV = @maNV
 end

 --tạo proc load toàn bộ nhân viên----------------
 CREATE PROC LoadToanBoNhanVien
AS 
	
	SELECT nv.Ma_NV, nv.Ten_NV + ' - ' + nv.SDT_NV AS ThongTin, nv.Ten_NV, nv.Ngaysinh_NV, nv.GioiTinh, nv.SDT_NV, nv.Email_NV
	FROM dbo.NhanVien nv
GO

-------tạo proc thêm mới nhân viên -------------
ALTER PROC [dbo].[ThemNhanVien] (@tenNV nvarchar(50), @gioitinh nvarchar(10), @ngaysinh date, @sdtNV varchar(50), @emailNV varchar(255))
as begin 
INSERT INTO dbo.NhanVien VALUES(@tenNV, @gioitinh, @ngaysinh, @sdtNV, @emailNV)
END
