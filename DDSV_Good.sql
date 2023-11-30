use master
create database DDSV_Last

use DDSV_Last

CREATE TABLE GiangVien( 
    MaGiangVien VARCHAR(10) PRIMARY KEY, 
	Password varchar(100),
    HoTenGiangVien VARCHAR(50), 
    TrinhDo VARCHAR(20), 
    ChuyenMon VARCHAR(50) 
); 

CREATE TABLE SinhVien( 
    MaSinhVien VARCHAR(10) PRIMARY KEY, 
	Password varchar(100),
    HoTenSinhVien VARCHAR(50), 
    NgaySinh DATE, 
    GioiTinh VARCHAR(10), 
    LopNienChe VARCHAR(10) 
); 
CREATE TABLE MonHoc( 
    MaMonHoc VARCHAR(10) PRIMARY KEY, 
    TenMonHoc VARCHAR(50), 
    TongSoTiet INT, 
    SoTietLyThuyet INT, 
    SoTietThucHanh INT, 
); 
CREATE TABLE LopMonHoc( 
    MaLopMonHoc VARCHAR(10) PRIMARY KEY, 
    SiSo INT, 
    MaMonHoc VARCHAR(10), 
	MaGiangVien VARCHAR(10),
	NgayBD date,
	NgayKT date,
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc),
    FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
); 

CREATE TABLE PhongHoc( 
    MaPhongHoc VARCHAR(10) PRIMARY KEY, 
    TenPhongHoc VARCHAR(50), 
    DiaChi VARCHAR(100) 
); 
CREATE TABLE CaHoc( 
    MaCaHoc VARCHAR(10) PRIMARY KEY, 
    GioBD TIME, 
    GioKT TIME, 
    BuoiHoc NVARCHAR(20), 
); 


create table SV_LopMonHoc
(
	MaLopMonHoc VARCHAR(10) not null,
	MaSinhVien VARCHAR(10) not null,
	HocKy varchar(10),
	NamHoc varchar(10)
	primary key(MaLopMonHoc,MaSinhVien),
	FOREIGN KEY (MaLopMonHoc) REFERENCES LopMonHoc(MaLopMonHoc), 
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien) 
)
CREATE TABLE DiemDanh( 
    MaSinhVien VARCHAR(10) not null, 
    MaLopMonHoc VARCHAR(10) not null, 
	NgayHoc date not null,
    TrangThai nvarchar(20), 
	primary key(MaSinhVien,MaLopMonHoc,NgayHoc),
    FOREIGN KEY (MaLopMonHoc,MaSinhVien) REFERENCES SV_LopMonHoc(MaLopMonHoc,MaSinhVien)
); 
CREATE TABLE LichHoc( 
	MaLichHoc VARCHAR(10) PRIMARY KEY,
    MaLopMonHoc VARCHAR(10), 
    MaPhongHoc VARCHAR(10), 
    MaCaHoc VARCHAR(10),
    FOREIGN KEY (MaLopMonHoc) REFERENCES LopMonHoc(MaLopMonHoc), 
    FOREIGN KEY (MaPhongHoc) REFERENCES PhongHoc(MaPhongHoc), 
    FOREIGN KEY (MaCaHoc) REFERENCES CaHoc(MaCaHoc) 
); 


INSERT INTO GiangVien (MaGiangVien, HoTenGiangVien, TrinhDo, ChuyenMon) 
VALUES
('GV001', N'Lâm Thị Họa Mi', 'Tien si', 'Cong nghe thong tin'),
('GV002', 'Nguyen Thi Thu', 'Thac si', 'Ke toan'),
('GV003', 'Le Van Nghia', 'Tien si', 'Kinh te'),
('GV004', 'Pham Van Hung', 'Thac si', 'Ngoai ngu'),
('GV005', 'Hoang Thi Huyen', 'Tien si', 'Vat ly');

