namespace TPGestionGarage;

public class Garage
{
    private string nom { get; set; }
    
    private List<Vehicle> vehicules { get; set; }

    public void AjouterVehicule(Vehicle vehicle)
    {
        vehicules.Add(vehicle);
    }

    public void AfficherVehicule()
    {
        foreach (Vehicle vehicle in vehicules)
        {
            vehicle.Afficher();   
        }
    }

    public void AfficherVoiture()
    {
        foreach (Voiture voiture in vehicules)
        {
            voiture.Afficher();
        }
    }
    
    public void AfficherMoto()
    {
        foreach (Moto moto in vehicules)
        {
            moto.Afficher();
        }
    }
    
    public void AfficherCamion()
    {
        foreach (Camion camion in vehicules)
        {
            camion.Afficher();
        }
    }
}