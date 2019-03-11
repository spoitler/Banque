using System;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public void afficher(Client client, Compte compte){
            Console.WriteLine(client.Description);
            Console.WriteLine(compte.Description);
        }
    }
}



