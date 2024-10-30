CREATE PROC ViewAllMobiles
AS
BEGIN
SELECT e.MobileId,e.MobileModel,e.MobileName,e.LaunchDate,e.MobileType,e.IsStock ,
(SELECT SUM(Price) FROM Variant WHERE MobileId=e.MobileId) AS TotalPrice,
d.MobileVersionTitle,e.ImagePath
FROM Mobile e JOIN MobileVersion d
ON e.MobileVersionId=d.MobileVersionId
END