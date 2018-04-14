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

CREATE TABLE TINH_TRANG_PHONG (
	MaTinhTrang INT NOT NULL PRIMARY KEY ,
	TenTinhTrang NVARCHAR(50) NOT NULL
)
GO

INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(1, N'Đang cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(2, N'Có thể cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(3, N'Đang sửa chữa ')
GO


CREATE TABLE PHONG (
	MaPhong INT NOT NULL PRIMARY KEY,
	TenPhong NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiPhong INT NOT NULL,
	GhiChu NVARCHAR(100) DEFAULT N'chua co ghi chu',
	TinhTrangPhong INT NOT NULL DEFAULT 1, -- 1: Có thể cho thuê || 0: Có ng thuê, đang sửa chữa

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAI_PHONG(MaLoaiPhong),
	FOREIGN KEY (TinhTrangPhong) REFERENCES dbo.TINH_TRANG_PHONG(MaTinhTrang)
	
)
GO

CREATE TABLE LOAI_KHACHHANG (
	MaLoaiKhachHang INT NOT NULL PRIMARY KEY,
	TenLoaiKhachHang NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
)
GO


CREATE TABLE PHIEUTHUEPHONG (
	MaPT INT identity NOT NULL PRIMARY KEY,
	MaPhong INT NOT NULL,
	NgayBatDau DATETIME NOT NULL DEFAULT GETDATE(),
	TinhTrangThanhToan INT DEFAULT 0, -- 0: Chưa Thanh Toán || 1: Đã Thanh Toán

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
)
GO

CREATE TABLE CHITIET_PHIEUTHUE (
	MaCTPT INT IDentity NOT NULL PRIMARY KEY,
	MaPT INT NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiKhachHang INT NOT NULL,
	CMND INT,
	DiaChi NVARCHAR(100) DEFAULT N'chua them dia chi',

	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT),
	FOREIGN KEY (MaLoaiKhachHang) REFERENCES dbo.LOAI_KHACHHANG(MaLoaiKhachHang)
)
GO

CREATE TABLE HOADON (
	MaHD INT identity NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(50) DEFAULT N'chua ghi ten',
	NgayThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
	TongTien MONEY DEFAULT(0)
)
GO

CREATE TABLE CHITIET_HOADON (
	MaCTHD INT identity NOT NULL PRIMARY KEY,
	MaHD INT NOT NULL,
	MaPT INT NOT NULL,
	SoNgayThue INT,
	DonGia MONEY,
	ThanhTien MONEY,

	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT)
)
GO

CREATE TABLE DOANHTHU (
	MaDT INT identity NOT NULL PRIMARY KEY,
	Thang INT NOT NULL DEFAULT MONTH(GETDATE()),
	Nam INT NOT NULL DEFAULT YEAR(GETDATE()),
	MaLoaiPhong INT NOT NULL,
	DoanhThu MONEY,
	TyLe FLOAT,

	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAI_PHONG(MaLoaiPhong)

)
GO

CREATE TABLE THAMSO (
	TenThamSo NVARCHAR(30) NOT NULL PRIMARY KEY,
	GiaTri FLOAT NOT NULL
	--Các Record THAMSO(TenThamSo, GiaTri)

	----KhachToiDa					:	3
	----SoKhachTinhDonGiaThuong		:	2
	----TyLePhuThu					:	0.25
	----HeSoPhuThu					:	1.5
)
GO

INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'KhachToiDa', 3)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'SoKhachTinhDonGiaThuong', 2)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'TyLePhuThu', 0.25)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'HeSoPhuThu', 1.5 )
GO


CREATE TRIGGER tg_Insert_CHITIET_HOADON
ON dbo.CHITIET_HOADON
FOR INSERT
AS
BEGIN

	DECLARE @DonGia MONEY, @n INT=0, @MaCTHD INT, @MaHD int,@HeSoPhuThu FLOAT, @TyLePhuThu FLOAT=1, @Tyle FLOAT;

	SELECT @MaCTHD=Inserted.MaCTHD, @MaHD=Inserted.MaHD FROM Inserted

	SELECT @DonGia=lp.DonGia FROM Inserted I,dbo.PHIEUTHUEPHONG pt, phong p, dbo.LOAI_PHONG lp
	WHERE I.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong AND p.MaLoaiPhong=lp.MaLoaiPhong

	SELECT @Tyle=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'TyLePhuThu'
	SELECT @HeSoPhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'HeSoPhuThu'

	SELECT @n=COUNT(*) FROM Inserted I JOIN dbo.CHITIET_PHIEUTHUE ctt ON ctt.MaPT = I.MaPT
	IF(@n>=1 AND (NOT EXISTS (SELECT * FROM Inserted I JOIN dbo.HOADON hd ON hd.MaHD = I.MaHD WHERE hd.TenKhachHang IN (SELECT TOP 2 TenKhachHang FROM dbo.CHITIET_PHIEUTHUE WHERE I.MaPT=MaPT ORDER BY MaCTPT) ) ))	
		BEGIN
			SET @TyLePhuThu+=@Tyle;
		END 

	UPDATE dbo.CHITIET_HOADON
	SET DonGia=@DonGia*@TyLePhuThu
	WHERE MaCTHD=@MaCTHD
	
	IF EXISTS (SELECT * FROM Inserted I JOIN dbo.CHITIET_PHIEUTHUE ctt ON I.MaPT=ctt.MaPT WHERE ctt.MaLoaiKhachHang=2)
		BEGIN
			UPDATE dbo.CHITIET_HOADON
			SET DonGia*=@HeSoPhuThu
			WHERE MaCTHD=@MaCTHD
		END

	DECLARE @ThanhTien MONEY;
	SELECT @ThanhTien=DonGia*SoNgayThue FROM dbo.CHITIET_HOADON WHERE MaCTHD=@MaCTHD
	
	UPDATE dbo.CHITIET_HOADON
	SET ThanhTien=@ThanhTien
	WHERE MaCTHD=@MaCTHD

	UPDATE dbo.HOADON
	SET TongTien+=@ThanhTien
	WHERE MaHD=@MaHD

