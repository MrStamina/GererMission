USE [ChasseurDeTete]
GO
/****** Object:  StoredProcedure [dbo].[GetAllMissions]    Script Date: 09/02/2016 11:06:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetAllMissions]
@vidEntreprise int
AS
select [IdMission],[IdEntreprise],[IdMotif],Mission.IdQualification,[dbo].[Qualification].LibelleQualification,[idNiveau],[IdConsultant],
[DateOuverture],[DateFin],[RemunerationProposee],[Precisions],[Duree]
From [dbo].[Mission]
Join Qualification on Qualification.IdQualification = Mission.IdQualification
where IdEntreprise = @vidEntreprise