create table Khachhang(
	makhachhang nvarchar (10) not null,
	hoten nvarchar (30) not null,
	gioitinh nvarchar (10),
	ngaysinh date,
	diachi nvarchar(30),
	cccd char (12),
	sdt char (10),
	primary key (makhachhang),
);

create table Phong(
	maphong nvarchar(10) not null,
	loaiphong nvarchar(10),
	giaphong float,
	tinhtrangphong nvarchar(10),
	primary key (maphong)
);

create table Nhanvien(
	manv nvarchar (20) not null,
	hoten nvarchar (50),
	ngaysinh date,
	gioitinh nvarchar (10),
	quequan nvarchar (50),
	sodt nvarchar(50),
	luong float,
	chucvu nvarchar(55),
	matkhau nvarchar(50),
	hinhanh varchar(max),
	primary key (manv)
);

create table Hoadon(
	mahoadon nvarchar (15) not null,
	ngaylaphd date,
	thanhtien money,
	makhachhang nvarchar (10),
	manv nvarchar (20),
	primary key (mahoadon),
	foreign key (makhachhang) references Khachhang(makhachhang),
	foreign key (manv) references Nhanvien(manv)
);

create table Chitietthue(
	ngaylapphongthue date,
	ngaytraphong date,
	mahoadon nvarchar (15),
	maphong nvarchar(10),
	primary key(mahoadon,maphong),
	foreign key (maphong) references Phong(maphong), 
	foreign key (mahoadon) references Hoadon(mahoadon)
);

create table Dichvu(
	madichvu nvarchar(20) not null,
	tendichvu nvarchar(30),
	giadichvu money,
	primary key(madichvu)
);

create table Chitietdichvu(
	ngaysudung date,
	madichvu nvarchar(20),
	mahoadon nvarchar (15),
	primary key(madichvu,mahoadon),
	foreign key (madichvu) references Dichvu(madichvu),
	foreign key (mahoadon) references Hoadon(mahoadon)
);

insert into Khachhang values (N'KH1',N'Phạm Chí Hùng',N'Nam',N'2002-05-15',N'TPHCM',N'079202001113',N'0381475689');
insert into Khachhang values (N'KH2',N'Huỳnh Ngọc Tài',N'Nam',N'2002-02-18',N'TPHCM',N'079202045672',N'0385792541');
insert into Khachhang values (N'KH3',N'Nguyễn Thị Lan',N'Nữ',N'2002-03-17',N'Huế',N'079202236570',N'0381965403');
insert into Khachhang values (N'KH4',N'Vũ Thị Lan Anh',N'Nữ',N'1998-05-15',N'Cao Bằng',N'079202645231',N'0381841069');
insert into Khachhang values (N'KH5',N'Trần Thiên Phú',N'Nam',N'1995-07-15',N'TPHCM',N'079275315948',N'0374475689');
insert into Khachhang values (N'KH6',N'Hoàng Giang',N'Nữ',N'1990-05-20',N'Nghệ An',N'079254316879',N'0395712648');
insert into Khachhang values (N'KH7',N'Văn Công Hào',N'Nam',N'2002-07-09',N'Bình Định',N'079204587113',N'0381401599');
insert into Khachhang values (N'KH8',N'Trần Hoàng Triều',N'Nam',N'2002-06-15',N'TPHCM',N'079202047113',N'0381402689');
insert into Khachhang values (N'KH9',N'Kiều Oanh',N'Nữ',N'2002-01-15',N'TPHCM',N'079202001413',N'0381490689');
insert into Khachhang values (N'KH10',N'Hồng Gấm',N'Nữ',N'2003-05-30',N'Điện Biên',N'079342001113',N'0381475689');

