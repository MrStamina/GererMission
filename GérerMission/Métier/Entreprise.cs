using System;
using System.Collections.Generic;

namespace GérerMission.Metier
{
   public class Entreprise
   {
      public int IdEntreprise {get; set;}
      public string RaisonSociale {get; set;}
      public string Adresse1Ent {get; set;}
      public string Adresse2Ent {get; set;}
      public string CpEnt {get; set;}
      public string VilleEnt {get; set;}
      public bool Cliente {get; set;}
      public string Contact { get; set; }
      public string TelContact { get; set; }
      public string MailContact { get; set; }
      public DateTime DateCreation { get; set; }
      public Activite SecteurActivite {get; set;}
      public PoleEmbauche PoleRattachement {get; set;}

      public List<Mission> Missions { get; set; }

        public Entreprise()
        {

        }

        public List<Mission> GetMissions()
        {
            return Missions;
        }

        public void SetMissions(List<Mission> lesMissions)
        {
            Missions = lesMissions;
        }

        public override bool Equals(Object other)
        {
            return other is Entreprise && IdEntreprise == ((Entreprise)other).IdEntreprise;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}