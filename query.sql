﻿create view getChamTap_all
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
create procedure xoaChamtap
	@id int
as
delete chamTap where id=@id
----
create procedure getChamTap1
	@idhocvien int,
	@lopgoc int
as
SELECT        MIN(c.ID) AS minum, MAX(c.ID) AS maxmum
FROM            chamTap c inner join lop on c.lopid=lop.idlop
WHERE        (c.idHocVien =@idHocvien) and  lopgoc=@lopgoc
group by c.idhocvien, lopid
-----
create procedure getChamTap2
	@idhocvien int,
	@lopgoc int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
SELECT DISTINCT  c.ngay AS Ngày, c.ktra AS [Kiểm tra]
FROM            (chamTap c INNER JOIN
                         Lop ON c.lopID = Lop.idLop AND c.idHocVien = Lop.idHocVien)
WHERE        (c.idHocVien = @idHocvien) AND (Lop.lopGoc = @lopgoc)  and c.ngay>= @tungay and  c.ngay<=@denngay
ORDER BY c.ngay
----
exec getChamTap2 1,2,'1/1/2014', '2/2/2015'
----
create procedure getChamTap3
	@idhocvien int,
	@lopid int
as
SELECT        ngay AS Ngày, ktra AS [Kiểm tra], idhocvien as [id]
FROM            chamTap
WHERE        (idHocVien = @idhocvien) AND (lopID = @lopid)
------
create procedure getChamTap5
	@idhocvien int,
	@lopid int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
select * from 
(select top 8 b.* from
(select top 32  * from chamtap where idhocvien=@idhocvien and lopid=@lopid and ngay>=@tungay and ngay<=@denngay  order by 1 ) b
order by 1 desc) a
order by 1
----
create procedure getChamTap6
	@lopid int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
SELECT DISTINCT ngay AS Ngày
FROM            chamTap
WHERE        (lopID = @lopid) AND (ngay >= @tungay) AND (ngay <= @denngay)
----
create procedure getChamTap7
	@idhocvien int,
	@lopid int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
SELECT        c.ngay AS Ngày, c.ktra AS [Kiểm tra], c.idHocvien AS id, hocVien.hoTenCha + ' ' + hocVien.Ten AS [Họ Tên]
FROM            ((chamTap c INNER JOIN
                         Lop ON c.lopID = Lop.idLop AND c.idHocvien = Lop.idHocVien) INNER JOIN
                         hocVien ON hocVien.ID = c.idHocvien AND hocVien.ID = Lop.idHocVien)
WHERE        (c.idHocvien = @idhocvien) AND (Lop.lopgoc = @lopid) AND (c.ngay >= @tungay) AND (c.ngay <= @denngay)
----
create procedure getChamTap8
	@idhocvien int,
	@lopid int,
	@tungay smalldatetime,
	@denngay smalldatetime
as
select * from 
(select top 10 a.* from
(select top 20  * from chamtap where idhocvien=@idhocvien and lopid=@lopid and ngay>=@tungay and ngay<=@denngay  order by 1 ) a
order by 1 desc) b
order by 1
----
create procedure insertChamTap
	@idhocvien int,
	@ngay smalldatetime,
	@ktra nvarchar,
	@lopid int
as
INSERT INTO chamTap
                         (idHocVien, ngay, ktra, lopID)
VALUES        (@idhocvien,@ngay,@ktra,@lopid)
----
create procedure updateChamTap
	@ktra nvarchar,
	@id int
as
UPDATE       chamTap
SET                ktra = @ktra where id=@id

----
create procedure getKetQua1
	@kiemtraid int,
	@idlophoc int
as
SELECT        kiemTra.ID, de.CauLon + ' ' + de.Cau as Cau, iif(de.diemToiDa >0 ,  round((AVG(ketQuaHocTap.diem) / de.diemToiDa)*100,2) , 0 )  AS phantram, round(AVG(ketQuaHocTap.diem),2) as trungbinh, de.diemToiDa, de.Caulon
FROM            ketQuaHocTap INNER JOIN
                de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra
				on kiemtra.id=de.deID
WHERE        (kiemTra.ID = @kiemtraid) AND (ketQuaHocTap.idLopHoc = @idlophoc) 
GROUP BY de.Cau, ketQuaHocTap.idBaiTap, kiemTra.ID, de.ID, de.diemToiDa, de.caulon
----
create procedure getSoCau
	@deid int
