SELECT * FROM visitor_T
SELECT * FROM ZoneType_T
SELECT * FROM VisitorZoneType_T

SELECT visitor_T.Name, Visitor_T.Email, Visitor_T.ContactNumber, ZoneType_T.ZoneName FROM Visitor_T join ZoneType_T
ON Visitor_T.ZoneTypeId = ZoneType_T.Id


delete from Visitor_T
delete from VisitorZoneType_T

dbcc checkident (Visitor_T, reseed, 0)
dbcc checkident (VisitorZoneType_T, reseed, 0)

create view VisitorAndZoneInfo
as
SELECT VisitorZoneType_T.VisitorId, VisitorZoneType_T.ZoneTypeId, Visitor_T.Name, Visitor_T.Email, Visitor_T.ContactNumber, ZoneType_T.ZoneName FROM VisitorZoneType_T join ZoneType_T
ON VisitorZoneType_T.ZoneTypeId = ZoneType_T.Id
join Visitor_T
on VisitorZoneType_T.VisitorId = Visitor_T.ID


SELECT * FROM VisitorAndZoneInfo
