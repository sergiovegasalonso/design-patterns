namespace Structural.Decorator;

/// <summary>
/// The 'Component' abstract class
/// </summary>
public abstract class Component
{
    public abstract void Operation();
}

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent.Operation()");
    }
}

/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class Decorator : Component
{
    protected Component? _component;

    public void SetComponent(Component component)
    {
        _component = component;
    }

    public override void Operation()
    {
        if (_component != null)
        {
            _component.Operation();
        }
    }
}

/// <summary>
/// The 'ConcreteDecoratorA' class
/// </summary>
public class ConcreteDecoratorA : Decorator
{
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
}

/// <summary>
/// The 'ConcreteDecoratorB' class
/// </summary>
public class ConcreteDecoratorB : Decorator
{
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
        Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
    }
}