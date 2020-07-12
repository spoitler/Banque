Banque
===

Gestion de banque est une application console en C# suite a un projet école.<br>
le projet est sous forme de librairie : voir dossier [class](https://github.com/spoitler/Banque/tree/master/class)

# Objectif

Modéliser le fonctionnement d'une banque. Permet de faire interagir plusieurs types d'objet différents: le compte, le client, la banque.

# Objet compte
 - Un compte bancaire est identifié par son numéro et par le client à qui il appartient
 - Il possède un libellé, une date d’ouverture,  un solde et un type de compte (Courant,  Livret A, LEP, PEL, …). 
 - Un client peut faire un retrait (si son solde le lui permet) ou un dépôt.  Un compte bancaire peut avoir une autorisation de découvert et un montant de découvert associé.
 - Un compte courant n’est pas rémunéré alors que livret l’est. Le taux de rémunération dépend du livret. Un compte rémunéré n’a pas d’autorisation de découvert.
 - Les retraits ne sont pas autorisés sur le PEL avant 5 ans d’ancienneté.
 - Tous les ans le 31 décembre, les intérêts sont ajoutés aux comptes rémunérés.

# Objet client

Le client est identifié par son numéro est possède les caractéristiques suivantes :
 - Nom
 - Prénom
 - Adresse
 - Code postal
 - Ville 
 - Téléphone

# Objet banque

La banque permet de gérer les comptes et les clients.

Elle permet, entre autre, de :
 - Gérer les clients
    - Ajouter un client 
    - Modifier un client 
    - Supprimer un client (et tous ses comptes ?) 
    - Afficher tous les clients
 - Gérer les comptes
    - Ajouter un compte (si le client existe)
    - Modifier un compte
    - Supprimer un compte
    - Afficher tous les comptes 
    - Afficher les comptes d’un client
    - Faire un virement de compte à compte

# Travail

#### Conception
[Diagramme de classe](https://github.com/spoitler/Banque/blob/master/UML%20PPE.asta)

#### Développement
|Code|Implementer|
|----|-----------|
|La classe client|<img src="https://img.pngio.com/check-correct-mark-success-tick-valid-yes-icon-valid-png-512_512.png" height="50">|
|Les classes comptes|<img src="https://img.pngio.com/check-correct-mark-success-tick-valid-yes-icon-valid-png-512_512.png" height="50">|
|La classe banque|<img src="https://img.pngio.com/check-correct-mark-success-tick-valid-yes-icon-valid-png-512_512.png" height="50">|
|Gestion clients|<img src="https://www.metiista.com/wp-content/themes/metiista/img/icons/png/cross-large-0.png" height="50">|
|Gestion comptes|<img src="https://www.metiista.com/wp-content/themes/metiista/img/icons/png/cross-large-0.png" height="50">| 
