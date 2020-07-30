using System;
using System.Collections.Generic;
using System.Text;

namespace TD_4_de_Csharp
{
    class Compte : Client 
    {
        protected int Solde;
        protected int Code;


        public Compte( string prenom, int solde, int code) : base(prenom)
        {
            Solde = solde;
            Code = code;
        }

        public void Crediter(int somme)
        {
            Console.WriteLine("Vous etes crediter de {0}",somme);
            
        }

        public void Debiter(int somme)
        {
            Console.WriteLine("Vous etes debiter de {0}",somme);
        }

        public void PresenterCompte()
        {
            Console.WriteLine("Le solde :{0} , le code {1} et le proprietaire se nomme {2}",Solde , Code ,Prenom);
        }
    }
}
