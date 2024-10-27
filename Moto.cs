namespace TPGestionGarage;

public class Moto : Vehicle
{
    private int cylindree { get; set; }
    
    public Moto(int Id, string Nom, int PrixHT, Marque marque, List<Option> options, Moteur moteur, int cylindree) : base(Id, Nom, PrixHT, marque, options, moteur)
    {
        this.cylindree = cylindree;
    }

    public override void Afficher()
    {
        Console.WriteLine("Moto: " + Nom + "\nMarque : " + Marque + "\nCylindrée : " + cylindree + "\nnPrix : " + PrixTotal() + " €");
        AfficherOptions();
        Moteur.Afficher();
    }

    public override decimal CalculerTaxe()
    {
        throw new NotImplementedException();
    }
}