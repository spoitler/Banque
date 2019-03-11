using System;
using System.Collections.Generic;

namespace banque
{
    class Banque
    {
        private List<Client> clients = new List<Client>();
        private List<Compte> comptes = new List<Compte>();

        public void ajoutClient(){
            Client client = new Client();
            clients.Add(client);
            ajoutCompte(client);
        }

        public void ajoutCompte(Client client){
            Compte compte = new Compte();
            comptes.Add(compte);
            affectation(client,compte);
        }

        public void affectation(Client client, Compte compte){

            client.Nom = "thomas";
            client.IdClient = 1;

            compte.IdCompte = 1;
            compte.IdClient = client.IdClient;

            afficher(client,compte);

            compte.credit();
        }
    }
}