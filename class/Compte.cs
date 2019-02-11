using System;

namespace banque{

    class Compte{
       

        #region Attributs
        private int idCompte;
        private string libelle;
        private string type;
        private int solde = 0;
        private int plafond;
        private int decouvert_autorise;
        #endregion

        public int Id { get;set;}
       
        public string Libelle { get; set; }

        public string Type {get;set;}

        public int Solde {get;set;}
        public int Plafond {get;set;}

        public string Description
        {
            get { return string.Format("IdCompte: {0} - {1} Typecompte: {2} Solde: {3} PlafondMax: {4}", Id, Libelle,Type,Solde,Plafond); }
        }
        
    }
}