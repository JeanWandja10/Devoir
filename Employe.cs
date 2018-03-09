using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RatrapageCsharp
{
    class Employe
    {
        abstract class Employe
        {
            private int matricule;
            private string nom;
            private string prenom;
            private DateTime datenaiss;



            public int Matricule
            {
                get { return matricule; }
                set { matricule = value; }
            }


            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }

            public string Prenom
            {
                get { return prenom; }
                set { prenom = value; }
            }

            public Employe(int matricule, string nom, string prenom, DateTime date)
            {
                this.matricule = matricule;
                this.nom = nom;
                this.prenom = prenom;
                this.datenaiss = date;

            }


            public new String ToString()
            {
                return matricule + " " + nom + " " + prenom + " " + datenaiss;
            }

            public abstract double GetSalaire();

        }
    }
}
