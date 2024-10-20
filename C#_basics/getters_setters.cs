using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

public class Student
{
    private string voornaam; //dit is een private field met de voornaam
    private string achternaam; //dit is een private field met de achternaam

    public Student(string voornaam, string achternaam, int leerlingnummer)
    {
        this.voornaam = voornaam;
        this.achternaam = achternaam;
        this.Leerlingnummer = leerlingnummer;
    } // dit is de constructor voor Student

    public int Leerlingnummer {get; set;} // dit is een property voor het leerlingnummer

    public string Naam // dit is een property met alleen een get methode
    {
        get { return $"{voornaam} {achternaam}";}
    }
    
}
public class Student_met_smart_getters_en_setters
{
    private string _voornaam; //_ is om aan te geven dat iets private is maar hoeft niet

    private string _achternaam;

    public Student_met_smart_getters_en_setters(string voornaam, string achternaam, int leerlingnummer)
    {
        if (string.IsNullOrEmpty(voornaam)){
                throw new ArgumentException("voornaam mag niet leeg zijn.");
            }
        _voornaam = voornaam;
        if (string.IsNullOrEmpty(achternaam)){
                throw new ArgumentException("achternaam mag niet leeg zijn.");
            }
        _achternaam = achternaam;
        Leerlingnummer = leerlingnummer;
    }

    public int Leerlingnummer{get; set;}
    
    public string Voornaam
    {
        get{return _voornaam;}
        set
        {
            if (string.IsNullOrEmpty(value)){
                throw new ArgumentException("voornaam mag niet leeg zijn.");
            }
            _voornaam = value;
        }
    }
    public string Achternaam
    {
        get{return _achternaam;}
        set
        {
            if (string.IsNullOrEmpty(value)){
                throw new ArgumentException("achternaam mag niet leeg zijn.");
            }
            _achternaam = value;
        }
    }
}
public class Getters_Setters{
    public void Main()
    {
        Console.WriteLine($"getters, setter and constructers:\n");
        Student student1 = new Student("Renko","Brauckman", 22068759);
        Console.WriteLine($"hier wordt de voor- en achternaam + leerlingnummer getoont van een student.\n{student1.Naam}: {student1.Leerlingnummer}");
        Student_met_smart_getters_en_setters smartstudent = new Student_met_smart_getters_en_setters("Renko", "Brauckman", 22068759);
        smartstudent.Voornaam = "Renko2";
        Console.WriteLine(smartstudent.Voornaam);
    }
}