INSERT INTO SinhVien (MaSinhVien, HoTenSinhVien, NgaySinh, GioiTinh, LopNienChe) 
VALUES
('SV001', N'Bồ Quang Diệu', '2000-01-15', 'Nam', 'K18DH1'),
('SV002', N'Hồ Ngọc Tùng', '2000-05-20', 'Nu', 'K18DH2'),
('SV003', 'Le Van Cuong', '1999-12-10', 'Nam', 'K18CN1'),
('SV004', 'Pham Thi Dung', '2000-03-25', 'Nu', 'K18CN2'),
('SV005', 'Hoang Van Hieu', '1999-08-05', 'Nam', 'K18QT1'),
('SV006', 'Nguyen Van Khanh', '2000-02-18', 'Nam', 'K18QT2'),
('SV007', 'Tran Thi Lan', '2000-07-30', 'Nu', 'K18DT1'),
('SV008', 'Le Van Minh', '1999-10-22', 'Nam', 'K18DT2'),
('SV009', 'Pham Thi Ngoc', '2000-04-12', 'Nu', 'K18KT1'),
('SV010', 'Nguyen Van Phong', '1999-09-08', 'Nam', 'K18KT2'),
('SV011', 'Tran Van Quyen', '2000-06-14', 'Nam', 'K18QT3'),
('SV012', 'Le Thi Tuyet', '1999-11-28', 'Nu', 'K18DT3'),
('SV013', 'Pham Van Vinh', '2000-08-19', 'Nam', 'K18CN3'),
('SV014', 'Nguyen Thi Xuan', '2000-01-03', 'Nu', 'K18QT4'),
('SV015', 'Hoang Van Yen', '1999-07-17', 'Nam', 'K18KT3');

INSERT INTO MonHoc(MaMonHoc, TenMonHoc, TongSoTiet, SoTietLyThuyet, SoTietThucHanh) 
VALUES ('MH01', 'Lap trinh huong doi tuong', 90, 60, 30), 
       ('MH02', 'Phat trien ung dung Web', 90, 60, 30), 
       ('MH03', 'Kien truc may tinh', 90, 60, 30), 
       ('MH04', 'Do hoa may tinh', 90, 60, 30), 
       ('MH05', 'Nhap mon lap trinh', 90, 60, 30), 
       ('MH06', 'Xu ly tin hieu so', 90, 60, 30), 
       ('MH07', 'He quan tri CSDL', 90, 60, 30), 
       ('MH08', 'Quan tri du an phan mem', 90, 60, 30), 
       ('MH09', 'He thong may tinh', 90, 60, 30), 
       ('MH10', 'CSDL', 90, 60, 30);

INSERT INTO LopMonHoc(MaLopMonHoc, SiSo, MaMonHoc, MaGiangVien, NgayBD, NgayKT) 
VALUES
('LMH001', 40, 'MH01', 'GV001', '2023-01-10', '2023-05-10'),
('LMH002', 35, 'MH02', 'GV002', '2023-01-15', '2023-05-15'),
('LMH003', 30, 'MH03', 'GV003', '2023-01-20', '2023-05-20'),
('LMH004', 25, 'MH04', 'GV004', '2023-01-25', '2023-05-25'),
('LMH005', 40, 'MH05', 'GV005', '2023-02-01', '2023-06-01'),
('LMH006', 35, 'MH06', 'GV001', '2023-02-05', '2023-06-05'),
('LMH007', 30, 'MH07', 'GV002', '2023-02-10', '2023-06-10'),
('LMH008', 25, 'MH08', 'GV003', '2023-02-15', '2023-06-15');