as
SELECT        count(id) as dem
FROM          de
WHERE       deid=@deid
-----
create procedure getKetQua3
	@deid int,
	@idlophoc int	
as
 SELECT        top 20 de.id, kiemTra.ID, de.Cau, round((AVG(ketQuaHocTap.diem) / de.diemToiDa)*100,2) AS phantram, round(AVG(ketQuaHocTap.diem),2) as trungbinh, de.diemToiDa, de.caulon
           FROM            ketQuaHocTap INNER JOIN
                de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra
				on kiemtra.id=de.deID
WHERE        (de.deID = @deid) AND (ketQuaHocTap.idLopHoc = @idlophoc)  and (de.id not in (SELECT  top 40 de.id FROM            ketQuaHocTap INNER JOIN
                de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra
				on kiemtra.id=de.deID
WHERE        (de.deID = @deid) AND (ketQuaHocTap.idLopHoc = @idlophoc) GROUP BY de.Cau, ketQuaHocTap.idBaiTap, kiemTra.ID, de.ID, de.diemToiDa ))
GROUP BY de.Cau, ketQuaHocTap.idBaiTap, kiemTra.ID, de.ID, de.diemToiDa, de.caulon
order by de.id
----
create view getBaiTap
as
select * from baitap
----
create view getKetQua_all
as
select * from ketquahoctap
----
create procedure getKiemTra
as
SELECT        k.ID, k.maDe AS [Mã đề], c.Lop as N'Lớp', k.ngayLam AS [Ngày làm], k.heSo AS [Hệ số], k.dang
FROM            (kiemTra k INNER JOIN
                         ChiTietTKB c ON k.idLop = c.ID)
order by k.id desc
----
create procedure deleteKiemTra
	@id int
as
DELETE FROM kiemTra WHERE ID = @id
----
create procedure getKiemTra1
	@id int
as
SELECT        k.ID, k.maDe AS [Mã đề], c.Lop, k.ngayLam AS [Ngày làm], k.heSo AS [Hệ số], k.dang
FROM            (kiemTra k INNER JOIN
                         ChiTietTKB c ON k.idLop = c.ID)
where k.id=@id
order by k.id desc
----
create procedure getKiemTra2
	@tungay smalldatetime,
	@denngay smalldatetime,
	@idlop int
as
SELECT        maDe AS [Mã đề]
FROM            kiemTra
WHERE        (ngayLam >= @tungay) AND (ngayLam <= @denngay) AND (idLop = @idlop)
-----
create procedure getKiemTra3
	@idlop int
as
SELECT        k.ID, k.maDe AS [Mã đề], c.Lop as N'Lớp', k.ngayLam AS [Ngày làm], k.heSo AS [Hệ số], k.dang
FROM            (kiemTra k INNER JOIN
                         ChiTietTKB c ON k.idLop = c.ID)
WHERE        (k.idLop = @idlop)
ORDER BY k.ID DESC
----
create procedure insertKiemTra
	@made int,
	@idlop int,
	@ngaylam smalldatetime,
	@heso float,
	@dang nvarchar
as
INSERT INTO kiemTra (maDe, idLop, ngayLam, heSo, dang) VALUES (@made, @idlop, @ngaylam,@heso, @dang)
-----
create procedure updateKiemTra
	@made int,
	@heso float,
	@id int
as
UPDATE kiemTra SET maDe = made,  heSo = @heso WHERE ID = @id
----
create procedure getThongTinPhieuBao
	@idhocvien int,
	@idlop int
as
SELECT        ttphieubao.*
FROM            ttphieubao
where idhocvien=@idhocvien and idlop=@idlop and id=(select max(id) from ttphieubao where idhocvien=@idhocvien and idlop=@idlop)
----
create procedure insertPhieuBao
	@idhocvien int,
	@idlop int,
	@giaovien nvarchar,
	@nhanxet nvarchar
as
INSERT INTO ttphieubao (idhocvien, idlop, giaovien, nhanxet) VALUES (@idhocvien, @idlop, @giaovien, @nhanxet)
----
create procedure getChiTietTKB_All
as
SELECT ID, GiaoVien as N'Giáo viên', ghichu as N'Ghi chú', HocPhi as N'Học phí', STT, Monhoc as N'Môn học'
, lop as N'Lớp', Thu as N'Thứ', ThoiGian as N'Thời gian', SoTuan as N'Số tuần', idTKB FROM ChiTietTKB
----
create procedure getChiTietTKB1
	@idtkb int
