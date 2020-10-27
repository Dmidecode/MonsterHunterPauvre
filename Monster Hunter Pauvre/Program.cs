using System;

namespace Monster_Hunter_Pauvre
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenue sur Monster Hunter !");
      Console.WriteLine("Appuyez sur entrée pour commencer...");
      Console.ReadLine();
      Console.WriteLine("Choisissez une map:");
      Console.WriteLine("\t1 - Foret");
      Console.WriteLine("\t2 - Neige");
      Console.WriteLine("\t3 - Volcan");
      Console.WriteLine("\t4 - Désert");
      var map = Console.ReadLine();
      Console.WriteLine("Choisissez une arme:");
      Console.WriteLine("\t1 - Long sword");
      Console.WriteLine("\t2 - Great sword");
      Console.WriteLine("\t3 - Arbalète");
      Console.WriteLine("\t4 - Switch axe");
      var arme = Console.ReadLine();
      Console.WriteLine($"Vous avez choisi: { map } et { arme }");
    }
  }
}
