namespace NonLazyLoading;

/// <summary>
/// Non-Lazy/Eager loading  in the singleton design pattern is a process in which the singleton object is 
/// initialized at the time of application start-up rather than on-demand.
/// </summary>
public sealed class Singleton
{
    private static int counter = 0;

    private Singleton() 
    {
        counter++;
        Console.WriteLine($"Singleton object instances: {counter}");
    }

    private static readonly Singleton instance = new Singleton();

    public static Singleton GetInstance
    {
        get 
        { 
            return instance; 
        } 
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
