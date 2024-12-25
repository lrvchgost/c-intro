using Instrumets;

namespace Store
{
  public class Inventory
  {
    private List<GuitarInstrument> Guitars = new();
    public Inventory() { }

    public void AddGuitar(
      string serialNumber,
      double price,
      Builder builder,
      string model,
      GuitarType type,
      Wood backWood,
      Wood topWood,
      int numStrings
    )
    {
      GuitarInstrument guitar = new GuitarInstrument(
        serialNumber,
        price,
        new GuitarSpec(
          builder,
          model,
          type,
          backWood,
          topWood,
          numStrings
        )
      );

      Guitars.Add(guitar);
    }

    public GuitarInstrument? GetGuitar(string serialNumber)
    {
      foreach (var guitar in Guitars)
      {
        if (guitar.SerialNumber.Equals(serialNumber))
        {
          return guitar;
        }
      }

      return null;
    }

    public List<GuitarInstrument> Search(GuitarSpec searhGuitar)
    {
      List<GuitarInstrument> result = new();

      foreach (var guitar in Guitars)
      {
        if (guitar.Spec.Match(searhGuitar))
        {
          result.Add(guitar);
        }
      }

      return result;
    }
  }
}