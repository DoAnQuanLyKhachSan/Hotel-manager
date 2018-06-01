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

CREATE TABLE HINHTHUCTHUE(
	MaHinhThucThue INT IDENTITY NOT NULL PRIMARY KEY,
	TenHinhThucThue NVARCHAR(40) NOT NULL,
	SoGio INT NOT NULL,
	TyLeDonGia FLOAT NOT NULL
)
GO

INSERT INTO dbo.HINHTHUCTHUE( TenHinhThucThue, SoGio, TyLeDonGia )VALUES  (  N'Thuê Theo Ngày', 24, 1.0)
INSERT INTO dbo.HINHTHUCTHUE(  TenHinhThucThue, SoGio, TyLeDonGia )VALUES  (  N'Thuê Theo Giờ', 1, 0.3)
GO


CREATE TABLE PHONG_BAN(
	MaPhongBan INT identity NOT NULL PRIMARY KEY,
	TenPhongBan NVARCHAR(50),
	MaPhong INT ,

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG (MaPhong)
)
GO


CREATE TABLE CHUC_VU (
	MaChucVu INT identity NOT NULL PRIMARY KEY,
	TenChucVu NVARCHAR(50),
	HeSoPhuCap INT ,
)
GO
insert into dbo.CHUC_VU(TenChucVu,HeSoPhuCap) values (N'Nhân viên thử việc',0)

GO

CREATE TABLE BAC_LUONG(
	MaBacLuong INT identity NOT NULL PRIMARY KEY,
	HeSo INT 
)
GO
insert into dbo.BAC_LUONG(HeSo) values (0.5)
GO


CREATE TABLE NHAN_VIEN(
	MaNV INT identity NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh DATETIME, 
	NgayKyHopDong DATETIME,
	SoHopDong  INT ,
	MaBacLuong INT,
	MaPhongBan INT ,
	MaChucVu INT, 

	FOREIGN KEY (MaBacLuong) REFERENCES dbo.BAC_LUONG(MaBacLuong),
	FOREIGN KEY (MaPhongBan) REFERENCES dbo.PHONG_BAN (MaPhongBan),
	FOREIGN KEY (MaChucVu) REFERENCES dbo.CHUC_VU (MaChucVu)

)
GO




CREATE TABLE PHIEUTHUEPHONG (
	MaPT INT identity NOT NULL PRIMARY KEY,
	MaPhong INT NOT NULL,
	MaHinhThucThue INT ,
	NgayGioBatDauThue DATETIME NOT NULL,
	SoKhach INT,
	TinhTrangThanhToan INT DEFAULT 0, -- 0: Chưa Thanh Toán || 1: Đã Thanh Toán

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
	FOREIGN KEY (MaHinhThucThue) REFERENCES dbo.HINHTHUCTHUE(MaHinhThucThue)
)
GO


CREATE TABLE CHITIET_PHIEUTHUE (
	MaPT INT NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiKhachHang INT NOT NULL,
	CMND INT,
	DiaChi NVARCHAR(100) DEFAULT N'chua them dia chi',

	PRIMARY KEY (MaPT, TenKhachHang),
	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT),
	FOREIGN KEY (MaLoaiKhachHang) REFERENCES dbo.LOAI_KHACHHANG(MaLoaiKhachHang)
)
GO

CREATE TABLE DICHVU(
	MaDV INT IDENTITY PRIMARY KEY,
	TenDV NVARCHAR(50),
	DonGia MONEY
)
GO

INSERT INTO dbo.DICHVU( TenDV, DonGia ) VALUES  ( N'Giặt đồ', 20000)
INSERT INTO dbo.DICHVU( TenDV, DonGia ) VALUES  ( N'Quét dọn phòng', 30000)
INSERT INTO dbo.DICHVU( TenDV, DonGia ) VALUES  ( N'Thuê Osin', 50000)
GO


CREATE TABLE CHITIET_SUDUNGDV(
	MaPT INT NOT NULL,
	MaDV INT NOT NULL,
	KhachHangSD NVARCHAR(50) NOT NULL,
	NgayGioSD DATETIME DEFAULT GETDATE(),
	SoLuong INT,
	ThanhTien MONEY DEFAULT(0),

	PRIMARY KEY(MaPT, MaDV, KhachHangSD, NgayGioSD),
	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT),
	FOREIGN KEY (MaDV) REFERENCES dbo.DICHVU(MaDV),
)
GO




