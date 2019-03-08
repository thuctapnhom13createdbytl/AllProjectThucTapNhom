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
	(
	    Ten_NV,
	    GioiTinh,
	    Ngaysinh_NV,
	    SDT_NV,
	    Email_NV
	)
	VALUES
	(   N'Trần Thị Tuyết',       -- Ten_NV - nvarchar(max)
	    N'Nữ',       -- GioiTinh - nvarchar(10)
	    '1999-11-19', -- Ngaysinh_NV - date
	    '038912312',        -- SDT_NV - varchar(50)
	    'tuyet@gmail.com'         -- Email_NV - varchar(255)
	   )
SELECT * FROM dbo.NhanVien

USE QuanLyKho
GO
dbo.LoadToanBoNhanVien