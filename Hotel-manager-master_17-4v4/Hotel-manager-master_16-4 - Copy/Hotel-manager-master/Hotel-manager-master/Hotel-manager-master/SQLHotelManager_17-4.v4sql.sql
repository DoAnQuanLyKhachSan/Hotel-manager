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

INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(1, N'Có thể cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(2, N'Đang cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(3, N'Đang sửa chữa ')
GO


CREATE TABLE PHONG (
	MaPhong INT NOT NULL PRIMARY KEY,
	TenPhong NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiPhong INT NOT NULL,
	GhiChu NVARCHAR(100) DEFAULT N'chua co ghi chu',
	TinhTrangPhong INT NOT NULL DEFAULT 1,

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
	TongTien MONEY DEFAULT(0),
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
	Thang INT NOT NULL ,
	Nam INT NOT NULL,
	MaLoaiPhong INT NOT NULL, 

	PRIMARY KEY( Thang, Nam, MaLoaiPhong),

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

CREATE TABLE CHUC_NANG (
	MaChucNang int not null primary key,
	TenChucNang NVARCHAR(30) not null,
	TenManHinhDuocLoad NVARCHAR(30) not null
)
GO

<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/SQLHotelManager_17-4.v4sql.sql
=======

insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Tìm phòng',N'fSearch')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thêm phòng',N'fAddRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Sửa phòng',N'fEditRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thuê phòng',N'fRent')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thanh toán',N'fPayInfo')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thống kê',N'fReport')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thay đổi quy định',N'fChangeRegulations')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Về chúng tôi',N'AboutUs')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Quản lý tài khoản',N'fAccountManagement')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Phòng',N'fRoom')


>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/SQLHotelManager_17-4.v4sql.sql
CREATE TABLE NHOM_NGUOI_DUNG (
	 MaNhom int not null primary key,
	 TenNhom NVARCHAR(30) not null,	
)
GO

CREATE TABLE PHAN_QUYEN (
	MaNhom int not null ,
	MaChucNang int not null,
	PRIMARY KEY (MaNhom,MaChucNang),
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom),
	FOREIGN KEY (MaChucNang) REFERENCES dbo.CHUC_NANG(MaChucNang)
)
GO
<<<<<<< HEAD:Hotel-manager-master_17-4v4/Hotel-manager-master_16-4 - Copy/Hotel-manager-master/Hotel-manager-master/Hotel-manager-master/SQLHotelManager_17-4.v4sql.sql
=======
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,1)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,2)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,3)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,4)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,5)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,6)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,7)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,8)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,9)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,10)

insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,10)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,1)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,4)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,5)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,8)
>>>>>>> 79bd8ce4d26160fc385df522e155bfc60d43b97e:Hotel-manager-master/SQLHotelManager_17-4.v4sql.sql

CREATE TABLE NGUOI_DUNG(
	TenDangNhap NVARCHAR(30) not null primary key,
	MatKhau NVARCHAR(30) not null,
	MaNhom int not null,
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom)
)
GO

INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'KhachToiDa', 3)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'SoKhachTinhDonGiaThuong', 2)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'TyLePhuThu', 0.25)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'HeSoPhuThu', 1.5 )
GO


CREATE TRIGGER tg_InsertPhieuThue -- Khi tạo tạo phiếu thuê thành công, Trạng thái phòng tự cập nhật thành 2--đang cho thuê
ON dbo.PHIEUTHUEPHONG
FOR INSERT
AS
BEGIN
	DECLARE @MaPhong INT;
	SELECT @MaPhong=Inserted.MaPhong FROM Inserted

	IF EXISTS  (SELECT * FROM dbo.PHONG WHERE MaPhong=@MaPhong AND TinhTrangPhong = 2 OR TinhTrangPhong =3)
		BEGIN
			PRINT 'Phong nay dang duoc thue hoac dang sua chua'
			ROLLBACK TRANSACTION
		END
	ELSE 
		BEGIN
			UPDATE dbo.PHONG
			SET TinhTrangPhong=2
			WHERE MaPhong=@MaPhong
		END 
END
GO