CREATE TABLE HOADON (
	MaHD INT identity NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(50) DEFAULT N'chua ghi ten',
	NgayGioThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
	TongTien MONEY DEFAULT(0),
)
GO

CREATE TABLE CHITIET_HOADON (
	MaHD INT NOT NULL,
	MaPT INT NOT NULL,
	SoLuongThue INT,
	DonGia MONEY,
	TongTienThuePhong MONEY,
	TongTienDichVu MONEY,
	ThanhTien MONEY ,

	PRIMARY KEY (MaHD, MaPT),
	FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
	FOREIGN KEY (MaPT) REFERENCES dbo.PHIEUTHUEPHONG(MaPT)
)
GO

CREATE TABLE BAOCAO_DOANHTHU (
	Thang INT NOT NULL ,
	Nam INT NOT NULL,
	TongDoanhThu MONEY,

	PRIMARY KEY(Thang, Nam) 

)
GO 

CREATE TABLE CHITIET_BAOCAO_DOANHTHU (
	Thang INT NOT NULL ,
	Nam INT NOT NULL,
	MaLoaiPhong INT NOT NULL, 

	PRIMARY KEY( Thang, Nam, MaLoaiPhong),

	DoanhThu MONEY DEFAULT(0),
	TyLe FLOAT,

	FOREIGN KEY (Thang,Nam) REFERENCES dbo.BAOCAO_DOANHTHU(Thang,Nam),
	FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAI_PHONG(MaLoaiPhong)

)
GO

CREATE TABLE THAMSO (
	TenThamSo NVARCHAR(30) NOT NULL PRIMARY KEY,
	GiaTri FLOAT NOT NULL
	--Các Record THAMSO(TenThamSo, GiaTri)

	----KhachToiDa					:	3
	----SoKhachKhongTinhPhuThu		:	2
	----TyLePhuThu					:	0.25
	----HeSoPhuThu					:	1.5
	----LuongCoBan					:	5000000
)
GO

INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'KhachToiDa', 3)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'SoKhachKhongTinhPhuThu', 2)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'TyLePhuThu', 0.25)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'HeSoPhuThu', 1.5 )
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'LuongCoBan', 5000000 )
GO

CREATE TABLE CHUC_NANG (
	MaChucNang int identity not null primary key,
	TenChucNang NVARCHAR(30) not null,
	TenManHinhDuocLoad NVARCHAR(30) not null
)
GO

insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Phòng',N'fRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Tìm phòng',N'fSearch')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thêm phòng',N'fAddRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Xóa phòng',N'fDeleteRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Sửa phòng',N'fEditRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thuê phòng',N'fRent')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thanh toán',N'fPayInfo')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Dịch vụ',N'fService')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thống kê',N'fReport')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thay đổi quy định',N'fChangeRegulations')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Nhân viên',N'fStaff')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Về chúng tôi',N'AboutUs')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Quản lý tài khoản',N'fAccountManagement')




CREATE TABLE NHOM_NGUOI_DUNG (
	 MaNhom int not null primary key,
	 TenNhom NVARCHAR(30) not null,	
)
GO
insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(1,N'Admin')
insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(2,N'staff')

CREATE TABLE PHAN_QUYEN (
	MaNhom int not null ,
	MaChucNang int not null,
	PRIMARY KEY (MaNhom,MaChucNang),
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom),
	FOREIGN KEY (MaChucNang) REFERENCES dbo.CHUC_NANG(MaChucNang)
)
GO
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
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,11)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,12)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(1,13)

insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,10)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,1)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,4)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,5)
insert into dbo.PHAN_QUYEN(MaNhom,MaChucNang) values(2,8)

