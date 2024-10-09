using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Voiture : Vehicle
    {
        private int ChevauxFiscaux;
        private int NbPortes;
        private int NbSieges;
        private int TailleCoffre;
        public override void Afficher()
        {
            Console.WriteLine("Voiture: " + Nom + "\nMarque : " + Marque + "\nChevaux fiscaux : " + ChevauxFiscaux + "\nNombre portes : " + NbPortes + "\nNombres sièges : " + NbSieges + "\nTaille du coffre : " + TailleCoffre + " m3" + "\nPrix : " + PrixTotal() + " €");
            AfficherOptions();
        }

        public override decimal CalculerTaxe()
        {
            return ChevauxFiscaux * 10;
        }

        public Voiture(int Id, string Nom, int PrixHT, Marque marque, List<Option> options,Moteur moteur, int chevauxFiscaux, int nbPortes, int nbSieges, int tailleCoffre) : base(Id, Nom, PrixHT, marque, options, moteur)
        {
            this.ChevauxFiscaux = chevauxFiscaux;
            this.NbPortes = nbPortes;
            this.NbSieges = nbSieges;
            this.TailleCoffre = tailleCoffre;
        }
    }
}
