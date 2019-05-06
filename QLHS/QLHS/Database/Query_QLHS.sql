insert into HocSinh(MaLop, TenHocSinh,GioiTinh, NgaySinh,DiaChi,SDT,TonGiao,DanToc,TenCha,TenMe) values(1,N'Nguyễn văn B',N'Nam','19980530',N'Hà Nội','0968958647',N'Không',N'Kinh',N'Nguyễn văn H',N'Nguyễn Thị D')
select * from HocSinh
update HocSinh set MaLop = 1, TenHocSinh = N'1',GioiTinh = N'Nam',NgaySinh = '19980530', SDT = '', TonGiao = N'Không',DanToc = N'',TenCha = N'',TenMe = N'' where MaHocSinh = 12
delete from HocSinh where MaHocSinh = 14
select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where TenHocSinh like N'%Bui%'
select Lop.*,TenKhoi from Lop join Khoi on Khoi.MaKhoi = Lop.MaKhoi
select GiaoVien.*,TenMonHoc from GiaoVien join MonHoc on GiaoVien.MaMonHoc = MonHoc.MaMonHoc where TenGiaoVien like N'%%' or TenMonHoc like N'%%'
select * from GiaoVien
select * from MonHoc
insert into GiaoVien(MaMonHoc,TenGiaoVien,SDT,Email) values(1,N'','','')
update GiaoVien set MaMonHoc = 1, TenGiaoVien = N'',SDT = '',Email = '' where MaGiaoVien = 1

--trigger xóa giáo viên
create trigger XoaGV on GiaoVien instead of delete
as
declare @maGV int
begin
	select @maGV = MaGiaoVien from deleted
	delete from GVCN where MaGaioVien = @maGV
	delete from GiaoVien where MaGiaoVien = @maGV
end
delete from GiaoVien where MaGiaoVien = 1