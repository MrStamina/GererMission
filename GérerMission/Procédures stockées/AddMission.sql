USE [ChasseurDeTete]
GO
/****** Object:  StoredProcedure [dbo].[AddMission]    Script Date: 10/02/2016 15:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddMission]
(
	@idEntreprise int,
	@idMotif tinyint=null,
	@idQualification int,
	@idNiveau tinyint=null,
	@idConsultant tinyint,
	@dateouverture date,
	@datefin date=null,
	@remu money=null,
	@precision varchar(250) =null,
	@duree tinyint =null,
	@idMission int OUTPUT
)
	
as

	insert [dbo].[Mission]
			(idEntreprise,idMotif, idQualification,idNiveau,idConsultant, DateOuverture, DateFin, RemunerationProposee, Precisions, Duree)
			values(@idEntreprise, @idMotif,@idQualification,@idNiveau,@idConsultant, @dateouverture,@datefin, @remu,@precision, @duree)

-- récupération clé générée
	Select @idMission = SCOPE_IDENTITY()



