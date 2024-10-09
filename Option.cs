using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionGarage
{
    public class Option
    {
        private static int Increment = 0;
        private int Id { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public Option(int id, string nom, decimal prix)
        {
            Increment++;
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
        }
        public void Afficher()
        {
            Console.WriteLine(Nom + " " + Prix + " €\n");
        }

    }
}
