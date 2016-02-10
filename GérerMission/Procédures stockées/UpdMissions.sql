Create Procedure UpdMissions
@idm int,
@vidEntreprise int,
@vidMotif tinyint = null,
@vidQualif int,
@vidNiveau tinyint = null,
@vidConsult tinyint,
@vDateouv datetime,
@vDatefin datetime = null,
@vRemu money = null,
@vPreci varchar(250) = null,
@vDuree tinyint = null
As
Begin
Update Mission
Set

IdMotif = @vidMotif,
IdQualification = @vidQualif,
idNiveau = @vidNiveau,
IdConsultant = @vidConsult,
DateOuverture = @vDateouv,
DateFin = @vDatefin,
RemunerationProposee = @vRemu,
Precisions = @vPreci,
Duree = @vDuree
Where IdMission = @idm and IdEntreprise = @vidEntreprise
IF(@@ROWCOUNT=0)
BEGIN
PRINT'Avertissement:Aucune ligne modifiéé'
RETURN
END
END
