using System;

namespace GérerMission.Metier
{
   public class Niveau
   {
      public sbyte? IdNiveau {get; set;}
      public string Libelle {get; set;}
   

      public Niveau()
        {


        }

        public override bool Equals(Object other)
        {
            return other is Niveau && IdNiveau == ((Niveau)other).IdNiveau;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}