CREATE TRIGGER tg_CapNhatTinhTrangPhong  ----Khi phiếu thuê phòng đã thanh toán, tự cập nhật TinhTrangPhong =0 -- có thể thuê
ON dbo.PHIEUTHUEPHONG
FOR UPDATE
AS
BEGIN

	DECLARE @TinhTrang INT;
	SELECT @TinhTrang=Inserted.TinhTrangThanhToan FROM Inserted

	IF (@TinhTrang=1)
			BEGIN
				UPDATE dbo.PHONG
				SET TinhTrangPhong = 1
				WHERE MaPhong = (SELECT MaPhong FROM Inserted)
			END
END      
GO



CREATE TRIGGER tg_TuCapNhatKhiThemMoi_CHITIET_HOADON  -- Khi thêm mới ChiTiet_HoaDon, Tự cập nhật:
ON dbo.CHITIET_HOADON					--- số ngày thuê = Ngày bắt đầu - Ngày thanh toán
FOR INSERT					----------Đơn Giá (theo các trường hợp số lượng khách và loại khách)
AS						---------- Thành Tiền = Đơn giá x Số ngày thuê x Số người thuê(tùy theo thứ tự khách và loại khách)
BEGIN				---------- Tổng tiền(trị giá)= Tổng tiền  + Thành Tiền 

	DECLARE @MaHD INT, @MaCTHD INT, @DonGia MONEY, @GiaLoaiPhong MONEY, @Dem INT;
	DECLARE @ThanhTien MONEY, @SoNgayThue INT;
	DECLARE @HeSoPhuThu FLOAT, @TyLePhuThu FLOAT, @TinhGiaThuong INT; 

	SELECT @MaCTHD=MaCTHD, @MaHD=MaHD, @SoNgayThue=SoNgayThue FROM Inserted

	SELECT @GiaLoaiPhong=lp.DonGia FROM Inserted I,dbo.PHIEUTHUEPHONG pt, phong p, dbo.LOAI_PHONG lp
	WHERE I.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong AND p.MaLoaiPhong=lp.MaLoaiPhong

	SELECT @TylePhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'TyLePhuThu'
	SELECT @HeSoPhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'HeSoPhuThu'
	SELECT @TinhGiaThuong=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'SoKhachTinhDonGiaThuong'

	SELECT @SoNgayThue = DATEDIFF(DAY,pt.NgayBatDau,hd.NgayThanhToan) FROM CHITIET_HOADON ctd, HOADON hd ,dbo.PHIEUTHUEPHONG pt
	WHERE hd.MaHD=ctd.MaHD AND ctd.MaCTHD = @MaCTHD


	UPDATE CHITIET_HOADON
	SET SoNgayThue = @SoNgayThue
	WHERE MaCTHD = @MaCTHD

	SELECT @Dem = COUNT(*) FROM Inserted I JOIN dbo.CHITIET_PHIEUTHUE ctt ON ctt.MaPT = I.MaPT
	
	IF @Dem > @TinhGiaThuong
		BEGIN
			SET @DonGia = @GiaLoaiPhong*(1+@TyLePhuThu); 
			SET @Thanhtien = @GiaLoaiPhong * @TinhGiaThuong * @SoNgayThue + @DonGia * (@Dem - @TinhGiaThuong) * @SoNgayThue;
		END
	ELSE 
		BEGIN
			SET @DonGia = @GiaLoaiPhong
			SET @ThanhTien = @DonGia * @Dem * @SoNgayThue;
		END


	IF EXISTS (SELECT * FROM Inserted I, dbo.CHITIET_PHIEUTHUE ctt 
					WHERE I.MaPT=ctt.MaPT AND ctt.MaLoaiKhachHang = 2 )
		BEGIN
			SET @ThanhTien *= @HeSoPhuThu;
		END



    UPDATE CHITIET_HOADON
	SET DonGia=@DonGia, ThanhTien=@ThanhTien
	WHERE MaCTHD=@MaCTHD

	UPDATE HOADON
	SET TongTien+=@ThanhTien
	WHERE MaHD=@MaHD

END
GO


