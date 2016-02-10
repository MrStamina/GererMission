using System;
using System.Collections.Generic;

namespace GérerMission.Metier
{
   public class Mission
   {
       

      public int IdMission {get; set;}
      public DateTime DateOuverture { get ; set;}
      public string Precisions {get; set;}
      public decimal? RemunerationProposee {get; set;}
      public sbyte? Duree { get; set; }
      public Qualification QualificationDemandee {get; set;}
      public Entreprise EntrepriseOffre {get; set;}
      public Niveau NiveauDemande {get; set;}
      public Consultant Consult { get; set; }
      public DateTime? DateFin {get; set;}
      public MotifFin  Motif {get; set;}
      public List<Contact> Contacts { get; set; }
      
      public int CodeEntreprise { get; set; }

        public Mission()
        {

        }

        public Mission(int idMission, Entreprise ent, MotifFin motif, Qualification qualif, Niveau niv, Consultant consult, DateTime dateOuv, DateTime? dateFin, decimal? remu, string precis, sbyte? duree)
        {
            IdMission = idMission;
            EntrepriseOffre = ent;
            Motif = motif;
            QualificationDemandee = qualif;
            NiveauDemande = niv;
            Consult = consult;
            DateOuverture = dateOuv;
            DateFin = dateFin;
            RemunerationProposee = remu;
            Precisions = precis;
            Duree = duree;
        }
        public Mission(int idMission, int initCodeEntreprise, MotifFin motif, Qualification qualif, Niveau niv, Consultant consult, DateTime dateOuv, DateTime? dateFin, decimal? remu, string precis, sbyte? duree)
        {
            IdMission = idMission;
            CodeEntreprise = initCodeEntreprise;
            Motif = motif;
            QualificationDemandee = qualif;
            NiveauDemande = niv;
            Consult = consult;
            DateOuverture = dateOuv;
            DateFin = dateFin;
            RemunerationProposee = remu;
            Precisions = precis;
            Duree = duree;
        }

        public override bool Equals(Object other)
        {
            return other is Mission && IdMission == ((Mission)other).IdMission;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}