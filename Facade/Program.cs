using System;

namespace Facade;

/*
 * Owner is the Facade class
 */
internal class Contractor
{
    internal Contractor() { }

    internal void PerformAlteration() { }
}

/*
 * Owner is the Director class
 */
internal class Owner
{
    private readonly Bank _bank;

    private readonly Townhall _townhall;

    private readonly Contractor _contractor;

    internal Owner()
    {
        _bank = new Bank();
        _townhall = new Townhall();
        _contractor = new Contractor();
    }

    internal void PerformAlteration()
    {
        _bank.ArrangeLoan();
        _townhall.ArrangeLicense();
        _contractor.PerformAlteration();
    }
}

internal class Townhall
{
    internal Townhall() { }

    internal void ArrangeLicense() { }
}

internal class Bank
{
    internal Bank() { }

    internal void ArrangeLoan() { }
}

internal class Carpenter
{
    internal Carpenter() { }

    internal void InstallWindow() { } 

    internal void InstallDoor() { }
}

internal class Painter
{
    internal Painter() { }

    internal void RemoveOldPaint() { }

    internal void ApplyPaint() { }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}

