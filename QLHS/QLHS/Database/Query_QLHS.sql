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

select Lop.*,TenKhoi,TenGiaoVien,MaGiaoVien 
from Lop left join Khoi on Khoi.MaKhoi = Lop.MaKhoi 
left join GVCN on Lop.MaLop = GVCN.MaLop 
left join GiaoVien on GiaoVien.MaGiaoVien = GVCN.MaGaioVien

select GiaoVien.* from GiaoVien join GVCN on GiaoVien.MaGiaoVien = GVCN.MaGaioVien join Lop on Lop.MaLop = GVCN.MaLop
update GVCN set MaGaioVien = 2 where MaLop = 2
select * from GVCN
select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where HocSinh.MaLop = 2
select DiemMon.*,TenMonHoc, TenHocKy  from DiemMon join MonHoc on DiemMon.MaMonHoc = MonHoc.MaMonHoc join HocKi on HocKi.MaHocKy = DiemMon.MaHocKy where MaHocSinh = 3
select * from DiemMon
select DiemMon.*,TenMonHoc, TenHocKy  from DiemMon join MonHoc on DiemMon.MaMonHoc = MonHoc.MaMonHoc join HocKi on HocKi.MaHocKy = DiemMon.MaHocKy where MaHocSinh = 4
insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi) values (2,2,3,8,9,8)



-- tạo trigger thêm điểm môn học
alter trigger ThemDiem on DiemMon instead of insert
as
declare @DiemTB float,@MaMonHoc int,@MaHocKy int,@MaHocSinh int,@Diem15 float,@DiemGiuaKy float,@DiemThi float
begin
	select @DiemTB = ROUND((Diem15+2*DiemGiuaKy+3*DiemThi)/6,1) from inserted
	select @MaMonHoc = MaMonHoc,@MaHocKy = MaHocKy,@MaHocSinh = MaHocSinh,@Diem15 = Diem15,@DiemGiuaKy = DiemGiuaKy,@DiemThi = DiemThi from inserted
	insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi,TrungBinh) values (@MaMonHoc,@MaHocKy,@MaHocSinh,@Diem15,@DiemGiuaKy,@DiemThi,@DiemTB)
end

insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi) values (@MaMonHoc,@MaHocKy,@MaHocSinh,@Diem15,@DiemGiuaKy,@DiemThi)
update DiemMon set TrungBinh = ROUND((Diem15+2*DiemGiuaKy+3*DiemThi)/6,1)


select hocsinh.*,TenLop from hocsinh join lop on HocSinh.MaLop = Lop.MaLop where TenHocSinh like N'%hồng%' and HocSinh.MaLop = 3
select * from HocKi
select * from MonHoc
insert into DiemMon(MaMonHoc,MaHocKy,MaHocSinh,Diem15,DiemGiuaKy,DiemThi) values (4,2,4,6,5,6)
select * from DiemMon where MaHocKy = 2
update DiemMon set MaMonHoc = 1, MaHocKy = 1, MaHocSinh = 1, Diem15 = 1,DiemGiuaKy = 1,DiemThi = 1,TrungBinh = 1 where MaDiemMon = 1