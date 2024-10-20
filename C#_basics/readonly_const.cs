using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

public class Car
{
    private const int _min_age = 18; //kan niet worden aangepast of gemaakt worden in constructor
    private readonly string _model; //kan wel gemaakt worden in constructor maar ook niet worden aangepast 
    private readonly string _brand;

    private string _owner_name;

    public Car(string model, string brand, string owner_name)
    {
        _model = model;
        _brand = brand;
        _owner_name = owner_name;
    }
    public void DisplayCarInfo()
    {
        Console.WriteLine($"car model: {_model}\ncar brand: {_brand}\ncar owner name: {_owner_name}\nminimal age to drive: {_min_age}");
        
    }
}