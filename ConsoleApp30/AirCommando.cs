using ConsoleApp30;
using System;

internal class AirCommando : Commando
{
    private string name;
    private string codeName;
    private string status;
    private string weapon;

    private string[] listweapon = { "Chisel", "Bag", "Hammer", "Rope", "Water" };
    private string[] listStatus = { "Standby", "Going", "Hiding" };

    public AirCommando(string name, string codeName, int changeWeapon, int changeStatus)
        : base(name, codeName)
    {
        this.name = name;
        this.codeName = codeName;
        this.weapon = listweapon[changeWeapon];
        this.status = listStatus[changeStatus];
    }

    
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"CodeName: {codeName}");
        Console.WriteLine($"Weapon: {weapon}");
        Console.WriteLine($"Status: {status}");
    }
}
