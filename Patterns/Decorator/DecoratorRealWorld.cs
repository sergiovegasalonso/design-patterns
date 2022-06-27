namespace RealWorld.Decorator;

/// <summary>
/// The 'Component' abstract class
/// </summary>
public abstract class LibraryItem
{
    private int numCopies;
    public int NumCopies
    {
        get { return numCopies; }
        set { numCopies = value; }
    }
    public abstract void Display();
}

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Book : LibraryItem
{
    private string author;
    private string title;

    // Constructor
    public Book(string author, string title, int numCopies)
    {
        this.author = author;
        this.title = title;
        this.NumCopies = numCopies;
    }
    public override void Display()
    {
        Console.WriteLine("\nBook ------ ");
        Console.WriteLine(" Author: {0}", author);
        Console.WriteLine(" Title: {0}", title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
    }
}

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Video : LibraryItem
{
    private string director;
    private string title;
    private int playTime;

    // Constructor
    public Video(string director, string title, int numCopies, int playTime)
    {
        this.director = director;
        this.title = title;
        this.NumCopies = numCopies;
        this.playTime = playTime;
    }

    public override void Display()
    {
        Console.WriteLine("\nVideo ----- ");
        Console.WriteLine(" Director: {0}", director);
        Console.WriteLine(" Title: {0}", title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
        Console.WriteLine(" Playtime: {0}\n", playTime);
    }
}
/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class Decorator : LibraryItem
{
    protected LibraryItem libraryItem;

    // Constructor
    public Decorator(LibraryItem libraryItem)
    {
        this.libraryItem = libraryItem;
    }

    public override void Display()
    {
        libraryItem.Display();
    }
}
/// <summary>
/// The 'ConcreteDecorator' class
/// </summary>
public class Borrowable : Decorator
{
    protected readonly List<string> borrowers = new List<string>();

    // Constructor
    public Borrowable(LibraryItem libraryItem)
        : base(libraryItem)
    {
    }

    public void BorrowItem(string name)
    {
        borrowers.Add(name);
        libraryItem.NumCopies--;
    }

    public void ReturnItem(string name)
    {
        borrowers.Remove(name);
        libraryItem.NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        foreach (string borrower in borrowers)
        {
            Console.WriteLine(" borrower: " + borrower);
        }
    }
}