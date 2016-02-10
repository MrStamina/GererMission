using System;

namespace GérerMission.Metier
{
   public class MotifFin
   {
      public sbyte IdMotif {get; set;}
      public string LibelleMotif {get; set;}
      
        public MotifFin()
        {

        }

        public override bool Equals(Object other)
        {
            return other is MotifFin && IdMotif == ((MotifFin)other).IdMotif;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}