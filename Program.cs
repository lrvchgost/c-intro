using System;
using Instrumets;
using Store;

namespace Guitar
{
  class Prgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Start");

      Inventory inventory = new Inventory();

      inventory.AddGuitar("serial1", 100, Builder.FENDER, "fender", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ADRONDACK, 6);
      inventory.AddGuitar("serial2", 100, Builder.FENDER, "stratocaster", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ADRONDACK, 6);
      inventory.AddGuitar("serial3", 100, Builder.FENDER, "he", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ADRONDACK, 6);

      GuitarInstrument? guitar = inventory.GetGuitar("serial");

      Console.WriteLine(guitar?.Spec.Builder ?? null);

      List<GuitarInstrument> search = inventory.Search(new GuitarSpec(Builder.FENDER, "Fender", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ADRONDACK, 6));

      foreach (GuitarInstrument g in search)
      {
        Console.WriteLine(g.Spec.Builder);
      }
    }
  }
}
