using System;
class EarthVolume
{
    static void Main(string[] args)
    {
        double radiusKm = 6378;
        double pi = Math.PI;
        double volumeKm = (4.0 / 3.0) * pi * radiusKm * radiusKm * radiusKm;
        double radiusMiles = radiusKm * 0.621371;
        double volumeMiles = (4.0 / 3.0) * pi * radiusMiles * radiusMiles * radiusMiles;

        Console.WriteLine(
            "The volume of earth in cubic kilometers is " + volumeKm +
            " and cubic miles is " + volumeMiles
        );
    }
}