as
SELECT        ID, STT, Lop as N'Lớp'
FROM            ChiTietTKB
WHERE        (idTKB = @idtkb)
ORDER BY STT
---
create procedure getKetQua4
	@idlophoc int,
	@idhocvien int
as
SELECT        ketQuaHocTap.id, hocVien.[Hotenlot] + '' + hocVien.Ten AS [Họ tên], c.Lop as N'Lớp', ketQuaHocTap.diem AS N'Điểm', de.cauLon + ' ' + de.Cau AS N'Câu', hocVien.Ten, de.diemtoida, 
                         k.maDe, k.ngayLam, de.deID * 10 AS IDde
FROM            ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (ketQuaHocTap.idLopHoc = @idlophoc) AND (ketQuaHocTap.idHocVien = @idhocvien)
ORDER BY de.ID
---
create procedure getKetQua5
	@idhocvien int,
	@lopgoc int
as
SELECT        SUM(ketQuaHocTap.diem) AS Điểm, kiemTra.ngayLam, kiemTra.heSo
FROM           ketquahoctap inner join de on de.id=ketquahoctap.idBaiTap inner join
				kiemTra on kiemTra.id=de.deID inner join Lop on ketQuaHocTap.idHocVien=lop.ID
WHERE        (ketQuaHocTap.idHocVien = @idhocvien) AND (lop.lopGoc = @lopgoc)
GROUP BY kiemTra.ngayLam, kiemTra.heSo
----
create view getTKB_all
as
SELECT ID, TenTKB as 'Tên TKB', Lop as N'Lớp', Namhoc as N'Năm học', Khaigiang as N'Khai Giảng', Ghichu as N'Ghi chú' FROM ThoiKhoaBieu
----
create view getNVHocVien
as
SELECT id, idHocVien, truong, ghiChu, Monchuyen as N'Môn chuyên' FROM nguyenVongHocVien
---
create view getNhanVien
as
SELECT ID, Hotenlot as N'Họ tên lot', Ten as N'Tên', Diachi as N'Địa chỉ', Sodienthoai as N'Số điện thoại', Email, userName, [passWord], Mucluong as N'Mức lương', GhiChu as N'Ghi chú', Vitri as N'Vị trí', Gioitinh as N'Giới tính' FROM nhanVien
---
create view getLop_all
as
SELECT ID, idHocVien, idLop, Ngaydoi as N'Ngày đổi', GhiChu as N'Ghi chú' FROM Lop
----
create procedure getLop1
	@idhocvien int,
	@idlop int
as
SELECT        lopGoc
FROM            Lop
WHERE        (idHocVien = @idhocvien) AND (idLop = @idlop) AND (lopHienTai = 1)
----
create procedure getLop2
@idhocvien int,
	@idlop int
as
SELECT        idLop
FROM            Lop
WHERE        (idHocVien = @idhocvien) AND (lopGoc = @idlop)
----
create procedure getLop3
@idhocvien int,
@thoikhoabieuid int
as
SELECT        ChiTietTKB.Lop
FROM            ((Lop INNER JOIN
                         ChiTietTKB ON ChiTietTKB.ID = Lop.idLop) INNER JOIN
                         ThoiKhoaBieu ON ThoiKhoaBieu.ID = ChiTietTKB.idTKB)
WHERE        (Lop.idHocVien = @idhocvien) AND (Lop.lopHienTai = 1) AND (ThoiKhoaBieu.ID = @thoikhoabieuid)
----
create procedure getLop4
	@thoikhoabieuid int
as
SELECT DISTINCT 
                         Lop.idHocVien, hocVien.Hotenlot + ' ' + hocVien.ten AS [Họ tên], hocVien.Truong as N'Trường', hocVien.Dienthoai as N'Điện thoại', hocVien.hoTenCha, hocVien.dienThoaiCha, hocVien.hoTenMe, 
                         hocVien.dienThoaiMe, hocVien.tenNguoiNuoiDuong, hocVien.dienThoaiNguoiNuoiDuong, Lop.sbl, Lop.[GhiChu] AS Expr1
FROM            (((Lop INNER JOIN
                         hocVien ON Lop.idHocVien = hocVien.ID) INNER JOIN
                         ChiTietTKB ON ChiTietTKB.ID = Lop.idLop) INNER JOIN
                         ThoiKhoaBieu ON ThoiKhoaBieu.ID = ChiTietTKB.idTKB)
