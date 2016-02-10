using System;
using System.Collections.Generic;
using System.Linq;

namespace GérerMission.Metier
{
    public class Consultant
    {
        public sbyte IdConsultant{ get; set; }
        public string NomConsultant { get; set; }
        public string PrenomConsultant { get; set; }

        public List<Mission> Missions { get; set; }

        public Consultant()
        {

        }

        public override bool Equals(Object other)
        {
            return other is Consultant && IdConsultant == ((Consultant)other).IdConsultant;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
