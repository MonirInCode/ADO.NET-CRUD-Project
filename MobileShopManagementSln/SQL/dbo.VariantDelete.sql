CREATE PROC VariantDelete
@VariantId int
as
BEGIN
DELETE FROM Variant WHERE VariantId=@VariantId
END