CREATE TABLE NGUOI_DUNG(
	TenDangNhap NVARCHAR(30) not null primary key,
	MatKhau NVARCHAR(30) not null,
	MaNhom int not null,
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom)
)
GO
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau,MaNhom) values('admin','admin',1)
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau,MaNhom) values('staff1','staff1',2)
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
ON dbo.CHITIET_HOADON					--- SoLuongThue = (tùy trường hợp thuê theo ngày hay thuê theo giờ --- sử dụng hàm DateDiff( ngày hoặc giờ ) )
FOR INSERT					----------Đơn Giá (theo các trường hợp số lượng khách và loại khách)
AS						 ---------- Tổng tiền thuê phòng = Đơn giá x SoLuongThue
					   ------------Tổng tiền dịch vụ = tổng của các thành tiền trong bảng ChiTiet_SuDung_DV có trùng MaPT
					  ------------Tổng tiền = Tổng tiền thuê phòng + Tổng tiền dịch vụ
BEGIN				---------- Tổng tiền(trị giá bên table HOADON)= Tổng tiền(HOADON) + Tổng tiền(ChiTiet_HOADON)

	DECLARE @MaHD INT, @MaPT INT, @DonGia MONEY, @GiaLoaiPhong MONEY, @SoKhach INT;
	DECLARE @TongTienPhong MONEY, @SoLuongThue INT, @MaHinhThucThue INT, @TyLeDonGia FLOAT;
	DECLARE @HeSoPhuThu FLOAT, @TyLePhuThu FLOAT, @KhachKhongPhuThu INT; 

	SELECT @MaPT=MaPT, @MaHD=MaHD  FROM Inserted

	SELECT @GiaLoaiPhong=lp.DonGia, @MaHinhThucThue=MaHinhThucThue, @SoKhach=SoKhach FROM Inserted I,dbo.PHIEUTHUEPHONG pt, phong p, dbo.LOAI_PHONG lp
	WHERE I.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong AND p.MaLoaiPhong=lp.MaLoaiPhong

	SELECT @TylePhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'TyLePhuThu'
	SELECT @HeSoPhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'HeSoPhuThu'
	SELECT @KhachKhongPhuThu=GiaTri FROM dbo.THAMSO WHERE TenThamSo=N'SoKhachKhongTinhPhuThu'

	IF (@MaHinhThucThue = 1)
		BEGIN
			SELECT @SoLuongThue = DATEDIFF(DAY,pt.NgayGioBatDauThue,hd.NgayGioThanhToan) FROM CHITIET_HOADON ctd, HOADON hd ,dbo.PHIEUTHUEPHONG pt
			WHERE hd.MaHD=ctd.MaHD AND ctd.MaPT=pt.MaPT and pt.MaPT=@MaPT

			SELECT @TyLeDonGia =TyLeDonGia FROM dbo.HINHTHUCTHUE WHERE MaHinhThucThue=1		
		END 

	IF (@MaHinhThucThue = 2)
		BEGIN
			SELECT @SoLuongThue = DATEDIFF(hour,pt.NgayGioBatDauThue,hd.NgayGioThanhToan) FROM CHITIET_HOADON ctd, HOADON hd ,dbo.PHIEUTHUEPHONG pt
			WHERE hd.MaHD=ctd.MaHD AND ctd.MaPT=pt.MaPT and pt.MaPT=@MaPT

			SELECT @TyLeDonGia =TyLeDonGia FROM dbo.HINHTHUCTHUE WHERE MaHinhThucThue=2		
		END 

	UPDATE CHITIET_HOADON
	SET SoLuongThue = @SoLuongThue
	WHERE MaPT=@MaPT
	
	SET @GiaLoaiPhong *= @TyLeDonGia;

	IF @SoKhach > @KhachKhongPhuThu
		BEGIN
			SET @DonGia = @GiaLoaiPhong + @GiaLoaiPhong* @TyLePhuThu * (@SoKhach - @KhachKhongPhuThu) ;
		END
	
	ELSE 
		BEGIN
			SET @DonGia = @GiaLoaiPhong
		END

	IF EXISTS (SELECT * FROM Inserted I, dbo.CHITIET_PHIEUTHUE ctt WHERE I.MaPT=ctt.MaPT AND ctt.MaLoaiKhachHang = 2 )
			BEGIN
					SET @DonGia *= @HeSoPhuThu;
			END
			 
	SET @TongTienPhong = @DonGia * @SoLuongThue


	DECLARE @TongTienDichVu MONEY
	SELECT @TongTienDichVu=SUM(ThanhTien) FROM dbo.CHITIET_SUDUNGDV WHERE MaPT=@MaPT
	IF (@TongTienDichVu is null)
		set @TongTienDichVu = 0


    UPDATE CHITIET_HOADON
	SET DonGia=@DonGia, TongTienThuePhong=@TongTienPhong, TongTienDichVu=@TongTienDichVu ,ThanhTien = @TongTienPhong+@TongTienDichVu
	WHERE MaPT=@MaPT

	UPDATE HOADON
	SET TongTien+=@TongTienPhong+@TongTienDichVu
	WHERE MaHD=@MaHD