insert into Phong values (N'MP1',N'Phòng Đơn',N'600000',N'Yes'); 
insert into Phong values (N'MP2',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP3',N'Phòng Đơn',N'600000',N'Yes');
insert into Phong values (N'MP4',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP5',N'Phòng Đôi',N'900000',N'Yes');
insert into Phong values (N'MP6',N'Phòng Đôi',N'900000',N'Yes');
insert into Phong values (N'MP7',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP8',N'Phòng Đôi',N'900000',N'Yes');
insert into Phong values (N'MP9',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP10',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP11',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP12',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP13',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP14',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP15',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP16',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP17',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP18',N'Phòng Đôi',N'900000',N'No');
insert into Phong values (N'MP19',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP20',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP21',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP22',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP23',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP24',N'Phòng Đơn',N'600000',N'No');
insert into Phong values (N'MP25',N'Phòng Đơn',N'600000',N'No');

insert into Nhanvien values (N'NV.LT1',N'Cẩm Liên',N'1995-04-30',N'Nữ',N'TPHCM',N'0396524871',N'5000000',N'Lễ tân','19950430','unknows');
insert into Nhanvien values (N'NV.TN2',N'Cẩm Thơ',N'1990-06-30',N'Nữ',N'Đà Nẵng',N'0396478219',N'7000000',N'Thu ngân','19900630','unknows');
insert into Nhanvien values (N'NV.QL',N'Hoàng Trung',N'1994-08-28',N'Nam',N'Quãng Ngãi',N'0396528912',N'5000000',N'Quản lý','19940828','unknows');
insert into Nhanvien values (N'NV.LT4',N'Thái Hoàng',N'1995-01-04',N'Nam',N'TPHCM',N'0396521597',N'7000000',N'lễ tân','19950104','unknows');
insert into Nhanvien values (N'NV.TN5',N'Phùng Lan Hoa',N'1996-03-31',N'Nữ',N'TPHCM',N'0396535491',N'5000000',N'Thu ngân','19960331','unknows');

insert into Hoadon values (N'HD1',N'2022-03-15','',N'KH1',N'NV.QL');
insert into Hoadon values (N'HD3',N'2022-05-16','',N'KH3',N'NV.TN2');
insert into Hoadon values (N'HD5',N'2022-07-15','',N'KH5',N'NV.TN2');
insert into Hoadon values (N'HD6',N'2022-08-13','',N'KH6',N'NV.TN5');
insert into Hoadon values (N'HD8',N'2022-10-19','',N'KH8',N'NV.TN2');
insert into Hoadon values (N'HD10',N'2022-09-15','',N'KH10',N'NV.TN5');

insert into Chitietthue values (N'2022-03-14',N'2022-03-16',N'HD1',N'MP1');
insert into Chitietthue values (N'2022-05-15',N'2022-05-18',N'HD3',N'MP3');
insert into Chitietthue values (N'2022-07-14',N'2022-07-15',N'HD5',N'MP5');
insert into Chitietthue values (N'2022-08-12',N'2022-08-14',N'HD6',N'MP6');
insert into Chitietthue values (N'2022-10-18',N'2022-10-19',N'HD8',N'MP8');
insert into Chitietthue values (N'2022-09-14',N'2022-09-16',N'HD10',N'MP10');

insert into Dichvu values (N'DV1',N'Xông hơi',N'50000');
insert into Dichvu values (N'DV2',N'Massage',N'100000');
insert into Dichvu values (N'DV3',N'Tắm bể bơi',N'30000');
insert into Dichvu values (N'DV4',N'Giặt ủi',N'30000');

insert into Chitietdichvu values (N'2022-03-14',N'DV1',N'HD1');
insert into Chitietdichvu values (N'2022-05-15',N'DV1',N'HD3');
insert into Chitietdichvu values (N'2022-07-14',N'DV2',N'HD5');
insert into Chitietdichvu values (N'2022-08-12',N'DV2',N'HD6');
insert into Chitietdichvu values (N'2022-10-18',N'DV3',N'HD8');
insert into Chitietdichvu values (N'2022-09-14',N'DV4',N'HD10');

