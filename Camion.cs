namespace TPGestionGarage;

public class Camion : Vehicle
{
    private int nbEssieu { get; set; }
    private int poids { get; set; }
    private int volume { get; set; }
    
    public Camion(int Id, string Nom, int PrixHT, Marque marque, List<Option> options, Moteur moteur, int nbEssieu, int poids, int volume) : base(Id, Nom, PrixHT, marque, options, moteur)
    {
        this.nbEssieu = nbEssieu;
        this.poids = poids;
        this.volume = volume;
    }

    public override void Afficher()
    {
        Console.WriteLine("Camion: " + Nom + "\nMarque : " + Marque + "\nNombre essieus : " + nbEssieu + "\nPoids : " + poids + "\nVolume : " + volume + "\nPrix : " + PrixTotal() + " €");
        AfficherOptions();
        Moteur.Afficher();
    }

    public override decimal CalculerTaxe()
    {
        return nbEssieu * 50;
    }
}