WHERE        (Lop.lophientai = 1) AND (ThoiKhoaBieu.ID = @thoikhoabieuid)
----
create procedure getLop5
as
SELECT DISTINCT 
                         Lop.idHocVien, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', hocVien.Truong as N'Trường', hocVien.Dienthoai as N'Điện thoại', hocVien.hoTenCha, hocVien.dienThoaiCha, hocVien.hoTenMe, hocVien.dienThoaiMe, 
                         hocVien.tenNguoiNuoiDuong, hocVien.dienThoaiNguoiNuoiDuong, hocVien.GhiChu as N'Ghi chú', Lop.sbl
FROM            (((Lop INNER JOIN
                         hocVien ON Lop.idHocVien = hocVien.ID) INNER JOIN
                         ChiTietTKB ON ChiTietTKB.ID = Lop.idLop) INNER JOIN
                         ThoiKhoaBieu ON ThoiKhoaBieu.ID = ChiTietTKB.idTKB)
WHERE        (Lop.lophientai = 1) AND (ThoiKhoaBieu.Ngayketthuc >= GETDATE())
-----
create procedure getLop6
@idhocvien int
as
SELECT        ChiTietTKB.Lop
FROM            ((Lop INNER JOIN
                         ChiTietTKB ON ChiTietTKB.ID = Lop.idLop) INNER JOIN
                         ThoiKhoaBieu ON ThoiKhoaBieu.ID = ChiTietTKB.idTKB)
WHERE        (Lop.idHocVien = @idhocvien) AND (Lop.lophientai = 1) AND (ThoiKhoaBieu.Ngayketthuc >= GETDATE())
----
create procedure getLop7
@thoikhoabieuid int
as
SELECT DISTINCT hocVien.Hotenlot + ' ' + hocVien.Ten AS [Họ tên], ChiTietTKB.Lop
FROM            (((Lop INNER JOIN
                         hocVien ON Lop.idHocVien = hocVien.ID) INNER JOIN
                         ChiTietTKB ON ChiTietTKB.ID = Lop.idLop) INNER JOIN
                         ThoiKhoaBieu ON ThoiKhoaBieu.ID = ChiTietTKB.idTKB)
WHERE        (Lop.lophientai = 1) AND (ThoiKhoaBieu.ID = @thoikhoabieuid)
-----
create procedure getDiemDanh1
as
SELECT id, idHocVien, CoPhep as N'Có phép', GhiChu as N'Ghi chú', tkbID, KhongPhep as N'Không phép' FROM diemDanh
order by id desc
----
create procedure getDiemDanh2
@idhocvien int,
@tkbid int,
@tre nvarchar,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT CoPhep as N'Có phép', GhiChu as N'Ghi chú', KhongPhep as N'Không phép', id, idHocVien, tkbID 
FROM diemDanh  d
WHERE (idHocVien = @idhocvien) AND (tkbID = @tkbid) AND (Tre <> '') AND (Ngay <> NULL) and  d.Ngay>=@tungay and  d.ngay<=@denngay
-----
create procedure getDiemDanh3
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT d.id, d.idHocVien, d.CoPhep as N'Có phép'
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien = @idhocvien) AND (d.CoPhep <> NULL) AND (c.lopGoc = @lopgoc)and d.CoPhep>=@tungay and  d.CoPhep<=@denngay
----
create procedure getDiemDanh4
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT        distinct d.id, d.idHocVien, d.KhongPhep as N'Không phép'
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien = @idhocvien) AND (c.lopGoc = @lopgoc) AND (d.KhongPhep <> NULL) and d.KhongPhep>=@tungay and  d.KhongPhep<=@denngay
----
create procedure getDiemDanh5
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT d.id, d.idHocVien, d.Tre as N'Trễ', d.Ngay as N'Ngày'
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien = @idhocvien) AND (d.Tre <> '') AND (d.Ngay <> NULL) AND (c.lopGoc = @lopgoc) and  d.Ngay>=@tungay and  d.Ngay<=@denngay

----
create procedure getDiemDanh6
@id int
as
SELECT DISTINCT hocvien.id, hocVien.Hotenlot + ' ' + hocVien.Ten as [Họ tên]
FROM            (diemDanh RIGHT OUTER JOIN
                   hocVien ON diemDanh.idhocvien = hocVien.ID)
