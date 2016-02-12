Create procedure MissionByConsultantByContact
As
select [dbo].[Contact].IdMission,NomConsultant, Entreprise.RaisonSociale, Entreprise.DateCreation, 
Qualification.LibelleQualification, Candidat.Nom, Contact.DateRendezVous,
Contact.Commentaire, SituationContact.LibelleSituation
 
from Mission
join Qualification on Mission.IdQualification = Qualification.IdQualification 
join Entreprise on Mission.IdEntreprise = Entreprise.IdEntreprise
join Contact on Mission.IdMission = Contact.IdMission
join Candidat on Candidat.IdCandidat = Contact.IdCandidat
join SituationContact on SituationContact.IdSituation = Contact.IdSituation
join Consultant on Consultant.IdConsultant = Mission.IdConsultant