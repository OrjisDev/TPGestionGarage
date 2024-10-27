using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public enum Marque
    {
        peugeot,
        renault,
        citroen,
        audi,
        ferrari,
    }

    public abstract class Vehicle
    {
        private static int increment = 0;
        protected int Id { get; set; }
        protected string Nom { get; set; }
        protected decimal PrixHT { get; set; }
        protected Marque Marque { get; set; }
        protected List<Option> Options { get; set; }
        protected Moteur Moteur { get; set; }

        public Vehicle(int Id, string Nom, int PrixHT, Marque marque, List<Option> options, Moteur moteur)
        {
            increment++;
            this.Id = Id;
            this.Nom = Nom;
            this.PrixHT = PrixHT;
            this.Marque = marque;
            this.Options = options;
            Moteur = moteur;
        }

        public void AfficherOptions()
        {
            foreach (Option option in Options)
            {
                option.Afficher();
            }
        }

        public abstract void Afficher();

        public void AjouterOption(Option option)
        {
            Options.Add(option);
        }

        public abstract decimal CalculerTaxe();

        public decimal PrixTotal()
        {
            decimal optionsPrix = 0;
            foreach (Option option in Options)
            {
                optionsPrix += option.Prix;
            }

            return PrixHT + optionsPrix + CalculerTaxe();
        }
    }
}