CREATE TRIGGER tg_Insert_DOANHTHU 
ON dbo.DOANHTHU
FOR INSERT
AS
BEGIN
	
	DECLARE @TongDoanhThu MONEY, @DoanhThu MONEY, @MaLoaiPhong INT, @Nam INT, @Thang INT;

	SELECT  @MaLoaiPhong=MaLoaiPhong,@Nam= Nam,@Thang= Thang FROM Inserted

	SELECT @DoanhThu=SUM(ctd.ThanhTien) FROM dbo.HOADON hd, dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt, dbo.PHONG p
	WHERE hd.MaHD=ctd.MaHD AND ctd.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong
		 AND p.MaLoaiPhong=@MaLoaiPhong AND year(hd.NgayThanhToan)=@nam AND MONTH(hd.NgayThanhToan)=@Thang

	SELECT @TongDoanhThu=SUM(TongTien) FROM dbo.HOADON WHERE year(NgayThanhToan)=@nam AND MONTH(NgayThanhToan)=@Thang

	UPDATE dbo.DOANHTHU
	SET DoanhThu=@DoanhThu, TyLe=@DoanhThu/ @TongDoanhThu
	WHERE Nam=@Nam AND Thang = @Thang AND MaLoaiPhong= @MaLoaiPhong
	
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
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(3, N'Phòng 3', 3, N'note 3', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(4, N'Phòng 4', 1, N'note 4', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(5, N'Phòng 5', 2, N'note 4', 1)
GO

--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau) VALUES ( 1 ,'3/21/2018')
--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau) VALUES ( 2 ,'3/23/2018' )
--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,NgayBatDau) VALUES ( 3 ,'3/25/2018' )
--GO


--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 1' ,1 ,1111 ,N'address 1')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 2' ,2 ,2222 ,N'address 2')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 3' ,1 ,3333 ,N'address 3')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 4' ,2 ,4444 ,N'address 4')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 5' ,2 ,5555 ,N'address 5')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 6' ,1 ,6666 ,N'address 1')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 7' ,1 ,7777 ,N'address 3')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 8' ,2 ,8888 ,N'address 2')
--GO


--INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng a' ,'4/8/2018' )
--INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng b' ,'4/12/2018')
--INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng c' ,'4/9/2018')
--INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng d' ,'4/11/2018')
--INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( N'Khách hàng e' ,'4/13/2018')
--GO

--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 1 , 1 )
--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 2 , 3 )
--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 3 , 2 )
--GO


--INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  (  4 ,2018 ,1)
--INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  (  4 ,2018 ,2)
--INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  ( 4 ,2018 ,3)
--GO



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

insert into dbo.PHONG (MaPhong,TenPhong,MaLoaiPhong,GhiChu)
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

		update dbo.PHONG 
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

insert INTO dbo.PHIEUTHUEPHONG(MaPhong,NgayBatDau)
values(@RoomCode,@BeginDay)
  END 
END
GO

CREATE PROCEDURE dbo.CreateTenancyCardDetail
  @TenancyCardCode int,
  @CustomerName nvarchar(50),
  @CustomerStyleCode int,
  @CustomerCMND int,
  @CustomerAddress nvarchar(100) 
AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

insert into dbo.CHITIET_PHIEUTHUE(MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)
values(@TenancyCardCode,@CustomerName,@CustomerStyleCode,@CustomerCMND,@CustomerAddress)
  END 
END
GO

CREATE PROC sp_LayDiaChi (@Name nvarchar(50))
AS
BEGIN 
	SELECT DISTINCT DiaChi FROM dbo.CHITIET_PHIEUTHUE WHERE TenKhachHang=@Name
END
GO


CREATE PROC sp_getListPhongCanThanhToan
AS
BEGIN
	SELECT MaPhong FROM dbo.PHIEUTHUEPHONG WHERE TinhTrangThanhToan = 0
END
GO


CREATE PROC sp_getListKhachCanThanhToan
AS
BEGIN
	SELECT DISTINCT TenKhachHang FROM dbo.PHIEUTHUEPHONG JOIN dbo.CHITIET_PHIEUTHUE ON CHITIET_PHIEUTHUE.MaPT = PHIEUTHUEPHONG.MaPT
	WHERE TinhTrangThanhToan = 0
END
GO





CREATE PROC sp_getPhongThanhToan(@MaPhong int)
AS
BEGIN
	SELECT MaPhong,NgayBatDau,TinhTrangThanhToan FROM dbo.PHIEUTHUEPHONG WHERE MaPhong=@MaPhong AND TinhTrangThanhToan = 0
END
GO



