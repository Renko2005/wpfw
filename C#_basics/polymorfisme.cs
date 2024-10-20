using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
public abstract class Influencer //base class voor youtuber en tiktokker, is abstract zodat het niet zelf als een klas kan dienen
{
    public string Naam {get; set;}
    public Influencer(string naam){
        this.Naam = naam;
    }
    public void Intro() => Console.WriteLine("Hey welkom bij deze video"); 
    public virtual string FanBase() => "ik heb veel fans"; //is virtual zodat het overriding mogelijk maakt
}
public class Youtuber : Influencer{ //subclass van influencer

    public int Abbonees {get; set;}
    public Youtuber(string naam, int abbonees) : base(naam) 
    {
        this.Abbonees = abbonees;
    }
    public override string FanBase() //overriding van de fanbase methode
    {
        return $"{base.Naam} heeft {Abbonees} abbonees"; //base om de baseclass te benaderen.
    }
}
public class Tiktokker : Influencer{
    
    public int Volgers {get; set;}

    public Tiktokker(string naam, int volgers) : base(naam)
    {
        this.Volgers = volgers;
    }
    public override string FanBase()
    {
        return $"{base.Naam} heeft {Volgers} volgers";
    }
}
