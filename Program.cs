using System;
using Praxis_Abstrakte.Klassen.und.Methoden;
    

class Program
{
    static void Main(string[] args)
    {
        Mechaniker peter = new Mechaniker("Peter", 5600);
        peter.PrintInformation();
        peter.ArbeitVerrichten();

        Console.WriteLine();
        
        Informatiker dias = new Informatiker("Dias", 6400);
        dias.PrintInformation();
        dias.ArbeitVerrichten();

        //Nachfragen
        Arbeiter[] arbeiter = new Arbeiter[2];
        arbeiter[0] = peter;
        arbeiter[1] = dias;
    }
}