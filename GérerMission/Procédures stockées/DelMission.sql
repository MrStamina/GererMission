Create Procedure DelMission
@idMission int
as
delete from dbo.Mission where IdMission = @idMission