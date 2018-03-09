using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RatrapageCsharp
{
    class Ouvrier : Employe
    {
        private DateTime dateArivee;
        private static double smig = 2500;

        public DateTime DateArrivee {
            set { dateArivee = value; }
            get { return dateArivee; }
        }

        public new String ToString()
        {
            return base.ToString() + " " + dateArivee + " " + smig ;
        }

        public abstract double GetSalaire()
        {
            return smig + (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(DateArrivee.Year.ToString())) * 100;
        }
    }
}
