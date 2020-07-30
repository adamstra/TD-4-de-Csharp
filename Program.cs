using System;

namespace TD_4_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1234567890,"Adama","Traore");
            client.Afficher();


            Compte compte = new Compte("Adama",12345,65432);
            compte.Crediter(45);
            compte.Crediter(30);
            compte.PresenterCompte();
        }
    }
}
