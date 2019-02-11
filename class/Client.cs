using System;

namespace banque
{
    class Client
    {

        public int IdClient {get; set;}
        public string Nom { get; set;}
        public string Prenom { get; set;}
        public string Adresse1 { get; set;}
        public string Adresse2 { get; set;}
        public string Ville { get; set;}
        public string Telephone { get; set;}

        public string Description
        {
           get { return string.Format("{0} {1}", Id, Nom);}
        }
    }
}

