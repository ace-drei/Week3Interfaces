using System;
namespace Shapes;

interface IHasVolume
{
    double HasVolume();
}

public class Sphere : IHasVolume
{
    //field to store radius
    private double radius;

    //Making sure Radius is postive
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
                radius = value;
            else
                throw new ArgumentException("Radius must be positive.");
        }
    }

    public Sphere(double radius)
    {
        this.Radius = radius;
    }



    //overrides volume
    public double HasVolume()
    {
        return Math.PI * radius * radius * radius;
    }


    //Creates constructor in Sphere 
  
    public override string ToString()
    {
        return  "Radius = " + radius + " \nCalculate volume =  " + HasVolume();
    }

}

