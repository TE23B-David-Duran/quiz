int points = 0;

Console.WriteLine("Välkomna till NBA quiz");
Console.WriteLine("Vem vann ROTY år 2024");
Console.WriteLine("A) Chet Holmgren");
Console.WriteLine("B) Victor Wembanyama");
Console.WriteLine("C) Dereck Lively II");
String welcome = Console.ReadLine();
if (welcome == "B")
{
  Console.WriteLine("rätt");
  points = points + 1;
}
else
{
  Console.WriteLine("fel");
  points = points - 1;
}

Console.WriteLine("Vem van MVP år 23-24");
Console.WriteLine("A) Shai Gilgeous-Alexander");
Console.WriteLine("B) Luka Dončić");
Console.WriteLine("C) Nikola Jokić");
string sport = Console.ReadLine();
if (sport == "C")
{
  Console.WriteLine("rätt");
  points = points + 2;
}
else
{
  Console.WriteLine("fel");
  points = points - 1;
}

Console.WriteLine("Vilka vann på NBA Finals ");
Console.WriteLine("A) Golden State Warriors");
Console.WriteLine("B) Clevland Cavaliers");
Console.WriteLine("C) LA Lakers");
string nba = Console.ReadLine();
if (nba == "B")
{
  Console.WriteLine("rätt");
  points = points + 3;
}
else
{
  Console.WriteLine("fel");
  points = points - 1;
}


Console.WriteLine($"du fick {points} poäng");

Console.WriteLine("Tryck på valfri knapp för att gå vidare");
Console.WriteLine("");

Console.ReadLine();

