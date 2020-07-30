using System;
using System.Collections.Generic;
using System.Text;

namespace TD_4_de_Csharp
{
    class Client
    {
        public int Cni;
        public string Prenom;
        public string Nom;
        public int Telephone;

        public Client(string prenom)
        {
            Prenom = prenom;
        }

        public Client(int cni, string prenom, string nom)
        {
            Cni = cni;
            Prenom = prenom;
            Nom = nom;
        }

        public void Afficher()
        {
            Console.WriteLine("{0}-{1} et numero cni : {2}",Prenom,Nom,Cni);
        }
    }
}
