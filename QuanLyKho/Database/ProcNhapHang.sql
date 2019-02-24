USE QuanLyKho
GO	

CREATE PROC LoadToanBoPhieuNhap
AS
	SELECT ct.Ma_CTPN, ct.Ma_PN, ct.Ma_Sanpham, sp.TenSanPham, lsp.Ma_LoaiSP, lsp.TenLoai,
	ct.SoLuong, ct.DonGia, nsx.Ma_NSX, nsx.Ten_NSX, nv.Ma_NV, nv.Ten_NV
	FROM dbo.PhieuNhap pn INNER JOIN dbo.NhanVien nv ON nv.Ma_NV = pn.Ma_NV
	INNER JOIN dbo.NhaSanXuat nsx ON nsx.Ma_NSX = pn.Ma_NSX
	INNER JOIN dbo.CT_PhieuNhap ct ON ct.Ma_PN = pn.Ma_PN
	INNER JOIN dbo.SanPham sp ON ct.Ma_Sanpham = sp.Ma_Sanpham
	INNER JOIN dbo.LoaiSanPham lsp ON lsp.Ma_LoaiSP = sp.Ma_LoaiSP
GO

CREATE PROC LoadToanBoNhaSanXuat
AS 
	SELECT *
	FROM dbo.NhaSanXuat
GO

CREATE PROC LoadToanBoNhanVien
AS 
	
	SELECT nv.Ma_NV, nv.Ten_NV + ' - ' + nv.SDT_NV AS ThongTin, nv.Ten_NV, nv.Ngaysinh_NV, nv.GioiTinh, nv.SDT_NV, nv.Email_NV
	FROM dbo.NhanVien nv
GO

CREATE PROC LoadToanBoLoaiSanPham
AS 
	SELECT *
	FROM dbo.LoaiSanPham
GO

CREATE PROC ThemSanPhamMoi
@TenSanPham NVARCHAR(MAX),
@Ma_NSX INT,
@Ma_LoaiSP INT,
@Gia INT,
@SoLuong INT
AS
	INSERT dbo.SanPham
	        ( TenSanPham ,
	          Ma_NSX ,
	          Ma_LoaiSP ,
	          Gia ,
	          SoLuong
	        )
	VALUES  ( @TenSanPham , -- TenSanPham - nvarchar(max)
	          @Ma_NSX , -- Ma_NSX - int
	          @Ma_LoaiSP , -- Ma_LoaiSP - int
	          @Gia , -- Gia - int
	          @SoLuong -- SoLuong - int
	        )
GO

CREATE PROC ThemPhieuNhapMoi
@Ma_NV INT,
@Ma_NSX INT
AS 
	INSERT dbo.PhieuNhap
	        ( Ma_NV, Ma_NSX, Ngaynhap )
	VALUES  ( @Ma_NV, -- Ma_NV - int
	          @Ma_NSX, -- Ma_NSX - int
	          GETDATE()  -- Ngaynhap - datetime
	          )
GO

CREATE PROC ThemChiTietPhieuNhap
@Ma_PN INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT
AS
	INSERT dbo.CT_PhieuNhap
	        ( Ma_PN, Ma_Sanpham, SoLuong, DonGia )
	VALUES  ( @Ma_PN, -- Ma_PN - int
	          @Ma_Sanpham, -- Ma_Sanpham - int
	          @SoLuong, -- SoLuong - int
	          @DonGia  -- DonGia - int
	          )
GO
     
CREATE PROC ThemPhieuNhap_SPMoi
@TenSanPham NVARCHAR(MAX),
@Ma_NSX INT,
@Ma_LoaiSP INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_Sanpham INT, @Ma_PN INT
	EXEC ThemSanPhamMoi @TenSanPham, @Ma_NSX, @Ma_LoaiSP, @DonGia, @SoLuong
	SELECT @Ma_Sanpham = @@IDENTITY

	EXEC dbo.ThemPhieuNhapMoi @Ma_NV, @Ma_NSX
	SELECT @Ma_PN = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuNhap @Ma_PN, @Ma_Sanpham, @SoLuong, @DonGia
GO

EXEC dbo.ThemPhieuNhap_SPMoi @TenSanPham = N'Laptop', -- nvarchar(max)
    @Ma_NSX = 3, -- int
    @Ma_LoaiSP = 4, -- int
    @SoLuong = 10, -- int
    @DonGia = 15000000, -- int
    @Ma_NV = 1 -- int
GO
 
CREATE PROC ThemPhieuNhap_SPCu
@Ma_NSX INT,
@Ma_Sanpham INT,
@SoLuong INT,
@DonGia INT,
@Ma_NV INT
AS
	DECLARE @Ma_PN INT
	UPDATE dbo.SanPham 
	SET SoLuong = SoLuong + @SoLuong, Gia = @DonGia
	WHERE Ma_Sanpham = @Ma_Sanpham

	EXEC dbo.ThemPhieuNhapMoi @Ma_NV, @Ma_NSX
	SELECT @Ma_PN = @@IDENTITY

	EXEC dbo.ThemChiTietPhieuNhap @Ma_PN, @Ma_Sanpham, @SoLuong, @DonGia
GO