END
GO

CREATE TRIGGER tg_TuCapNhatKhiCoSuDungDichVu
ON dbo.CHITIET_SUDUNGDV
FOR INSERT
AS
BEGIN
	
	DECLARE @MaPT INT, @MaDV INT, @KhachHangSD NVARCHAR(50), @NgayGioSD DATETIME, @SoLuong INT, @DonGia MONEY
	SELECT @MaPT=MaPT, @MaDV=MaDV, @KhachHangSD=KhachHangSD, @NgayGioSD=NgayGioSD, @SoLuong=SoLuong FROM Inserted
	SELECT @DonGia=DonGia  FROM dbo.DICHVU WHERE MaDV=@MaDV

	UPDATE dbo.CHITIET_SUDUNGDV
	SET ThanhTien= @DonGia * @SoLuong
	WHERE MaPT=@MaPT AND MaDV=@MaDV AND KhachHangSD=@KhachHangSD AND NgayGioSD=@NgayGioSD

END
GO


CREATE TRIGGER tg_ThemMoiBaoCaoDoanhThu
ON dbo.BAOCAO_DOANHTHU
FOR INSERT
AS
BEGIN

	DECLARE @TongDoanhThu MONEY, @Nam INT, @Thang INT;

	SELECT  @Nam= Nam,@Thang= Thang FROM Inserted
	SELECT @TongDoanhThu=SUM(TongTien) FROM dbo.HOADON WHERE year(NgayGioThanhToan)=@nam AND MONTH(NgayGioThanhToan)=@Thang

	UPDATE dbo.BAOCAO_DOANHTHU
	SET TongDoanhThu = @TongDoanhThu
	WHERE Nam=@nam AND Thang=@Thang

END 
GO


CREATE TRIGGER tg_ThemMoiChiTietBaoCaoDoanhThu 
ON dbo.CHITIET_BAOCAO_DOANHTHU
FOR INSERT
AS
BEGIN
	
	DECLARE @TongDoanhThu MONEY, @DoanhThu MONEY, @MaLoaiPhong INT, @Nam INT, @Thang INT;

	SELECT  @MaLoaiPhong=MaLoaiPhong,@Nam= Nam,@Thang= Thang FROM Inserted

	SELECT @DoanhThu=SUM(ctd.ThanhTien) FROM dbo.HOADON hd, dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt, dbo.PHONG p
	WHERE hd.MaHD=ctd.MaHD AND ctd.MaPT=pt.MaPT AND pt.MaPhong=p.MaPhong
		 AND p.MaLoaiPhong=@MaLoaiPhong AND year(hd.NgayGioThanhToan)=@nam AND MONTH(hd.NgayGioThanhToan)=@Thang

	SELECT @TongDoanhThu=SUM(TongTien) FROM dbo.HOADON WHERE year(NgayGioThanhToan)=@nam AND MONTH(NgayGioThanhToan)=@Thang

	UPDATE dbo.CHITIET_BAOCAO_DOANHTHU
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

insert into dbo.PHONG_BAN(TenPhongBan,MaPhong) values(N'Phòng Nhân sự',1)
GO

INSERT INTO dbo.NHAN_VIEN( HoTen,NgaySinh,NgayKyHopDong,SoHopDong,MaBacLuong,MaPhongBan,MaChucVu )VALUES  (N'DuyAnhStaff','09/22/1998','04/20/2018',1,1,1,1)
GO

