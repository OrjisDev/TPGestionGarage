using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Moteur
    {
        public enum TypeMoteur
        {
            diesel,
            essence,
            electrique,
            hybride,
        }
        private static int Increment = 0;
        private int Id { get; set; }
        private string Nom { get; set; }
        private decimal Prix { get; set; }
        private int Puissance { get; set; }
        private TypeMoteur Tmoteur { get; set; }
        public Moteur(int id, string nom, decimal prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
        }
        public void Afficher()
        {
            Console.WriteLine($"Moteur: {Nom} \nPuissance : {Puissance} \nPrix : {Prix} €");
        }
    }
}
