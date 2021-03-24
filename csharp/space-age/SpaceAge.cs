using System;

public class SpaceAge
{
    int Seconds;
    double earthSeconds = 31557600.00;
    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        double earthAge = Seconds / earthSeconds;
        return earthAge;
    }

    public double OnMercury()
    {
        double mercuryAge = (Seconds / earthSeconds) / 0.2408467;
        return mercuryAge;
    }

    public double OnVenus()
    {
        double venusAge = (Seconds / earthSeconds) / 0.61519726;
        return venusAge;
    }

    public double OnMars()
    {
        double marsAge = (Seconds / earthSeconds) / 1.8808158;
        return marsAge;
    }

    public double OnJupiter()
    {
        double jupterAge = (Seconds / earthSeconds) / 11.862615;
        return jupterAge;
    }

    public double OnSaturn()
    {
        double saturnoAge = (Seconds / earthSeconds) / 29.447498;
        return saturnoAge;
    }

    public double OnUranus()
    {
        double uranusAge = (Seconds / earthSeconds) / 84.016846;
        return uranusAge;
    }

    public double OnNeptune()
    {
        double neptuneAge = (Seconds / earthSeconds) / 164.79132;
        return neptuneAge;
    }
}