WHERE        (diemDanh.tkbID = @id)
ORDER BY hocvien.id DESC
----
create procedure getDiemDanh7
@id int
as
SELECT        hocVien.Hotenlot, hocVien.Ten
FROM            (diemDanh INNER JOIN
                         hocVien ON diemDanh.id = hocVien.ID)
WHERE        (diemDanh.tkbID = @id)
ORDER BY diemDanh.id DESC
----
create procedure getDiemDanh8
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT d.id, d.idHocVien, d.Tre, d.Ngay
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien =@idhocvien) AND (d.Tre <> '') AND (d.Ngay <> NULL) AND (c.lopGoc = @lopgoc) AND (d.Ngay>=@tungay) AND (D.Ngay<=@denngay)
---
create procedure getDiemDanh9
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT d.id, d.idHocVien, d.CoPhep
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien = @idhocvien) AND (d.CoPhep <> NULL) AND (c.lopGoc = @lopgoc) and (d.CoPhep>=@tungay) and d.CoPhep<=@denngay
----
create procedure getDiemDanh10
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT d.id, d.idHocVien, d.KhongPhep
FROM     (diemDanh d INNER JOIN
                         Lop c ON d.idHocVien = c.idHocVien and c.idlop=d.tkbid)
WHERE        (d.idHocVien = @idhocvien) AND (d.KhongPhep <> NULL) AND (c.lopGoc = @lopgoc) and (d.KhongPhep>=@tungay) and d.KhongPhep<=@denngay
----
create procedure getHocVien1
as
SELECT ID, MaHV as N'Mã học viên', Hotenlot as N'Họ tên lót', Ten as N'Tên', Ngaysinh as N'Ngày sinh',
 Truong as 'Trường', dienthoai as N'Điện thoại', Email, 
Diachi as N'Địa chỉ', hoTenCha, dienThoaiCha, NgheNghiepCha, chucVuCha, hoTenMe, dienThoaiMe, ngheNghiepMe,
 chucVuMe, tenNguoiNuoiDuong, dienThoaiNguoiNuoiDuong, emailPhuHuynh, GhiChu as N'Ghi chú', ngayDK 
 FROM hocVien
----
create procedure getHocVien2
@id int
as
SELECT Email,MaHV as N'Mã học viên', GhiChu as N'Ghi chú', Hotenlot as N'Họ tên lót', 
ID, MaHV as N'Mã học viên', NgheNghiepCha, Ngaysinh as N'Ngày sinh', Ten as N'Tên', 
chucVuCha, chucVuMe, dienThoaiCha, dienThoaiMe, dienThoaiNguoiNuoiDuong,
 emailPhuHuynh, hoTenCha, hoTenMe, ngayDK, ngheNghiepMe, 
 tenNguoiNuoiDuong, dienthoai as N'Điện thoại', Diachi as N'Địa chỉ'
   FROM hocVien WHERE (ID = @id)
----
create procedure getHocVien3
@idlop int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT 
                         hocVien.ID, hocVien.MaHV as N'Mã học viên', hocVien.Hotenlot as N'Họ tên lót', hocVien.Ten as N'Tên', hocVien.Ngaysinh as N'Ngày sinh', hocVien.dienthoai as N'Điện thoại', hocVien.Email, hocVien.Diachi as N'Địa chỉ', Lop.ngayDK, hocVien.truong as N'Trường', 
                         hocVien.hoTenCha, hocVien.dienThoaiCha, hocVien.NgheNghiepCha, hocVien.chucVuCha, hocVien.hoTenMe, hocVien.dienThoaiMe, hocVien.ngheNghiepMe, 
                         hocVien.chucVuMe, hocVien.tenNguoiNuoiDuong, hocVien.dienThoaiNguoiNuoiDuong, hocVien.emailPhuHuynh, hocVien.ghichu as N'Ghi chú'
FROM            (hocVien INNER JOIN
                         Lop ON hocVien.ID = Lop.idHocVien)
WHERE        (Lop.idlop >@idlop ) AND (lop.ngayDK >= @tungay) AND (lop.ngayDK <= @denngay) 
----
create procedure getHocVien4
@idlop int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT 
                         hocVien.ID, hocVien.MaHV as N'Mã học viên', hocVien.hotenlot as N'Họ tên lót', hocVien.Ten as N'Tên', 
						 hocVien.ngaysinh as N'Ngày sinh', hocVien.dienthoai as N'Điện thoại', hocVien.Email, hocVien.diachi as N'Địa chỉ',
						  Lop.ngayDK, hocVien.truong as N'Trường', 
                         hocVien.hoTenCha, hocVien.dienThoaiCha, hocVien.NgheNghiepCha, hocVien.chucVuCha, hocVien.hoTenMe, hocVien.dienThoaiMe, hocVien.ngheNghiepMe, 
                         hocVien.chucVuMe, hocVien.tenNguoiNuoiDuong, hocVien.dienThoaiNguoiNuoiDuong, hocVien.emailPhuHuynh, hocVien.GhiChu as N'Ghi chú'
