using System;

public class SpaceAge
{
    int Seconds;
    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        double earthAge = Seconds / 31557600.00;
        return earthAge;
    }

    public double OnMercury()
    {
        double mercuryAge = (Seconds / 31557600.00) / 0.2408467;
        return mercuryAge;
    }

    public double OnVenus()
    {
        double venusAge = (Seconds / 31557600.00) / 0.61519726;
        return venusAge;
    }

    public double OnMars()
    {
        double marsAge = (Seconds / 31557600.00) / 1.8808158;
        return marsAge;
    }

    public double OnJupiter()
    {
        double jupterAge = (Seconds / 31557600.00) / 11.862615;
        return jupterAge;
    }

    public double OnSaturn()
    {
        double saturnoAge = (Seconds / 31557600.00) / 29.447498;
        return saturnoAge;
    }

    public double OnUranus()
    {
        double uranusAge = (Seconds / 31557600.00) / 84.016846;
        return uranusAge;
    }

    public double OnNeptune()
    {
        double neptuneAge = (Seconds / 31557600.00) / 164.79132;
        return neptuneAge;
    }
}