--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,MaHinhThucThue, NgayGioBatDauThue,SoKhach) VALUES ( 1 , 1 ,'3/23/2018 1:1:1', 3)
--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,MaHinhThucThue, NgayGioBatDauThue,SoKhach) VALUES ( 2 , 2 ,'3/23/2018 1:1:1', 2)
--INSERT INTO dbo.PHIEUTHUEPHONG( MaPhong,MaHinhThucThue, NgayGioBatDauThue,SoKhach) VALUES ( 3 , 1 ,'3/23/2018 1:1:1', 3)
--GO


--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 1' ,1 ,1111 ,N'address 1')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 2' ,2 ,2222 ,N'address 2')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 1 ,N'Khách hàng 3' ,1 ,3333 ,N'address 3')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 4' ,2 ,4444 ,N'address 4')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 5' ,2 ,5555 ,N'address 5')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT,TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 6' ,1 ,6666 ,N'address 1')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 2 ,N'Khách hàng 7' ,1 ,7777 ,N'address 3')
--INSERT INTO dbo.CHITIET_PHIEUTHUE( MaPT, TenKhachHang,MaLoaiKhachHang,CMND,DiaChi)VALUES ( 3 ,N'Khách hàng 8' ,2 ,8888 ,N'address 2')
--GO

--INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV , KhachHangSD ,NgayGioSD ,SoLuong )VALUES  ( 1 ,1 ,N'Khách hàng 1' ,GETDATE() ,1 )
--INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV , KhachHangSD ,NgayGioSD ,SoLuong )VALUES  ( 1 ,2 ,N'Khách hàng 2' ,GETDATE() ,2 )
--INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV , KhachHangSD ,NgayGioSD ,SoLuong )VALUES  ( 2 ,3 ,N'Khách hàng 7' ,GETDATE() ,3 )
--INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV , KhachHangSD ,NgayGioSD ,SoLuong )VALUES  ( 3 ,2 ,N'Khách hàng 5' ,GETDATE() ,2 )
--INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV , KhachHangSD ,NgayGioSD ,SoLuong )VALUES  ( 3 ,1 ,N'Khách hàng 8' ,GETDATE() ,1 )
--GO


--INSERT INTO dbo.HOADON( TenKhachHang,NgayGioThanhToan) VALUES ( N'Khách hàng a' ,'4/20/2018 5:5:5' )
--INSERT INTO dbo.HOADON( TenKhachHang,NgayGioThanhToan) VALUES ( N'Khách hàng b' ,'3/23/2018 5:5:5' )
--INSERT INTO dbo.HOADON( TenKhachHang,NgayGioThanhToan) VALUES ( N'Khách hàng c' ,'4/24/2018 5:5:5' )
--GO

--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 1 , 1 )
--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 2 , 2 )
--INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( 3 , 3 )
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



CREATE PROC sp_ThemChiTiet_SuDungDV(@MaPT INT, @MaDV INT, @TenKH NVARCHAR(50), @NgayGio DATETIME, @SoLuong int)
AS
BEGIN
	INSERT INTO dbo.CHITIET_SUDUNGDV( MaPT, MaDV, KhachHangSD, NgayGioSD, SoLuong) 
							VALUES  ( @MaPT ,@MaDV , @TenKH ,@NgayGio ,@SoLuong)
END
GO
 

CREATE PROC sp_ThemHoaDon(@TenKH NVARCHAR(50), @Ngay DATETIME)
AS
BEGIN

	INSERT INTO dbo.HOADON( TenKhachHang,NgayGioThanhToan) VALUES ( @TenKH, @Ngay )

END
GO


CREATE PROC sp_ThemChiTietHoaDonTheoMaPT(@MaPT INT)
AS
BEGIN

	DECLARE @MaHD INT 
	SELECT @MaHD=MAX(MaHD) FROM dbo.HOADON

	INSERT INTO dbo.CHITIET_HOADON( MaHD,MaPT ) VALUES  ( @MaHD , @MaPT )

END
GO

CREATE PROC sp_Load_ChiTietThanhToanTheoMaPT(@MaPT INT)
AS
BEGIN
	SELECT ctd.MaPT, pt.MaPhong, ctd.SoLuongThue,ctd.DonGia,ctd.TongTienThuePhong, ctd.TongTienDichVu, ctd.ThanhTien
	FROM dbo.CHITIET_HOADON ctd, dbo.PHIEUTHUEPHONG pt
	WHERE ctd.MaPT=pt.MaPT AND pt.MaPT= @MaPT
