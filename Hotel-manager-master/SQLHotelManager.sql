CREATE DATABASE HOTEL_MANAGER
GO

USE HOTEL_MANAGER
GO

CREATE TABLE LOAI_PHONG (
	MaLoaiPhong int NOT NULL PRIMARY KEY,
	TenLoaiPhong NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
	DonGia MONEY
)
GO

CREATE TABLE TRANG_THAI_PHONG (
	MaTrangThai INT NOT NULL PRIMARY KEY,
	TenTrangThai NVARCHAR(50) NOT NULL
)
GO

INSERT INTO dbo.TRANG_THAI_PHONG( MaTrangThai, TenTrangThai ) VALUES(1, N'Đang cho thuê ')
INSERT INTO dbo.TRANG_THAI_PHONG( MaTrangThai, TenTrangThai ) VALUES(2, N'Có thể cho thuê ')
INSERT INTO dbo.TRANG_THAI_PHONG( MaTrangThai, TenTrangThai ) VALUES(3, N'Đang sửa chữa ')

CREATE TABLE PHONG (
	MaPhong INT NOT NULL PRIMARY KEY,
	TenPhong NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiPhong INT NOT NULL,
	GhiChu NVARCHAR(100) DEFAULT N'chua co ghi chu',
	TinhTrangPhong INT NOT NULL DEFAULT 1, -- 1: Có thể cho thuê || 0: Có ng thuê, đang sửa chữa

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAI_PHONG(MaLoaiPhong),
	FOREIGN KEY (TinhTrangPhong) REFERENCES dbo.TRANG_THAI_PHONG(MaTrangThai)
	
)
GO

CREATE TABLE LOAI_KHACHHANG (
	MaLoaiKhachHang INT NOT NULL PRIMARY KEY,
	TenLoaiKhachHang NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
)
GO

CREATE TABLE KHACHHANG (
	MaKhachHang INT NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(50) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiKhachHang INT NOT NULL,
	CMND INT,
	DiaChi NVARCHAR(100) DEFAULT N'chua them dia chi',

	FOREIGN KEY (MaLoaiKhachHang) REFERENCES dbo.LOAI_KHACHHANG(MaLoaiKhachHang)
)
GO

CREATE TABLE PHIEUTHUEPHONG (
	MaPT INT NOT NULL PRIMARY KEY,
	MaPhong INT NOT NULL,
	NgayBatDau DATETIME NOT NULL DEFAULT GETDATE(),
	TinhTrangThanhToan INT DEFAULT 0, -- 0: Chưa Thanh Toán || 1: Đã Thanh Toán

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
)
GO

CREATE TABLE CHITIET_PHIEUTHUE (
	MaCTPT INT NOT NULL PRIMARY KEY,
	MaPT INT NOT NULL,
	MaKhachHang INT NOT NULL

	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT),
	FOREIGN KEY (MaKhachHang) REFERENCES dbo.KHACHHANG(MaKhachHang) 
)
GO

CREATE TABLE HOADON (
	MaHD INT NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(50) DEFAULT N'chua ghi ten',
	TriGia FLOAT
)
GO

CREATE TABLE CHITIET_HOADON (
	MaCTHD INT NOT NULL PRIMARY KEY,
	MaHD INT NOT NULL,
	MaPT INT NOT NULL,
	SoNgayThue INT,
	NgayThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
	ThanhTien MONEY,

	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT)
)
GO

CREATE TABLE DOANHTHU (
	MaDT INT NOT NULL PRIMARY KEY,
	Thang INT NOT NULL DEFAULT MONTH(GETDATE()),
	Nam INT NOT NULL DEFAULT YEAR(GETDATE()),
	MaLoaiPhong INT NOT NULL,
	DoanhThu MONEY,
	TyLe FLOAT,

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAI_PHONG(MaLoaiPhong)

)
GO

