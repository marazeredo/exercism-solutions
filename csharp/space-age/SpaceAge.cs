using System;

public class SpaceAge
{
    private int _seconds;
    private double earthSeconds = 31557600.00;
    private struct OrbitalPeriodInEarthYears
    {
        public const double Mercury = 0.2408467d;
        public const double Venus = 0.61519726d;
        public const double Mars = 1.8808158d;
        public const double Jupiter = 11.862615d;
        public const double Saturn = 29.447498d;
        public const double Uranus = 84.016846d;
        public const double Neptune = 164.79132d;
    }

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() =>
        _seconds / earthSeconds;

    public double OnMercury() =>
        OnEarth() / OrbitalPeriodInEarthYears.Mercury;

    public double OnVenus() =>
        OnEarth() / OrbitalPeriodInEarthYears.Venus;

    public double OnMars() =>
        OnEarth() / OrbitalPeriodInEarthYears.Mars;

    public double OnJupiter() =>
        OnEarth() / OrbitalPeriodInEarthYears.Jupiter;

    public double OnSaturn() =>
        OnEarth() / OrbitalPeriodInEarthYears.Saturn;

    public double OnUranus() =>
        OnEarth() / OrbitalPeriodInEarthYears.Uranus;

    public double OnNeptune() =>
        OnEarth() / OrbitalPeriodInEarthYears.Neptune;
}