END
GO


CREATE PROC sp_CapNhatTinhTrangThanhToan(@MaPT int)
AS
BEGIN
	UPDATE dbo.PHIEUTHUEPHONG
	SET TinhTrangThanhToan = 1
	WHERE MaPT=@MaPT
END
GO



CREATE PROC sp_AUTO_InsertInto_ChiTietBaoCaoDoanhThu(@month INT, @year INT )
AS
BEGIN

	INSERT INTO dbo.BAOCAO_DOANHTHU( Thang, Nam )VALUES  ( @month, @year )
	
	DECLARE MaLoaiPhong_Cursor CURSOR FOR SELECT MaLoaiPhong FROM dbo.LOAI_PHONG

	OPEN MaLoaiPhong_Cursor

	DECLARE @MaLoaiPhong INT
	FETCH NEXT FROM MaLoaiPhong_Cursor INTO @MaLoaiPhong

	WHILE @@FETCH_STATUS = 0
		BEGIN
			
			INSERT INTO dbo.CHITIET_BAOCAO_DOANHTHU( Thang ,Nam ,MaLoaiPhong ) VALUES (@month, @year, @MaLoaiPhong)
			FETCH NEXT FROM MaLoaiPhong_Cursor INTO @MaLoaiPhong

		END
	
	CLOSE MaLoaiPhong_Cursor
	DEALLOCATE MaLoaiPhong_Cursor

END
GO

CREATE PROC sp_XemBaoCaoThang(@month INT, @year int)
AS
BEGIN
	SELECT ct.MaLoaiPhong, lp.TenLoaiPhong,ct.DoanhThu, ct.TyLe, bc.TongDoanhThu
	FROM dbo.BAOCAO_DOANHTHU bc, dbo.CHITIET_BAOCAO_DOANHTHU ct, dbo.LOAI_PHONG lp
	WHERE bc.Nam=ct.Nam AND bc.Thang=ct.Thang AND ct.MaLoaiPhong=lp.MaLoaiPhong
		 AND ct.Nam=@year AND ct.Thang = @month
END
GO


CREATE PROC AddStaffToDataBase(@HoTen NVARCHAR(50),@NgaySinh datetime,@NgayKiHopDong datetime,@SoHopDong int,@MaBacLuong int,@MaPhongBan int,@MaChucVu int)
AS
BEGIN
		insert into dbo.NHAN_VIEN(HoTen,NgaySinh,NgayKyHopDong,SoHopDong,MaBacLuong,MaPhongBan,MaChucVu) 
		values (@HoTen,@NgaySinh,@NgayKiHopDong,@SoHopDong,@MaBacLuong,@MaPhongBan,@MaChucVu)
END
GO

CREATE PROCEDURE dbo.UpdateStaffToDataBase
  @MaNV int,
  @MaBacLuong int,
  @MaPhongBan int,
  @MaChucVu int
AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

		update dbo.NHAN_VIEN 
		SET MaBacLuong =@MaBacLuong , MaPhongBan = @MaPhongBan , MaChucVu = @MaChucVu
		WHERE MaNV = @MaNV 
  END 
END
GO


CREATE PROCEDURE dbo.CreateTenancyCard
  @RoomCode int,
  @FormalityCode int,
  @BeginDay datetime,
  @GuestNum int
AS 
BEGIN 
 SET NOCOUNT ON; 
  BEGIN 

insert INTO dbo.PHIEUTHUEPHONG(MaPhong,MaHinhThucThue,NgayGioBatDauThue,SoKhach,TinhTrangThanhToan)
values(@RoomCode,@FormalityCode,@BeginDay,@GuestNum,0)
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

