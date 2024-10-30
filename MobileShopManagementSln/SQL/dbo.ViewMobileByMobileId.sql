CREATE PROC ViewMobileByMobileId
@MobileId int
AS
BEGIN
---Master---
SELECT *  FROM Mobile WHERE MobileId=@MobileId
---Details---
SELECT * FROM   Variant WHERE MobileId=@MobileId
END