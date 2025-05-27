using ConsoleApp30;
using System;

internal class AirCommando : Commando
{
    private string parachutist;

    public AirCommando(string name, string codeName, int changeWeapon, int changeStatus, string parachutist)
        : base(name, codeName, changeWeapon, changeStatus)
    {
        this.parachutist = parachutist;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {getName()}");
        Console.WriteLine($"CodeName: {getcodeName()}");
        Console.WriteLine($"Weapon: {this.weapon}");
        Console.WriteLine($"Status: {this.status}");
        Console.WriteLine($"Parachutist: {parachutist}");
    }
}
