create table loaiphong(
	maloaiphong INT IDENTITY(1,1) PRIMARY KEY,
	tenloaiphong nvarchar(100),
	giatien float
)
create table phong(
	maphong INT IDENTITY(1,1) PRIMARY KEY,
	tenphong nvarchar(100),
	maloaiphong int,
	trangthaithuephong nvarchar(100),
	sodienthangcu int,
	sonuocthangcu int,
	sokhachtoida int,
	ngaybatdauthue date
	CONSTRAINT FK_phong1 FOREIGN KEY (maloaiphong) REFERENCES loaiphong(maloaiphong)
	ON DELETE CASCADE ON UPDATE CASCADE
)
create table khachhang(
	makhach INT IDENTITY(1,1) PRIMARY KEY,
	hotenkhach nvarchar(100),
	sdtkhach nvarchar(100),
	socmnd nvarchar(100),
	anhchandung nvarchar(500),
	mattruoccmnd  nvarchar(500),
	mattsaucmnd  nvarchar(500)
)
create table dangnhapKH(
	tendangnhap int primary key,
	matkhau nvarchar(500),
	quyen varchar(100),
	active int
	CONSTRAINT FK_dnKH FOREIGN KEY (tendangnhap) REFERENCES khachhang(makhach)
	ON DELETE CASCADE ON UPDATE CASCADE
)
create table nhanvien(
	manv nvarchar(20) PRIMARY KEY,
	hotennv nvarchar(100),
	cccd nvarchar(100),
	ngaysinh date,
	gioitinh nvarchar(10),
	sdt nvarchar(20),
	email nvarchar(200),
	diachi nvarchar(500)
)
go
create table dangnhapNV(
	tendangnhap nvarchar(20) primary key,
	matkhau nvarchar(500),
	quyen varchar(100),
	active int
	CONSTRAINT FK_dn1 FOREIGN KEY (tendangnhap) REFERENCES nhanvien(manv)
	ON DELETE CASCADE ON UPDATE CASCADE
)
create table thuephong(
	mathuephong int IDENTITY(1,1) PRIMARY KEY,
	maphong int,
	makhach int,
	ngaybatdauthue date
	CONSTRAINT FK_thuephong FOREIGN KEY (maphong) REFERENCES phong(maphong)
	ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_thuephong02 FOREIGN KEY (makhach) REFERENCES khachhang(makhach)
	ON DELETE CASCADE ON UPDATE CASCADE
)
create table phieuthutientro(
	maphieuthu int IDENTITY(1,1) PRIMARY KEY,
	maphong int,
	nhanvienlap nvarchar(20),
	ngaylap date,
	sodiencu int,
	sodienmoi int,
	giadien float,
	sonuoccu float,
	sonuocmoi float,
	gianuoc float,
	thanhtien float,
	trangthaidongtien nvarchar(100),
	giaphong nvarchar(100)
	CONSTRAINT FK_phieuthutientro01 FOREIGN KEY (maphong) REFERENCES phong(maphong)
	ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_phieuthutientro02 FOREIGN KEY (nhanvienlap) REFERENCES nhanvien(manv)
	ON DELETE CASCADE ON UPDATE CASCADE
)
create table guitrogiup(
	matrogiup int IDENTITY(1,1) PRIMARY KEY,
	makhach int,
	maphong int,
	mota nvarchar(500),
	trangthaihotro nvarchar(100)
	CONSTRAINT FK_guitrogiup01 FOREIGN KEY (makhach) REFERENCES khachhang(makhach)
	ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_guitrogiup02 FOREIGN KEY (maphong) REFERENCES phong(maphong)
	ON DELETE CASCADE ON UPDATE CASCADE
)
