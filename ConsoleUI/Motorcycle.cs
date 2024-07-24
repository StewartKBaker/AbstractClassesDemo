using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool Has2Wheels { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("The Motorcycle is driving.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle Default");
    }

    public override string ExtraInfo()
    {
        return $"Has 2 Wheels? : {Has2Wheels}";
    }
}