FROM            (hocVien INNER JOIN
                         Lop ON hocVien.ID = Lop.idHocVien)
WHERE        (Lop.idLop = @idlop) AND (Lop.ngayDK >=@tungay) AND (Lop.ngayDK <=@denngay)
---
create procedure getHocVien5
@idlop int
as
SELECT DISTINCT hocVien.ID, hocVien.maHV as N'Mã học viên', hocVien.hotenlot + ' ' + hocVien.Ten AS N'Họ tên'
FROM            (hocVien INNER JOIN
                         Lop ON hocVien.ID = Lop.idHocVien)
WHERE        (Lop.idLop = @idlop) AND (Lop.lophientai = 1)
----
create procedure getDe1
as
SELECT        de.ID, de.Cau AS N'Câu', kiemTra.maDe AS N'Mã đề',de.CauLon AS N'Câu lớn', 
de.nhomCau AS [Nhóm câu], de.diemToiDa AS [Điểm tối đa], ChiTietTKB.Lop as N'Lớp'
FROM            ((de INNER JOIN
                         kiemTra ON de.deID = kiemTra.ID) INNER JOIN
                         ChiTietTKB ON kiemTra.idLop = ChiTietTKB.ID)
ORDER BY de.ID DESC
----
create procedure deleteDe
@id int
as
DELETE FROM de WHERE Id = @id
---
create procedure getDe2
@id int
as
SELECT        ID, Cau
FROM            de
WHERE deid=@id
order by id
----
create procedure getDe3
@id int
as
SELECT        de.ID, de.Cau AS N'Câu', kiemTra.maDe AS N'Mã đề', kiemTra.tracNghiem AS TN, kiemTra.tuLuan AS TL, de.diemToiDa, de.CauLon, de.nhomCau
FROM            (de INNER JOIN
                         kiemTra ON de.deID = kiemTra.ID)
WHERE        (de.deID = @id)
ORDER BY de.ID
---
create procedure getDe4
@id int
as
SELECT        count(id) as dem
from de
where deid=@id
----
create procedure getDe5
@id int
as
SELECT        diemtoida, Cau
FROM            de
WHERE        (deID =
                             (SELECT        deID
                               FROM            de de_1
                               WHERE        (ID = @id)))
-----
create procedure getDe6
@id int,
@cau nvarchar
as
SELECT        diemtoida
FROM            de
WHERE        (deID =
                             (SELECT        deID
                               FROM            de de_1
                               WHERE        (ID = @id))) AND (Cau = @cau)
------
create procedure getDe7
@id int
as
SELECT        deID
FROM            de de_1
WHERE        (ID = @id)

----
create procedure getDe8
@id int
as
select top 21 id from de where deid=@id order by id
----
create procedure getDe9
@id int
as
select top 42 id from de where deid=@id order by id
----
create procedure getDe10
@id int
as
select  max(id) as hana  from de where deid=@id
-----
create procedure getDe11
@id int
as
SELECT      kiemtra.id as IDde,  de.ID,  kiemTra.maDe AS N'Mã đề', de.CauLon  + ' ' + de.Cau AS N'Câu', de.diemToiDa AS N'Điểm tối đa'
FROM            ((de INNER JOIN
                         kiemTra ON de.deID = kiemTra.ID) INNER JOIN
                         ChiTietTKB ON kiemTra.idLop = ChiTietTKB.ID)
