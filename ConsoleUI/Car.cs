using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasFourDoors { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine("The Car is driving.");
    }

    public override string ExtraInfo()
    {
        return $"Has 4 Doors? : {HasFourDoors}";
    }
}