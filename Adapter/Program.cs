public class RoundPeg
{
    private readonly double _radius;

    public RoundPeg(double radius) => _radius = radius;

    public double GetRadius() => _radius;
}

public class RoundHole
{
    private readonly double _radius;

    public RoundHole(double radius) => _radius = radius;

    public double GetRadius() => _radius;

    public bool Fits(RoundPeg peg) => _radius >= peg.GetRadius();
}

public class SquarePeg
{
    public readonly double _width;

    public SquarePeg(double width) => _width = width;

    public double GetWidth() => _width;
}

public class SquarePegAdapter : RoundPeg
{
    private readonly SquarePeg _peg;

    public SquarePegAdapter(SquarePeg peg) : base(peg.GetWidth() * Math.Sqrt(2) / 2)
    {
        _peg = peg;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var hole = new RoundHole(5);
        var roundPeg = new RoundPeg(5);
        Console.WriteLine(hole.Fits(roundPeg));

        var smallSquarePeg = new SquarePeg(5);
        var largeSquarePeg = new SquarePeg(10);
        var smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
        var largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);
        Console.WriteLine(hole.Fits(smallSquarePegAdapter));
        Console.WriteLine(hole.Fits(largeSquarePegAdapter));
    }
}