where kiemtra.id=@id
-----
create procedure InsertDe
@cau nvarchar,
@deid int,
@diemtoida float,
@caulon nvarchar,
@nhomcau nvarchar
as
INSERT INTO de (Cau, deID, diemtoida, caulon, nhomcau) VALUES (@cau, @deid, @diemtoida,@caulon,@nhomcau)
----
create procedure UpdateDe1
@cau nvarchar,
@id int,
@diemtoida float,
@caulon nvarchar,
@nhomcau nvarchar
as
UPDATE       de
SET                Cau = @cau, diemToiDa = @diemtoida, CauLon = @cau, nhomCau = @nhomcau
WHERE        (ID = @id)
----
create procedure UpdateDe2
@cau nvarchar,
@id int,
@diem1 float,
@diem2 float
as
UPDATE       de
SET                diemtoida = diemtoida+@diem1-@diem2
WHERE        (deID = @id) AND (Cau = @cau)
----
create procedure getKetQua9
@id int,
@idlop int
as
SELECT        ketQuaHocTap.id, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', c.Lop as 'Lớp', 
			ketQuaHocTap.diem AS N'Điểm',  de.CauLon + ' ' + de.Cau AS N'Câu', hocVien.Ten as N'Tên', de.diemtoida
FROM           ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (k.id = @id) AND (ketQuaHocTap.idLopHoc = @idlop) 
ORDER BY de.ID
----
create procedure deleteKetqua
@id int
as
DELETE FROM ketQuaHocTap WHERE (id = @id) 
----
create procedure deleteKetQua1
@made int,
@idhocvien int
as
DELETE k from ketquahoctap k inner join de d on k.idBaiTap = d.ID inner join kiemtra s on s.ID=d.deID
 where made=@made and idhocvien=@idhocvien

 -----
 drop procedure getKetQua10
 go
 create procedure getKetQua10
 @made int,
 @lop int
 as
 SELECT       ketQuaHocTap.id, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', c.Lop as N'Lớp', 
			ketQuaHocTap.diem AS Điểm, de.Cau AS Câu, hocVien.Ten as N'Tên', de.CauLon, de.diemtoida
FROM            ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (k.id=@made) AND (ketQuaHocTap.idLopHoc = lop) and  (de.id in (SELECT distinct top 40  de.id from   (((ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID) INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID) INNER JOIN
                         de ON de.ID = ketQuaHocTap.idBaiTap) where (k.id=@made) AND (ketQuaHocTap.idLopHoc = @lop)   ))
 and (de.id not in (SELECT distinct top  20 de.id from   (((ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID) INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID) INNER JOIN
                         de ON de.ID = ketQuaHocTap.idBaiTap) where (k.id=@made) AND (ketQuaHocTap.idLopHoc = @lop)  ))
order by de.id
----
create procedure getKetQua11
@id int,
@de int
as
SELECT      1 as kq
from ketquahoctap k inner join de d on k.idBaiTap = d.ID inner join kiemtra s on s.ID=d.deID
where idhocvien=@id  and k.id=@de
----
create procedure getKetQua12
@id int,
@de int
as
SELECT DISTINCT idHocVien
from ketquahoctap k inner join de d on k.idBaiTap = d.ID inner join kiemtra s on s.ID=d.deID
where  k.id=@de and idLopHoc=@id
----
create procedure getKetQua13
@made int,
@idlophoc int
as
SELECT DISTINCT idHocVien
from ketquahoctap k inner join de d on k.idBaiTap = d.ID inner join kiemtra s on s.ID=d.deID
WHERE        (s.id = @made) AND (idLopHoc = @idlophoc)
-----
create procedure getKetQua14
@idlophoc int,
@tucau int,
@dencau int,
@idhocvien int
as
SELECT        ketQuaHocTap.id, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', c.Lop as N'Lớp', 
ketQuaHocTap.diem AS N'Điểm', de.Cau AS N'Câu', hocVien.Ten as N'Tên', de.cauLon, de.diemtoida, 
                         k.maDe, k.ngayLam
FROM            ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (ketQuaHocTap.idLopHoc = @idlophoc) AND (de.ID >= @tucau) AND (de.ID <= @dencau) AND (ketQuaHocTap.idHocVien = @idhocvien)
ORDER BY de.ID
----ngừng check tại đây
----
create procedure getKetQua15
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@dennay smalldatetime
as
SELECT DISTINCT ketQuaHocTap.diem AS Điểm, k.ngayLam, k.heSo, ketQuaHocTap.idHocVien
FROM           ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         lop c ON ketQuaHocTap.idHocVien = c.idHocVien INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (ketQuaHocTap.idHocVien = @idhocvien) AND (c.lopGoc = @lopgoc) AND (de.Cau = '  Tổng')   and k.ngayLam>=@tungay and k.ngayLam<=@dennay
order by k.ngaylam
---
create procedure getKetQua16
@de int,
@lop int
as
SELECT        ketQuaHocTap.id, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', c.Lop as N'Lớp', ketQuaHocTap.diem AS Điểm, de.Cau AS Câu,hocVien.Ten as N'Tên', de.caulon, de.diemtoida
FROM                               ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (k.ID = @de) AND (ketQuaHocTap.idLopHoc = @lop) and (de.id not in (SELECT distinct top 40 de.id 
			from          ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
						where (k.ID = @de) AND (ketQuaHocTap.idLopHoc = @lop)  ))
