CREATE PROC MblVariantAddAndEdit
@VariantId int,
@Ram_Rom varchar(20),
@Price int,
@MobileId int
AS
if @VariantId=0
BEGIN
---Insert--
INSERT INTO Variant(Ram_Rom,Price,MobileId)
VALUES (@Ram_Rom,@Price,@MobileId)
END
else
BEGIN
---Update---
UPDATE Variant SET Ram_Rom=@Ram_Rom, Price=@Price , MobileId=@MobileId WHERE VariantId=@VariantId
END