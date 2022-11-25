namespace CoverageSample;

public static class AreaCalculator
{
    public static double Circle(double r)
    {
        if (r < 0) 
            throw new ArgumentOutOfRangeException(nameof(r));
        return r * r * Math.PI;
    }
}