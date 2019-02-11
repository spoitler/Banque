using System;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client();
            c1.Idc = 1;
            c1.Nom = "thomas";

            Console.WriteLine(c1.Description);
            
        }
    }
}



