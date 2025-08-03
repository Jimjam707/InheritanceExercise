namespace Inheritance;

public class Reptile : Animal
{
    public bool HasLegs { get; set; }
    public bool HasVenom { get; set; }
    public string LivesIn { get; set; }
    public string NativeBiome { get; set; }

    public Reptile()
    {

    }

    public Reptile(string name, int age, string color, string landSeaAir, bool hasLegs, bool hasVenom, string livesIn,
        string nativeBiome)
    {
        Name = name;
        Age = age;
        Color = color;
        LandSeaAir = landSeaAir;
        HasLegs = hasLegs;
        HasVenom = hasVenom;
        LivesIn = livesIn;
        NativeBiome = nativeBiome;
    }
}    