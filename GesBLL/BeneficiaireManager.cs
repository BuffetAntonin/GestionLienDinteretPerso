using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesLienBO;
using GesLienDAL;
namespace GesLienBLL
{
    public class BeneficiaireManager
    {
        private static BeneficiaireManager instance;
        /// <summary>
        ///  Permet d'appel les méthodes de la classe BeneficiaireManager
        /// </summary>
        /// <returns></returns>
        public static BeneficiaireManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BeneficiaireManager();
            }
            return instance;
        }
        /// <summary>
        /// Retourne une liste de la classe bénéficiaire.
        /// </summary>
        /// <param name="message">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiaires(out string message)
        {
            //Déclare les variables utilisées.
            List<Beneficiaire> lesBeneficiaires;
            //Appelé da la méthode qui récupérait une liste de bénéficiaires et on récupère une chaîne de caractère avec un message d'erreur ou pas.
            lesBeneficiaires = BeneficiaireDAO.GetInstance().GetLesBeneficiaires(out string msg);
            // Teste si le message si vide alors retourne le message et la liste de bénéficiaires sinon retourne le message d'erreur et nul.
            if (msg == "")
            {
                message = msg;
                return lesBeneficiaires;
            }
            else
            {
                message = msg;
                return null;
            }
        }
        /// <summary>
        /// Appelle la méthode d'ajout bénéficiaire qui permet d'ajouter dans la base de données.
        /// Retourne une chaîne de caractère.
        /// Si ça, c'est bien passe alors la chaîne est vide sinon la chaîne à un message d'erreur
        /// </summary>
        /// <param name="nom">Récupérer une chaîne de caractère qui représente le nom du bénéficiaire ou organisation</param>
        /// <param name="rue">Récupérer une chaîne de caractère qui représente la rue du bénéficiaire ou organisation</param>
        /// <param name="prenom">Récupérer une chaîne de caractère qui représente le prenom du bénéficiaire</param>
        /// <param name="numRPPS">Récupérer un nombre entier qui représente le numéro de RPPS d'un professionnel de santé</param>
        /// <param name="numIssee">Récupère la valeur de la liste d'un ville du bénéficiaire.</param>
        /// <param name="idEtablissement">Récupère la valeur de la liste des établissements d'un étudiant.</param>
        /// <param name="idProfession">Récupère la valeur de la liste les professions d'un professionnel de santé.</param>
        /// <param name="idTypeBeneficiaire">Récupère la valeur de la liste des types d'un bénéficiaire.</param>
        /// <returns></returns>
        public string AjoutBeneficiaire(string nom, string rue, string prenom, int? numRPPS, int numIssee, int idEtablissement, int idProfession, int idTypeBeneficiaire)
        {
            //Déclare les variables utilisées.
            Beneficiaire unBenficiaire;
            Ville uneVille;
            Etatblissement unEtablissement;
            Profession uneProfession;
            TypeBeneficiaire unTypeBeneficiaire;
            uneProfession = null;
            unEtablissement = null;
            uneVille = new Ville(numIssee);
            unTypeBeneficiaire = new TypeBeneficiaire(idTypeBeneficiaire);
            string msg = "";
            int existeBenef;
            // Il teste de quel type de bénéficiaire pour faire de traitement diffèrent.
            switch (idTypeBeneficiaire)
            {
                // Premier cas si le type de bénéficiaire est un professionnel de santé
                case 1:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    if (prenom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la prenom\n";
                    }
                    if (numRPPS == 0)
                    {
                        msg = msg + "veuillez renseigner la numéro RPPS\n";

                    }
                    uneProfession = new Profession(idProfession);
                    unEtablissement = new Etatblissement(null, null);
                    break;
                // Deuxième cas si le type de bénéficiaire est un étudiant
                case 2:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    if (prenom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la prenom\n";
                    }
                    numRPPS = null;
                    uneProfession = new Profession(null, null);
                    unEtablissement = new Etatblissement(idEtablissement);
                    break;
                // Troisième cas si le type de bénéficiaire est autre
                case 3:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    prenom = null;
                    numRPPS = null;
                    uneProfession = new Profession(null, null);
                    unEtablissement = new Etatblissement(null, null);
                    break;
                default:
                    break;
            }
            // Vérifie si le message est vide sinon retourne un message d'erreur.
            if (msg == "")
            {
                // Initialisation une la classe bénéficiaire avec les paramètres.
                unBenficiaire = new Beneficiaire(nom, rue, prenom, numRPPS, uneVille, unEtablissement, uneProfession, unTypeBeneficiaire);
                // Appelle de la méthode qui retourne le nombre de bénéficiaires avec les mêmes paramètres.
                string existeBeneficiaicere = BeneficiaireDAO.GetInstance().ExisteBeneficiaire(unBenficiaire);
                int.TryParse(existeBeneficiaicere, out existeBenef);
                // Il teste si la valeur retourne est égal 0 alors il appelait la méthode pour ajouter une bénéficiaire dans la base sinon retourne un message d'erreur.
                if (existeBenef == 0)
                {
                    msg = BeneficiaireDAO.GetInstance().AjoutBeneficiaire(unBenficiaire);
                }
                else
                {
                    msg = "le bénèficiaire existe dèjà";
                }
            }
            return msg;
        }
        /// <summary>
        /// Retourne un bénéficiaire.
        /// </summary>
        /// <param name="idBeneficiaire">Récupère la valeur de la liste des bénéficiaires.</param>
        /// <param name="message">>Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public Beneficiaire GetUnBeneficiaire(int idBeneficiaire, out string message)
        {
            //Déclare les variables utilisées.
            Beneficiaire unBeneficiaire;
            //Appelé da la méthode qui récupérait un bénéficiaire et on récupère une chaîne de caractère avec un message d'erreur ou pas.
            unBeneficiaire = BeneficiaireDAO.GetInstance().GetUnBeneficiaire(idBeneficiaire, out string msg);
            // Teste si le message si vide alors retourne le message et un bénéficiaires sinon retourne le message d'erreur et nul.
            if (msg == "")
            {
                message = msg;
                return unBeneficiaire;
            }
            else
            {
                message = msg;
                return null;
            }
        }
        /// <summary>
        /// Appelle la méthode de modification d'un bénéficiaire qui permet de modifier dans la base de données.
        /// Retourne une chaîne de caractère.
        /// Si ça, c'est bien passe alors la chaîne est vide sinon la chaîne à un message d'erreur
        /// </summary>
        /// <param name="id">Récupère la valeur de la liste des bénéficiaires.</param>
        /// <param name="nom">Récupérer une chaîne de caractère qui représente le nom du bénéficiaire ou organisation</param>
        /// <param name="rue">Récupérer une chaîne de caractère qui représente la rue du bénéficiaire ou organisation</param>
        /// <param name="prenom">Récupérer une chaîne de caractère qui représente le prenom du bénéficiaire</param>
        /// <param name="numRPPS">Récupérer un nombre entier qui représente le numéro de RPPS d'un professionnel de santé</param>
        /// <param name="numIssee">Récupère la valeur de la liste d'un ville du bénéficiaire.</param>
        /// <param name="idEtablissement">Récupère la valeur de la liste des établissements d'un étudiant.</param>
        /// <param name="idProfession">Récupère la valeur de la liste les professions d'un professionnel de santé.</param>
        /// <param name="idTypeBeneficiaire">Récupère la valeur de la liste des types d'un bénéficiaire.</param>
        /// <returns></returns>
        public string ModifBeneficiaire(int id, string nom, string rue, string prenom, int? numRPPS, int numIssee, int idEtablissement, int idProfession, int idTypeBeneficiaire)
        {
            //Déclare les variables utilisées.
            Beneficiaire unBenficiaire;
            Ville uneVille;
            Etatblissement unEtablissement;
            Profession uneProfession;
            TypeBeneficiaire unTypeBeneficiaire;
            uneProfession = null;
            unEtablissement = null;
            uneVille = new Ville(numIssee);
            unTypeBeneficiaire = new TypeBeneficiaire(idTypeBeneficiaire);
            string msg = "";
            int existeBenef;
            // Il teste de quel type de bénéficiaire pour faire de traitement diffèrent.
            switch (idTypeBeneficiaire)
            {
                // Premier cas si le type de bénéficiaire est un professionnel de santé
                case 1:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    if (prenom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la prenom\n";
                    }
                    if (numRPPS == 0)
                    {
                        msg = msg + "veuillez renseigner la numéro RPPS\n";

                    }
                    uneProfession = new Profession(idProfession);
                    unEtablissement = new Etatblissement(null, null);
                    break;
                // Deuxième cas si le type de bénéficiaire est un étudiant
                case 2:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    if (prenom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la prenom\n";
                    }
                    numRPPS = null;
                    uneProfession = new Profession(null, null);
                    unEtablissement = new Etatblissement(idEtablissement);
                    break;
                // Troisième cas si le type de bénéficiaire est autre
                case 3:
                    // Vérifie si les champs sont vide sinon crée un message d'erreur.
                    if (nom.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner le nom \n";
                    }
                    if (rue.Trim() == "")
                    {
                        msg = msg + "veuillez renseigner la rue\n";
                    }
                    prenom = null;
                    numRPPS = null;
                    uneProfession = new Profession(null, null);
                    unEtablissement = new Etatblissement(null, null);
                    break;
                default:
                    break;
            }
            // Vérifie si le message est vide sinon retourne un message d'erreur.
            if (msg == "")
            {
                // Initialisation une la classe bénéficiaire avec les paramètres.
                unBenficiaire = new Beneficiaire(id, nom, rue, prenom, numRPPS, uneVille, unEtablissement, uneProfession, unTypeBeneficiaire);
                // Appelle de la méthode qui retourne le nombre de bénéficiaires avec le paramètre.
                string existeBeneficiaire = BeneficiaireDAO.GetInstance().ExisteBeneficiaire(unBenficiaire);
                int.TryParse(existeBeneficiaire, out existeBenef);
                // Il teste si la valeur retourne est égal 0 alors il appelait la méthode de modification une bénéficiaire dans la base sinon retourne un message d'erreur.
                if (existeBenef == 0)
                {
                    msg = BeneficiaireDAO.GetInstance().ModifBeneficiaire(unBenficiaire);
                }
                else
                {
                    msg = "le bénèficiaire existe dèjà";
                }
            }
            return msg;
        }
        /// <summary>
        /// Appelle la méthode de suppression d'un bénéficiaire qui permet de supprimer dans la base de données.
        /// Retourne une chaîne de caractère.
        /// Si ça, c'est bien passe alors la chaîne est vide sinon la chaîne à un message d'erreur       
        /// </summary>
        /// <param name="id">Récupère la valeur de la liste des bénéficiaires.</param>
        /// <returns></returns>
        public string SupprBeneficiaire(int id)
        {
            // il appelait la méthode de suppression une bénéficiaire dans la base sinon retourne un message d'erreur.
            string msg = BeneficiaireDAO.GetInstance().supprBeneficiaire(id);
            return msg;
        }
        /// <summary>
        /// Retourne une liste de la classe bénéficiaire par la ville sélectionné.
        /// </summary>
        /// <param name="numInsee">Récupère la valeur de la liste d'un ville du bénéficiaire.</param>
        /// <param name="messgae">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParVille(int numInsee, out string messgae)
        {
            //Déclare les variables utilisées.
            List<Beneficiaire> lesBeneficiaire = new List<Beneficiaire>();
            //Appelé da la méthode qui récupérait une liste de bénéficiaires par ville selection et on récupère une chaîne de caractère avec un message d'erreur ou pas.
            lesBeneficiaire = BeneficiaireDAO.GetInstance().GetBeneficiairesParVille(numInsee, out string msg);
            // Teste si le message si vide alors retourne le message et la liste de bénéficiaires sinon retourne le message d'erreur et nul.
            if (msg == "")
            {
                messgae = msg;
                return lesBeneficiaire;
            }
            else
            {
                messgae = msg;
                return null;
            }

        }
        /// <summary>
        /// Retourne une liste de la classe bénéficiaire par la profession du professionnel de santé sélectionné.
        /// La liste ne retourne que des professionnels de santé.
        /// </summary>
        /// <param name="idProfession">Récupère la valeur de la liste les professions d'un professionnel de santé.</param>
        /// <param name="message">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParProfession(int idProfession, out string message)
        {            
            //Déclare les variables utilisées.
            List<Beneficiaire> lesBeneficiaires;
            //Appelé da la méthode qui récupérait une liste de bénéficiaires par profession sélectionné et on récupère une chaîne de caractère avec un message d'erreur ou pas.
            lesBeneficiaires = BeneficiaireDAO.GetInstance().GetBeneficiairesParProfession(idProfession, out string msg);
            // Teste si le message si vide alors retourne le message et la liste de bénéficiaires sinon retourne le message d'erreur et nul.
            if (msg == "")
            {
                message = msg;
                return lesBeneficiaires;
            }
            else
            {
                message = msg;
                return lesBeneficiaires;
            }
        }
        /// <summary>
        /// Retourne une liste de la classe bénéficiaire pour l'année sélectionné des avantages.
        /// </summary>
        /// <param name="annee">Récupère l'année sélectionné</param>
        /// <param name="message">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesParAvantagesAnnee(int annee, out string message)
        {
            //Déclare les variables utilisées.
            List<Beneficiaire> lesBeneficiaire = new List<Beneficiaire>();
            //Appelé da la méthode qui récupérait une liste de bénéficiaires pour l'année sélectionné des avantages et on récupère une chaîne de caractère avec un message d'erreur ou pas.
            lesBeneficiaire = BeneficiaireDAO.GetInstance().GetBeneficiairesParAvantagesAnnee(annee, out string msg);
            //Teste si le message si vide alors retourne le message et la liste de bénéficiaires sinon retourne le message d'erreur et nul.
            if (msg == "")
            {
                message = msg;
                return lesBeneficiaire;
            }
            else
            {
                message = msg;
                return null;
            }
        }
        /// <summary>
        /// Retourne une liste de la classe bénéficiaire donc la période de date sélectionnée des conventions.
        /// </summary>
        /// <param name="dateD">Récupère la date du début sélectionne.</param>
        /// <param name="dateF">Récupère la date du fin sélectionne.</param>
        /// <param name="message">Retourne une chaîne de caractère vide si la sélection c'est bien passé sinon retourne le message d'erreur.</param>
        /// <returns></returns>
        public List<Beneficiaire> GetBeneficiairesConventionPeriode(string dateD, string dateF, out string message)
        {
            //Déclare les variables utilisées et converti en date.
            List<Beneficiaire> lesBeneficiaire = new List<Beneficiaire>();
            DateTime dateDebut;
            DateTime.TryParse(dateD, out dateDebut);
            DateTime dateFin;
            DateTime.TryParse(dateF, out dateFin);
            // Vérifie si la date de début est bien inférieure à la date de fin.
            if (dateDebut <= dateFin)
            {
                //Appelé da la méthode qui récupérait une liste de bénéficiaires donc la période de date sélectionnée des conventions et on récupère une chaîne de caractère avec un message d'erreur ou pas.
                lesBeneficiaire = BeneficiaireDAO.GetInstance().GetBeneficiairesConventionPeriode(dateDebut, dateFin, out string msg);
                //Teste si le message si vide alors retourne le message et la liste de bénéficiaires sinon retourne le message d'erreur et nul.
                if (msg == "")
                {
                    message = msg;
                    return lesBeneficiaire;
                }
                else
                {
                    message = msg;
                    return null;
                }
            }
            message = "veuillez indiquer une date de dèbut inferieux à une date de fin";
            return null;
        }
    }
}
