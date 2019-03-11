using System;
using System.Collections.Generic;

namespace banque{

    class Compte{
        public int IdCompte { get; set;}
        public string Libelle { get; set;}
        public string Type { get; set;}
        public int Solde { get; set;}
        public int IdClient { get; set;}
        public int Plafond { get; set;}
        public int Decouvert_autorise { get; set;}
        public void debit(){
            Console.WriteLine("Votre solde est de : " + this.Solde);
            int prixRetrait = 0;
            do
            {
                Console.Write("qu'elle montant voulez vous retirer : ");
                prixRetrait = int.Parse(Console.ReadLine());
                if (this.Solde < prixRetrait)
                {
                    Console.WriteLine("Solde insuffisant !");
                }
            } while (prixRetrait <= 0);
            this.Solde -= prixRetrait;
            Console.WriteLine("Votre solde est maintenant de : " + this.Solde);
        }

        public void credit(){
            Console.WriteLine("Votre solde est de : " + this.Solde);
            int montant = 0;
            do
            {
                Console.Write("Combien voulez-vous deposer sur votre compte : ");
                montant = int.Parse(Console.ReadLine());
                if (montant <= 0)
                {
                    Console.WriteLine("Crédit impossible");
                }
            } while (montant <= 0);
            this.Solde += montant;
            Console.WriteLine("Votre solde est maintenant de : " + this.Solde);
        }

        public string Description
        {
           get { return string.Format("{0} {1}", IdCompte, IdClient);}
        }
    }
}