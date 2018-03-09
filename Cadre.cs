using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RatrapageCsharp
{
    class Cadre
    {
        private int indice;

        public new String ToString()
        {
            return base.ToString() + " " + indice;
        }

        public new double GetSalaire()
        {
            switch (indice)
            { 
                case 1:
                    return 130000;
                case 2:
                    return 150000;
                case 3:
                    return 170000;
                case 4:
                    return 200000;
                default: return 0;
            }
        }

    }
}