INSERT INTO SV_LopMonHoc (MaLopMonHoc, MaSinhVien, HocKy, NamHoc)
VALUES
('LMH001', 'SV001', '2023A', '2023-2024'),
('LMH001', 'SV002', '2023A', '2023-2024'),
('LMH001', 'SV003', '2023A', '2023-2024'),
('LMH001', 'SV004', '2023A', '2023-2024'),
('LMH001', 'SV005', '2023A', '2023-2024');
INSERT INTO SV_LopMonHoc (MaLopMonHoc, MaSinhVien, HocKy, NamHoc)
VALUES
('LMH006', 'SV001', '2023A', '2023-2024'),
('LMH006', 'SV002', '2023A', '2023-2024'),
('LMH006', 'SV003', '2023A', '2023-2024'),
('LMH006', 'SV004', '2023A', '2023-2024'),
('LMH006', 'SV005', '2023A', '2023-2024');
INSERT INTO SV_LopMonHoc (MaLopMonHoc, MaSinhVien, HocKy, NamHoc)
VALUES
('LMH003', 'SV001', '2023A', '2023-2024'),
('LMH003', 'SV002', '2023A', '2023-2024'),
('LMH003', 'SV003', '2023A', '2023-2024'),
('LMH003', 'SV004', '2023A', '2023-2024'),
('LMH003', 'SV005', '2023A', '2023-2024');
INSERT INTO SV_LopMonHoc (MaLopMonHoc, MaSinhVien, HocKy, NamHoc)
VALUES
('LMH008', 'SV001', '2023A', '2023-2024'),
('LMH008', 'SV002', '2023A', '2023-2024'),
('LMH008', 'SV003', '2023A', '2023-2024'),
('LMH008', 'SV004', '2023A', '2023-2024'),
('LMH008', 'SV005', '2023A', '2023-2024');


INSERT INTO DiemDanh (MaSinhVien, MaLopMonHoc, NgayHoc, TrangThai)
SELECT MaSinhVien, MaLopMonHoc, '2023-01-10', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-01-15', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-01-20', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-01-25', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-01', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-05', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH001';

INSERT INTO DiemDanh (MaSinhVien, MaLopMonHoc, NgayHoc, TrangThai)
SELECT MaSinhVien, MaLopMonHoc, '2023-02-05', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-10', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-15', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-20', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-25', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-03-01', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH006';

-- For LMH003
INSERT INTO DiemDanh (MaSinhVien, MaLopMonHoc, NgayHoc, TrangThai)
SELECT MaSinhVien, MaLopMonHoc, '2023-01-20', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-01-25', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-01', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-05', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-10', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-15', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH003';

-- For LMH008
INSERT INTO DiemDanh (MaSinhVien, MaLopMonHoc, NgayHoc, TrangThai)
SELECT MaSinhVien, MaLopMonHoc, '2023-02-15', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-20', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-02-25', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-03-01', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-03-05', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008'
UNION ALL
SELECT MaSinhVien, MaLopMonHoc, '2023-03-10', NULL FROM SV_LopMonHoc WHERE MaLopMonHoc = 'LMH008';


ALTER TABLE SinhVien
  ADD Image varchar(1000)
update DiemDanh 
set TrangThai = N'Có mặt'

alter table SinhVien
	ALTER COLUMN HoTenSinhVien NVARCHAR(50)

alter table GiangVien
	ALTER COLUMN HoTenGiangVien NVARCHAR(50)

update SinhVien
set Image = 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjGlQ7nJKIi_Uakf7nFaDtVj_QniD6qvoZUg&usqp=CAU'
-- ví dụ
select *from DiemDanh where MaLopMonHoc = 'LMH001' and NgayHoc = '2023-01-15'

select distinct NgayHoc from DiemDanh where MaLopMonHoc = 'LMH001'

	

select DiemDanh.MaSinhVien,HoTenSinhVien,NgayHoc from DiemDanh inner join SinhVien on DiemDanh.MaSinhVien = SinhVien.MaSinhVien where MaLopMonHoc = 'LMH001' and NgayHoc = '2023-01-10'



select DiemDanh.masinhvien, hotensinhvien, MaLopMonHoc, ngayhoc, trangthai from DiemDanh inner join sinhvien on diemdanh.masinhvien = sinhvien.masinhvien where DiemDanh.MaSinhVien = 'SV001' 