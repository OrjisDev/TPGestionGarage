using TPGestionGarage;

List<Option> options = new List<Option>();
Option option = new Option(69,"Boule Disco",300);
Moteur moteur = new Moteur(1, "V12", 15000);
options.Add(option);

Voiture v = new Voiture(1,"Twingo III", 15000, Marque.renault, options,moteur, 9, 5, 4, 5);
v.Afficher();