create proc TN_loadAll
as 
begin
select THANNHAN.*, HoTen from THANNHAN left join NHANVIEN on NHANVIEN.MaNV = THANNHAN.MaNV
end