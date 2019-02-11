using System;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte();
            c1.Id = 2;
            c1.Libelle = "Intermarché";
            c1.Type ="Compte courant";
            c1.Plafond = 12000;
            c1.Solde = 1548;

            Client cc1 = new Client();

            Console.WriteLine(c1.Description);
            
        }
    }
}



