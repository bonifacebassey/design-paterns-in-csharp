namespace ThreadSafe;

/// <summary>
/// Thread-safe Singleton Design Pattern in C# using locks to handle the multithreaded environment.
/// </summary>
public sealed class Singleton
{
    private static int counter = 0;
    private static Singleton? instance;
    private static readonly object instanceLock = new object();

    private Singleton()
    {
        counter++;
        Console.WriteLine($"Singleton object instances: {counter}");
    }

    public static Singleton GetInstance 
    { 
        get
        {
            if (instance == null) // Double-checked locking mechanism for improved performance
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
