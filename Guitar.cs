namespace Instrumets
{
  public class GuitarSpec
  {
    private Wood backWood;
    private Wood topWood;
    private GuitarType type;
    private Builder builder;
    private string model;
    private int numStrings;
    public GuitarSpec(
      Builder builder,
      string model,
      GuitarType type,
      Wood backWood,
      Wood topWood,
      int numStrings
    )
    {
      this.builder = builder;
      this.model = model;
      this.type = type;
      this.backWood = backWood;
      this.topWood = topWood;
      this.numStrings = numStrings;
    }
    public Builder Builder
    {
      get
      {
        return builder;
      }
      set
      {
        builder = value;
      }
    }
    public string Model
    {
      get
      {
        return model;
      }
      set
      {
        model = value;
      }
    }
    public GuitarType Type
    {
      get
      {
        return type;
      }
      set
      {
        type = value;
      }
    }
    public Wood BackWood
    {
      get
      {
        return backWood;
      }
      set
      {
        backWood = value;
      }
    }
    public Wood TopWood
    {
      get
      {
        return topWood;
      }
      set
      {
        topWood = value;
      }
    }
    public int NumStrings
    {
      get
      {
        return numStrings;
      }
    }
    public bool Match(GuitarSpec mathSpec)
    {
      if (mathSpec.Builder != this.Builder)
      {
        return false;
      }
      if (!mathSpec.Model.ToLower().Equals(this.Model.ToLower()))
      {
        return false;
      }
      if (mathSpec.Type != this.Type)
      {
        return false;
      }
      if (mathSpec.BackWood != this.BackWood)
      {
        return false;
      }
      if (mathSpec.TopWood != this.TopWood)
      {
        return false;
      }
      if (!mathSpec.NumStrings.Equals(this.NumStrings)) {
        return false;
      }

      return true;
    }
  }
  public class GuitarInstrument
  {
    private string serialNumber;
    private double price;
    private GuitarSpec spec;


    public GuitarInstrument(
      string serialNumber,
      double price,
      GuitarSpec spec
    )
    {
      this.serialNumber = serialNumber;
      this.price = price;
      this.spec = spec;
    }
    public string SerialNumber
    {
      get
      {
        return serialNumber;
      }
    }
    public double Price
    {
      get
      {
        return price;
      }
      set
      {
        price = value;
      }
    }
    public GuitarSpec Spec
    {
      get
      {
        return spec;
      }
      set
      {
        spec = value;
      }
    }
  }
  public enum GuitarType
  {
    ACOUSTIC,
    ELECTRIC,
  }

  public enum Builder
  {
    FENDER,
    MARTIN,
    GIBSON,
    COLLINGS,
    OLSON,
    RYAN,
    PRS,
    ANY
  }

  public enum Wood
  {
    CEDAR,
    ALDER,
    SITKA,
    ADRONDACK,
    COCOBLO,
    MAPLE
  }
}