order by de.id
-----
create procedure getKetqua17
@de int,
@lop int
as
SELECT        ketQuaHocTap.id, hocVien.Hotenlot + ' ' + hocVien.Ten AS [Họ tên], c.Lop as N'Lớp', ketQuaHocTap.diem AS N'Điểm', de.cauLon + ' ' + de.Cau as N'Câu'
FROM           ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         ChiTietTKB c ON ketQuaHocTap.idLopHoc = c.ID INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (k.id = @de) AND (ketQuaHocTap.idLopHoc = @lop)
ORDER BY hocVien.Ten, de.ID
----
create procedure getKetQua18
@id int
as
SELECT        idBaiTap, idHocVien
FROM            ketQuaHocTap
WHERE        (id = @id)
----
create procedure getKetQua19
@id int
as
select nhomcau
from de 
where id=@id
----
create procedure getKetQua20
@id int,
@cau nvarchar
as
SELECT        ID
                               FROM            de
                               WHERE        (deID = @id) AND (Cau = @cau)
create procedure getKetQua21
@idlop int
as
SELECT        hocVien.ID, hocVien.Hotenlot + ' ' + hocVien.Ten AS N'Họ tên', Lop.idLop, ChiTietTKB.Lop as N'Lớp'
FROM            ((hocVien INNER JOIN
                         Lop ON hocVien.ID = Lop.idHocVien) INNER JOIN
                         ChiTietTKB ON Lop.idLop = ChiTietTKB.ID)
WHERE        (Lop.lopHienTai = 1) AND (Lop.idLop = @idlop)
-----
create procedure getKetQua22
@idhocvien int,
@lopgoc int,
@tungay smalldatetime,
@denngay smalldatetime
as
SELECT DISTINCT ketQuaHocTap.diem AS Điểm, k.ngayLam, k.heSo, k.made as [Mã đề],ketQuaHocTap.idHocVien,hocVien.Hotenlot + ' ' + hocVien.Ten AS [Họ tên]
FROM            ketQuaHocTap INNER JOIN
                         hocVien ON ketQuaHocTap.idHocVien = hocVien.ID INNER JOIN
                         lop c ON ketQuaHocTap.idHocVien = c.idHocVien INNER JOIN
                         de ON ketQuaHocTap.idBaiTap = de.ID inner join kiemtra k
						on k.id=de.deID
WHERE        (ketQuaHocTap.idHocVien = @idhocvien) AND (c.lopGoc = @lopgoc) AND (de.Cau = '  Tổng')  and k.ngayLam>=@tungay and k.ngayLam<=@denngay
order by k.ngaylam
----
create procedure InsertKetQua
@idhocvien int,
@idlophoc int,
@idbaitap int,
@diem float
as
INSERT INTO ketQuaHocTap
                         (idHocVien, idLopHoc, idBaiTap, diem)
VALUES        (@idhocvien,@idlophoc, @idbaitap, @diem)
----
create procedure UpdateKetQua
@diem float,
@id int
as
UPDATE ketQuaHocTap SET diem=@diem where id=@id
-----
create procedure UpdateKetQua1
@tong float,
@de int
as
UPDATE a set diem=@tong from ketQuaHocTap a inner join de on a.idBaiTap=de.ID inner join kiemTra on kiemTra.id=de.deID   where kiemtra.id=@de

----cắt ra làm 2 hàm
---hàm 1: Sum điểm
---hàm 2: update set diem=sum
----
create procedure getKetQua23
@de int
as
Select sum(diem) from ketquahoctap 
where id>=(select max(k.id) from ketquahoctap k inner join de d on k.idBaiTap = d.ID inner join kiemtra s on s.ID=d.deID where s.id=@de)
---
create procedure updateKetQua2
@diem1 float,
@diem2 float,
@idbaitap int,
@idhocvien int
as
UPDATE       ketQuaHocTap
SET                diem = diem + @diem1 - @diem2
WHERE        idBaiTap = @idbaitap and idhocvien=@idhocvien