CREATE TABLE THAMSO (
	TenThamSo NVARCHAR(20),
	GiaTri FLOAT,
	--Các Record THAMSO(TenThamSo, GiaTri)

	----KhachToiDa		:  3
	----PhuThu			:  0.25
	----HeSo			:  1.5
)
GO

INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'KhachToiDa', 3)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'PhuThu', 0.25)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'HeSo', 1.5 )
GO

INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(1,'A', 150000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(2,'B', 170000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(3,'C', 200000)
GO

INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 1,'Nôi địa' )
INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 2,'Nươc ngoài' )
GO

INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(1,'Phòng 1', 1, 'note 1', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(2,'Phòng 2', 2, 'note 2', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(3,'Phòng 3', 1, 'note 3', 2)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(4,'Phòng 4', 3, 'note 4', 1)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE dbo.AddRoomToDataBase
  @RoomCode int,
  @RoomName nvarchar(30)
  ,@RoomStyle int
  ,@RommNote nvarchar(100)

AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

insert into HOTEL_MANAGER.dbo.PHONG (MaPhong,TenPhong,MaLoaiPhong,GhiChu)
values(@RoomCode,@RoomName,@RoomStyle,@RommNote)
  END 
END
GO



CREATE PROCEDURE dbo.UpdateRoomToDataBase
  @RoomCodeNew int,
  @RoomName nvarchar(30)
  ,@RoomStyle int
  ,@RoomNote nvarchar(100),
  @RoomStatus int,
  @RoomCodeOld int
AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

		update HOTEL_MANAGER.dbo.PHONG 
		SET MaPhong = @RoomCodeNew , TenPhong = @RoomName , MaLoaiPhong = @RoomStyle , GhiChu = @RoomNote , TinhTrangPhong = @RoomStatus 
		WHERE MaPhong = @RoomCodeOld 
  END 
END
GO



CREATE PROC sp_CapNhatDonGiaLoaiPhong (@MaLP INT, @Gia MONEY)
AS
BEGIN
	UPDATE dbo.LOAI_PHONG
	SET DonGia=@Gia
	WHERE MaLoaiPhong=@MaLP
END
GO




CREATE PROC sp_ThemMoiLoaiPhong (@MaLP INT, @TenLP NVARCHAR(20), @Gia MONEY)
AS
BEGIN
	
	IF (@TenLP like N'')
	BEGIN
		SET @TenLP = N'Chưa đặt tên'
	END

	INSERT INTO dbo.LOAI_PHONG
	        ( MaLoaiPhong, TenLoaiPhong, DonGia )
	VALUES  ( @MaLP, -- MaLoaiPhong - int
	          @TenLP, -- TenLoaiPhong - nvarchar(30)
	          @Gia  -- DonGia - money
	          )
END
GO

CREATE PROC sp_ThemMoiLoaiKhach(@MaLK INT, @TenLK NVARCHAR(50)) 
AS
BEGIN
	IF (@TenLK like N'')
	BEGIN
		SET @TenLK = N'Chưa đặt tên'
	END

	INSERT INTO dbo.LOAI_KHACHHANG
	        ( MaLoaiKhachHang ,
	          TenLoaiKhachHang
	        )
	VALUES  ( @MaLK , -- MaLoaiKhachHang - int
	          @TenLK  -- TenLoaiKhachHang - nvarchar(30)
	        )
END
GO



CREATE PROC sp_CapNhatKhachToiDa(@Maxx int)
AS
BEGIN
	UPDATE dbo.THAMSO
	SET GiaTri= @Maxx
	WHERE TenThamSo = N'KhachToiDa'
END
GO



CREATE PROC sp_CapNhatPhuThu (@PhuThu float)
AS
BEGIN
	UPDATE dbo.THAMSO
	SET GiaTri=@PhuThu
	WHERE TenThamSo= N'PhuThu'
END
GO

CREATE PROC sp_CapNhatHeSo (@HeSo float)
AS
BEGIN
	UPDATE dbo.THAMSO
	SET GiaTri=@HeSo
	WHERE TenThamSo= N'HeSo'
END
GO

