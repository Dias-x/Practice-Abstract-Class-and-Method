namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Erbt von Arbeiter
class Mechaniker : Arbeiter
{

    //Konstruktor Methode abrufen
    public Mechaniker(string name, decimal gehalt) : base(name, gehalt)
    {
    }
    
    //Abstrakte Methode überschreiben
    public override void ArbeitVerrichten()
    {
        Console.WriteLine($"Der Mechaniker {Name} kommt in die Garage");
        Console.WriteLine($"Repariert an Autos");
    }
}