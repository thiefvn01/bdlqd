create view getChamTap_all
as
select c.id, h.MaHV as N'Mã học viên', HoTenLot + ' ' + Ten as N'Họ và tên', c.ngay as N'Ngày', 
c.ktra as N'Kiểm tra', t.Lop as N'Lớp'
from chamTap c inner join hocVien h on c.idHocvien=h.ID inner join ChiTietTKB t on t.ID=c.lopID


----
 create procedure getChamTap_hocVien_TuDenNgay
	@idhocvien int,
	@lopgoc	int,
	@tungay	smalldatetime,
	@denngay smalldatetime
 as
 select distinct ngay as N'Ngày', ktra as N'Kiểm tra'
 from chamTap c inner join lop l on c.lopID=l.idLop
 where c.idHocvien=@idhocvien and lopgoc=@lopgoc and ngay<=@denngay and ngay>=@tungay


----
create procedure getChamTap4
	@idhocvien int,
	@lop int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
select b.* from 
(select top 8 a.* from
(select top 16  * from chamtap where idhocvien=@idhocvien and lopid=@lop and ngay>=@tungay and ngay<=@denngay  order by 1 ) a
order by 1 desc) b
order by 1


---
select * from 
select top (8) a.* from(
select top (16)  * from chamtap where 1=1) a
