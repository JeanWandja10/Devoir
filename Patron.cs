using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RatrapageCsharp
{
    class Patron
    {
        private static double CA;
        private double pourcentage;

        public new String ToString()
        {
            return base.ToString() + " " + CA + " " + pourcentage;
        }

        public abstract double GetSalaire()
        {
            return CA * pourcentage / 100;
        }
    }
}
