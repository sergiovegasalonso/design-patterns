using RealWorld.Decorator;
using Structural.Decorator;

// Decorator
// =========

// Create ConcreteComponent and two Decorators
ConcreteComponent c = new ConcreteComponent();
ConcreteDecoratorA d1 = new ConcreteDecoratorA();
ConcreteDecoratorB d2 = new ConcreteDecoratorB();

// Link decorators
d1.SetComponent(c);
d2.SetComponent(d1);
d2.Operation();

// Wait for user
Console.ReadKey();

// Decorator: real-world
// =========

// Create book
Book book = new Book("Worley", "Inside ASP.NET", 10);
book.Display();
// Create video
Video video = new Video("Spielberg", "Jaws", 23, 92);
video.Display();
// Make video borrowable, then borrow and display
Console.WriteLine("\nMaking video borrowable:");
Borrowable borrowvideo = new Borrowable(video);
borrowvideo.BorrowItem("Customer #1");
borrowvideo.BorrowItem("Customer #2");
borrowvideo.Display();
// Wait for user
Console.ReadKey();