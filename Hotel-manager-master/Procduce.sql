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

use HOTEL_MANAGER