CREATE PROC sp_getKhachHangThanhToan(@TenKH NVARCHAR(50))
AS
BEGIN
	SELECT MaCTPT,TenKhachHang,MaPhong,NgayBatDau
	FROM dbo.PHIEUTHUEPHONG JOIN dbo.CHITIET_PHIEUTHUE ON CHITIET_PHIEUTHUE.MaPT = PHIEUTHUEPHONG.MaPT
	WHERE TinhTrangThanhToan = 0 AND  TenKhachHang= @TenKH
END
GO


CREATE PROC sp_ChiTietThanhToanTheoPhong(@MaPhong INT)
AS
BEGIN
	select pt.MaPhong,ctt.TenKhachHang, ctd.SoNgayThue,ctd.DonGia,ctd.ThanhTien
	FROM dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt, dbo.CHITIET_PHIEUTHUE ctt
	WHERE ctd.MaPT=pt.MaPT AND pt.MaPT=ctt.MaPT AND pt.TinhTrangThanhToan=0 AND pt.MaPhong= @MaPhong
END
GO


CREATE PROC sp_ChiTietThanhToanTheoTenKhach(@TenKH NVARCHAR(50))
AS
BEGIN
	SELECT pt.MaPhong,ctt.TenKhachHang,ctd.SoNgayThue,ctd.DonGia,ctd.ThanhTien
	FROM dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt, dbo.CHITIET_PHIEUTHUE ctt
	WHERE ctd.MaPT=pt.MaPT AND pt.MaPT=ctt.MaPT AND pt.TinhTrangThanhToan=0 AND ctt.TenKhachHang= @TenKH

END
GO

CREATE PROC sp_getTongTien(@MaPhong int)
AS 
BEGIN
	
	SELECT DISTINCT ctd.ThanhTien FROM dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt
	WHERE  ctd.MaPT=pt.MaPT AND pt.MaPhong= @MaPhong

END
GO


CREATE PROC sp_ThemHoaDon(@TenKH NVARCHAR(50), @Ngay DATETIME)
AS
BEGIN

	INSERT INTO dbo.HOADON( TenKhachHang,NgayThanhToan) VALUES ( @TenKH, @Ngay )

END
GO




CREATE PROC sp_ThemChiTietHoaDonTheoPhong(@MaPhong INT)
AS
BEGIN

	DECLARE @MaPT INT, @MaHD INT 
	SELECT @MaPT=MaPT FROM dbo.PHIEUTHUEPHONG WHERE TinhTrangThanhToan = 0 and MaPhong = @MaPhong
	SELECT @MaHD=MAX(MaHD) FROM dbo.HOADON

	INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( @MaHD , @MaPT )

END
GO


CREATE PROC sp_ThemChiTietHoaDonTenKhach (@TenKH NVARCHAR(50))
AS
BEGIN

	DECLARE @MaPT INT, @MaHD INT 

	SELECT @MaPT=pt.MaPT FROM dbo.PHIEUTHUEPHONG pt, dbo.CHITIET_PHIEUTHUE ctt
	WHERE pt.MaPT=ctt.MaCTPT AND pt.TinhTrangThanhToan=0  AND ctt.TenKhachHang =@TenKH

	SELECT @MaHD= MAX(MaHD) FROM dbo.HOADON

	INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( @MaHD , @MaPT )

END
GO


CREATE PROC sp_CapNhatTinhTrangThanhToan(@MaPhong int)
AS
BEGIN
	UPDATE dbo.PHIEUTHUEPHONG
	SET TinhTrangThanhToan = 1
	WHERE MaPhong=@MaPhong AND TinhTrangThanhToan=0
END
GO


CREATE PROC sp_InsertIntoDoanhThu(@month INT, @year INT )
AS
BEGIN
	DECLARE MaLoaiPhong_Cursor CURSOR FOR SELECT MaLoaiPhong FROM dbo.LOAI_PHONG

	OPEN MaLoaiPhong_Cursor

	DECLARE @MaLoaiPhong INT
	FETCH NEXT FROM MaLoaiPhong_Cursor INTO @MaLoaiPhong

	WHILE @@FETCH_STATUS = 0
		BEGIN

			INSERT INTO dbo.DOANHTHU ( Thang,Nam,MaLoaiPhong)VALUES  (  @month ,@year , @MaLoaiPhong)
			FETCH NEXT FROM MaLoaiPhong_Cursor INTO @MaLoaiPhong

		END
    
	
	CLOSE MaLoaiPhong_Cursor
	DEALLOCATE MaLoaiPhong_Cursor

END
GO


