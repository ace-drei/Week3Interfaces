using System;

using Shapes;

class Test
{
    public static void Main()
    {

        var spheres = new List<Sphere>
        {
            new (4),
            new (5),
            new (69)
        };
        foreach (Sphere s in spheres)
        {
            Console.WriteLine(s.ToString());
        }
       
    }
}