Create database DuAnMau
go
Use DuAnMau
go

Create table KHACHHANG
(
	MAKH int identity not null,
	TENKH nvarchar(100) not null,
	DIACHI nvarchar(200),
	GIOITINH bit,
	Constraint PK_KHACHHANG primary key(MAKH),
)
go

Create table NHANVIEN
(
	MANV int identity not null,
	HOTEN nvarchar(100) not null,
	NGAYSINH datetime,
	DIACHI nvarchar(200),
	VAITRO nvarchar(50),
	MATKHAU nvarchar(200),
	TINHTRANG nvarchar(30),
	Constraint PK_NHANVIEN primary key(MANV),
)
go

Create table SANPHAM
(
	MASP int identity not null,
	TENSP nvarchar(50) not null,
	SOLUONG int,
	DONGIANHAP money,
	DONGIABAN money,
	HINHANH varchar(200),
	CONSTRAINT PK_SANPHAM primary key(MASP),
)
go

Create table HOADON
(
	MAHD int not null,
	MAKH int not null,
	MANV int not null,
	NGAYLAP datetime,
	Constraint PK_HOADON primary key(MAHD),
	Constraint FK_HOADON_KHACHHANG foreign key(MAKH) references KHACHHANG(MAKH),
	Constraint FK_HOADON_NHANVIEN foreign key(MANV) references NHANVIEN(MANV),
)
go

Create table CTHD
(
	MACTHD int not null,
	MAHD int not null,
	MASP int not null,
	SOLUONG int,
	GIA money,
	Constraint PK_CTHD primary key(MACTHD),
	Constraint FK_CTHD_HOADON foreign key(MAHD) references HOADON(MAHD),
	Constraint FK_CTHD_SANPHAM foreign key(MASP) references SANPHAM(MASP)
)