namespace Praxis_Abstrakte.Klassen.und.Methoden;

//Abstrakte Klasse
abstract class Arbeiter
{
    
    //Eigenschaften
    public string Name { get; set; }
    public decimal Gehalt { get; set; }

    
    //Konstruktor Methode
    public Arbeiter(string name, decimal gehalt)
    {
        Name = name;
        Gehalt = gehalt;
    }

    
    //Methode
    public void PrintInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gehalt: {Gehalt}");
    }
    
    //Abstrakte Methode
    public abstract void ArbeitVerrichten();
}