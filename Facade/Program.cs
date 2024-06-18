namespace Facade;

/*
 * Owner is the Facade class
 */
public class Contractor
{
    private readonly Carpenter _carpenter;
    private readonly Painter _painter;

    public Contractor()
    {
        _carpenter = new Carpenter();
        _painter = new Painter();
    }

    public void PerformAlteration()
    {
        _carpenter.InstallDoor();
        _carpenter.InstallWindow();
        _painter.RemoveOldPaint();
        _painter.ApplyPaint();
    }
}

/*
 * Owner is the Director class
 */
public class Owner
{
    private readonly Bank _bank;
    private readonly Townhall _townhall;
    private readonly Contractor _contractor;

    public Owner()
    {
        _bank = new Bank();
        _townhall = new Townhall();
        _contractor = new Contractor();
    }

    public void PerformAlteration()
    {
        _bank.ArrangeLoan();
        _townhall.ArrangeLicense();
        _contractor.PerformAlteration();
    }
}

public class Townhall
{
    public Townhall() { }

    public void ArrangeLicense()
    {
        Console.WriteLine("License arranged!");
    }
}

public class Bank
{
    public Bank() { }

    public void ArrangeLoan()
    {
        Console.WriteLine("Loan arranged!");
    }
}

public class Carpenter
{
    public Carpenter() { }

    public void InstallWindow()
    {
        Console.WriteLine("Window installed!");
    }

    public void InstallDoor()
    {
        Console.WriteLine("Door installed!");
    }
}

public class Painter
{
    public Painter() { }

    public void RemoveOldPaint()
    {

        Console.WriteLine("Old paint removed!");
    }

    public void ApplyPaint()
    {
        Console.WriteLine("New paint applied!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var owner = new Owner();
        owner.PerformAlteration();
    }
}