END
GO

CREATE TRIGGER tg_Insert_DOANHTHU
ON dbo.DOANHTHU
FOR INSERT
AS
BEGIN
	
	DECLARE @MaDT INT, @TongDoanhThu MONEY, @DoanhThu MONEY, @MaLoaiPhong INT, @Nam INT, @Thang INT;

	SELECT @MaDT=Inserted.MaDT, @MaLoaiPhong=Inserted.MaLoaiPhong,@Nam=Inserted.Nam,@Thang=Inserted.Thang FROM Inserted

	SELECT @DoanhThu=SUM(ctd.ThanhTien) FROM dbo.HOADON hd, dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt, dbo.PHONG p
	WHERE hd.MaHD=ctd.MaHD AND ctd.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong
		 AND p.MaLoaiPhong=@MaLoaiPhong AND year(hd.NgayThanhToan)=@nam AND MONTH(hd.NgayThanhToan)=@Thang

	SELECT @TongDoanhThu=SUM(TongTien) FROM dbo.HOADON WHERE year(NgayThanhToan)=@nam AND MONTH(NgayThanhToan)=@Thang

	UPDATE dbo.DOANHTHU
	SET DoanhThu=@DoanhThu, TyLe=@DoanhThu/ @TongDoanhThu
	WHERE MaDT=@MaDT
	
END
GO


INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(1,'A', 150000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(2,'B', 170000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(3,'C', 200000)
GO

INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 1, N'Nội địa' )
INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 2, N'Nước ngoài' )
GO

INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(1, N'Phòng 1', 1, N'note 1', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(2, N'Phòng 2', 2, N'note 2', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(3, N'Phòng 3', 3, N'note 3', 2)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(4, N'Phòng 4', 1, N'note 4', 1)
GO

INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau,TinhTrangThanhToan) VALUES ( 1 ,'3/21/2018',0 )
INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau,TinhTrangThanhToan) VALUES ( 2 ,'3/23/2018',0 )
INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau,TinhTrangThanhToan) VALUES ( 3 ,'3/25/2018',0 )
GO

INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 1' ,1 ,1111 ,N'address 1')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 2' ,2 ,2222 ,N'address 2')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 3' ,1 ,3333 ,N'address 3')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 4' ,2 ,4444 ,N'address 4')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 5' ,2 ,5555 ,N'address 5')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 1' ,1 ,1111 ,N'address 1')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 3' ,1 ,3333 ,N'address 3')
INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 2' ,2 ,2222 ,N'address 2')
GO

INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng 1' ,'4/8/2018' )
INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng 2' ,'4/12/2018')
INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng 3' ,'4/9/2018')
INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng 4' ,'4/11/2018')
INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng 5' ,'4/13/2018')
GO

INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  (1 , 1 ,9)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 1 , 2 ,5)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 2 , 1 ,11)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 2 , 3 ,7)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 3 , 2 ,8)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 3 , 1 ,6)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 4 , 3 ,9)
INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT,SoNgayThue)VALUES  ( 5 , 3 ,10)
GO

INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  (  4 ,2018 ,1)
INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  (  4 ,2018 ,2)
INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  ( 4 ,2018 ,3)
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



CREATE PROC sp_CapNhatTyLePhuThu (@TyLe float)
AS
BEGIN
	UPDATE dbo.THAMSO
	SET GiaTri=@TyLe
	WHERE TenThamSo= N'TyLePhuThu'
END
GO

CREATE PROC sp_CapNhatHeSoPhuThu (@HeSo float)
AS
BEGIN
	UPDATE dbo.THAMSO
	SET GiaTri=@HeSo
	WHERE TenThamSo= N'HeSoPhuThu'
END
GO


CREATE PROCEDURE dbo.CreateTenancyCard
  @RoomCode int,
  @BeginDay datetime
AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

insert into HOTEL_MANAGER.dbo.PHIEUTHUEPHONG(MaPhong,NgayBatDau)
values(@RoomCode,@BeginDay)
  END 
END
GO



