using System;

namespace Inheritance;

public class Bird : Animal
{
    public bool CanFly { get; set; }
    public bool CanSwim { get; set; }
    public double WingSpan { get; set; }
    public string NativeBiome { get; set; }
    
    public Bird()
    {
        
    }

    public Bird(string name, int age, string color, string landSeaAir, bool canFly, bool canSwim, double wingSpan, string nativeBiome)
    {
        Name = name;
        Age = age;
        Color = color;
        LandSeaAir = landSeaAir;
        CanFly = canFly;
        CanSwim = canSwim;
        WingSpan = wingSpan;
        NativeBiome = nativeBiome;

    }
}