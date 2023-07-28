using Object_Oriented_Programming_2;

Player p = new Player();
Console.WriteLine(p.GetDetails());

List<Player> MyClan = new List<Player>()
{
    new Player("Jeo", "Support",100),
    new Player("Eval", "Tank", 105),
    new Player("GraphicSugar", "Medic", 100),
    new Player("Kat", "Trucker", 50),
    new Player("Hunter", "Shooter", 23),
    new Player("Jo", "Tank", 95),
    new Player("Shaggy", "Offender", 80),
    new Player("Doug", "Glass Cannon", 34),
    new Player("Bob","Builder",30)

};

Console.WriteLine("My Clan:");
foreach (Player pl in MyClan)
{
    Console.WriteLine(pl.GetDetails());
}

//Linq
List<Player> group = MyClan.Where(c => c.Level >= 80).ToList();
Console.WriteLine("Able to fight the boss");
foreach(Player pl in group)
{
    Console.WriteLine(pl.GetDetails());
}

Console.ReadLine();