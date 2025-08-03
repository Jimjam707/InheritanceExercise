using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var penguin = new Bird();
            penguin.Name = "Penguin";
            penguin.Age = 1;
            penguin.Color = "Black and white";
            penguin.LandSeaAir = "Land and sea";
            penguin.CanFly = false;
            penguin.CanSwim = true;
            penguin.WingSpan = 6.6;
            penguin.NativeBiome = "Antartic/Subantartic";
            
            Console.WriteLine("Bird Exhibit Info:");
            Console.WriteLine("====================");
            Console.WriteLine($"This bird is a {penguin.Name} and it is {penguin.Age} year(s) old. It is {penguin.Color} and live on/in the {penguin.LandSeaAir}.");
            Console.WriteLine($"Penguins can fly: {penguin.CanFly}. and can swim: {penguin.CanSwim}. Its average wing span is {penguin.WingSpan} feet.");
            Console.WriteLine($"The native biome for the penguin is {penguin.NativeBiome}.");
            Console.WriteLine();

            
            var snake = new Reptile();
            snake.Name = "Inland Taipan";
            snake.Age = 7;
            snake.Color = "Brown and Black";
            snake.LandSeaAir = "Land and air...Ever watched Snakes on a Plane?";
            snake.HasLegs = false;
            snake.HasVenom = true;
            snake.LivesIn = "Australia";
            snake.NativeBiome = "Semi-Arid";
            
            Console.WriteLine("Reptile Exhibit Info:");
            Console.WriteLine("=====================");
            Console.WriteLine($"This snake is a {snake.Name} and it is {snake.Age} year(s) old. It is {snake.Color} and live on/in the {snake.LandSeaAir}");
            Console.WriteLine($"This reptile has legs: {snake.HasLegs}. and is venemous: {snake.HasVenom}. It is native to {snake.LivesIn}.");
            Console.WriteLine($"The native biome for the reptile is {snake.NativeBiome}.");
        }
    }
}
