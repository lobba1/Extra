using System;
int Level;
String lvl;

Console.WriteLine("Enter username");
string userName = Console.ReadLine();


while (userName.Length <= 3 || (userName.Length >= 23))
{
    if (userName.Length <= 3)
    {
        Console.WriteLine("More letetrs");
    }
    if (userName.Length >= 23)
    {
        Console.WriteLine("Less letters");
    }
    userName = Console.ReadLine();
}

Console.WriteLine("Welcome " + userName + " nice to have you");

Console.WriteLine("Ange nivå");

lvl = Console.ReadLine();
bool num = int.TryParse(lvl, out Level);


while (Level < 0 || Level > 21)
{
    num = int.TryParse(lvl, out Level);
    if (Level < 0)
    {
        Console.WriteLine(lvl + " is too low");
    }
    if (Level > 21)
    {
        Console.WriteLine(lvl + " is to high");
    }
    lvl = Console.ReadLine();
}

Console.WriteLine("Welcome to level " + lvl);
Console.ReadLine();


