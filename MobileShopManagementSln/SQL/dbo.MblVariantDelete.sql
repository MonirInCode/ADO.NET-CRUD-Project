CREATE PROC MblVariantDelete
@MobileId int
as
BEGIN
---Details---
DELETE FROM Variant WHERE MobileId=@MobileId
---Master---
DELETE FROM Mobile WHERE MobileId=@MobileId
END