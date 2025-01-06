namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Erbt von Arbeiter
class Informatiker : Arbeiter
{
    
    //Konstruktor Methode abrufen
    public Informatiker(string name, decimal gehalt) : base(name, gehalt)
    {
    }
    
    //Abstrakte Methode überschreiben
    public override void ArbeitVerrichten()
    {
        Console.WriteLine($"Der Informatiker {Name} kommt ins Büro");
        Console.WriteLine($"Programmiert an Programme");
    }
}