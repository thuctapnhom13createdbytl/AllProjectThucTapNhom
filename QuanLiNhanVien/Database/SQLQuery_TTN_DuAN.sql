USE TTN_QLNV
GO

--Load tat ca du an
CREATE PROC LoadAllDuAn
AS
BEGIN
		select d.MaDA,d.TenDA,d.DiaDiem,d.MaPB 
		from DUAN D inner join PHONGBAN p ON D.MaPB=p.MaPB
END

--Xoa du an theo ma
go
create proc XoaDuAnTheoMa(@MaDA int )
as
begin 
		delete from DUAN where MaDA=@MaDA
		update PHANCONG set MaDA =null where MaDA=@MaDA
end

--
go
CREATE PROCEDURE LoadComboBoxDuAn
AS
	SELECT MaDA, TenDA
	FROM dbo.DUAN
GO	