using System;
using System.Collections.Generic;

namespace GérerMission.Metier
{
  public class Qualification
   {
      public int IdQualification {get; set;}
      public string LibelleQualification {get; set;}

      public List<PosteRecherche> Postes { get; set; }

       public Qualification()
        {

        }

      public Qualification Self
      {
         get { return this; }
      }

        // Equals tostring Gethash

        public override bool Equals(Object other)
        {
            return other is Qualification && IdQualification == ((Qualification)other).IdQualification;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}