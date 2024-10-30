CREATE PROC MobileAddOrEdit
@MobileId int,
@MobileModel varchar(20),
@MobileName varchar(30),
@LaunchDate Datetime,
@IsStock bit,
@MobileVersionId int,
@ImagePath varchar(250),
@MobileType char(10)
AS
BEGIN
--Inser---
IF @MobileId=0
BEGIN
INSERT INTO Mobile(MobileModel,MobileName,LaunchDate,IsStock,MobileVersionId,ImagePath,MobileType) VALUES
(@MobileModel,@MobileName,@LaunchDate,@IsStock,@MobileVersionId,@ImagePath,@MobileType)
SELECT SCOPE_IDENTITY();
END
ELSE
BEGIN
--Update
UPDATE Mobile SET 
MobileModel=@MobileModel,MobileName=@MobileName,LaunchDate=@LaunchDate,IsStock=@IsStock,MobileVersionId=@MobileVersionId,ImagePath=@ImagePath,MobileType=@MobileType WHERE MobileId=@MobileId
SELECT @MobileId
END
END