CREATE PROC capNhatNhomNguoiDung(@MaNhomIndex int,@MaNhom int = null,@TenNhom nvarchar(30) = null)
AS
BEGIN
	if(@MaNhom is null) UPDATE dbo.NHOM_NGUOI_DUNG SET TenNhom=@TenNhom WHERE MaNhom=@MaNhomIndex 
	else
	begin
		ALTER TABLE PHAN_QUYEN
		DROP Constraint FK__PHAN_QUYE__MaNho__7A672E12
		ALTER TABLE NGUOI_DUNG
		DROP Constraint FK__NGUOI_DUN__MaNho__7E37BEF6

		if(@TenNhom is not null) UPDATE dbo.NHOM_NGUOI_DUNG SET TenNhom=@TenNhom WHERE MaNhom=@MaNhomIndex
		UPDATE dbo.PHAN_QUYEN SET MaNhom =@MaNhom WHERE MaNhom =@MaNhomIndex
		UPDATE dbo.NGUOI_DUNG SET MaNhom =@MaNhom WHERE MaNhom =@MaNhomIndex
		UPDATE dbo.NHOM_NGUOI_DUNG SET MaNhom = @MaNhom WHERE MaNhom = @MaNhomIndex
		 

		ALTER TABLE NGUOI_DUNG
		ADD CONSTRAINT FK__NGUOI_DUN__MaNho__7E37BEF6
		FOREIGN KEY (MaNhom) REFERENCES NHOM_NGUOI_DUNG(MaNhom)
		ON UPDATE CASCADE
		ALTER TABLE PHAN_QUYEN
		ADD CONSTRAINT FK__PHAN_QUYE__MaNho__7A672E12
		FOREIGN KEY (MaNhom) REFERENCES NHOM_NGUOI_DUNG(MaNhom)
		ON UPDATE CASCADE
	end
END
GO

CREATE PROC XoaPhong(@MaPhong INT)
AS
BEGIN
	declare @kiemTraRong int
	declare @maPhieuThue int
	declare @maPhongBan int
	declare @dem int
	declare @LanLayPhieuThue bigint
	


	select @kiemTraRong = COUNT(*) from PHIEUTHUEPHONG where MaPhong=@MaPhong 
	if(@kiemTraRong>0) 
	begin
		select @dem = COUNT(*) from PHIEUTHUEPHONG where MaPhong=@MaPhong
		while(@dem>0)
		begin
			select @maPhieuThue =  MaPT from PHIEUTHUEPHONG where MaPhong=@MaPhong 

			select @kiemTraRong = count(*) from CHITIET_SUDUNGDV where MaPT=@maPhieuThue
			if(@kiemTraRong>0)
			begin
				DELETE FROM CHITIET_SUDUNGDV where MaPT=@maPhieuThue
			end

			select @kiemTraRong = COUNT(*) from CHITIET_PHIEUTHUE where MaPT=@maPhieuThue
			if(@kiemTraRong>0) 
			begin
				DELETE FROM CHITIET_PHIEUTHUE where MaPT=@maPhieuThue
			end

			select @kiemTraRong = count(*) from CHITIET_HOADON where MaPT=@maPhieuThue
			if(@kiemTraRong>0)
			begin
				DELETE FROM CHITIET_HOADON where MaPT=@maPhieuThue
			end

			Delete from PHIEUTHUEPHONG where MaPhong=@MaPhong AND MaPT=@maPhieuThue
			select @dem = @dem -1
		end
	end

	
	select @kiemTraRong=COUNT(*) from PHONG_BAN where MaPhong=@MaPhong
	if(@kiemTraRong>0)
	begin
		select @maPhongBan = MaPhongBan from PHONG_BAN where MaPhong=@MaPhong
		select @kiemTraRong = count(*) from NHAN_VIEN where MaPhongBan=@maPhongBan
		if(@kiemTraRong>0)
		begin
			DELETE FROM NHAN_VIEN where MaPhongBan=@maPhongBan
		end
		DELETE FROM PHONG_BAN where MaPhong=@MaPhong
	end
	DELETE FROM PHONG where MaPhong=@MaPhong
END
GO

CREATE PROCEDURE TraVeSoHDLonNhat
AS 
BEGIN 
	declare @soHoaDonLonNhat int
	declare @rs int
	select @rs = COUNT(*) from NHAN_VIEN 
	if(@rs>0) 
		begin
			select @rs = MAX(SoHopDong) from NHAN_VIEN
		end
	else
		begin
			select @rs = 0
	    end
		return @rs
END
GO


