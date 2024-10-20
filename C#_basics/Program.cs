using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        // dit is mijn c# basics folder. hier leer ik wat c# met het maken van code 
        Getters_Setters getters_setter = new Getters_Setters();
        getters_setter.Main();
        Car car = new Car("xyz", "tesla", "Renko");
        car.DisplayCarInfo();
        Influencer mrbeast = new Youtuber("mrbeast", 1000000);
        Influencer james = new Tiktokker("james", 1209312);
        Influencer[] influencers = new Influencer[] { mrbeast, james };
        foreach (Influencer influencer in influencers){
            Console.WriteLine(influencer.FanBase());
        }
    }
}