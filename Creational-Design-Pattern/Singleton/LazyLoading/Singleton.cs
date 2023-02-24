namespace LazyLoading;

/// <summary>
///  Lazy/Deferred Loading is used to delay the initialization of an object until the point at which it is needed.
///  Use Lazy loading when the cost of the object creation is very high or the use of that object is very rare.
/// </summary>
public sealed class Singleton
{
    private static int counter = 0;

    private Singleton()
    {
        counter++;
        Console.WriteLine($"Singleton object instances: {counter}");
    }

    private static readonly Lazy<Singleton> InstanceLock = new Lazy<Singleton>(() => new Singleton());

    public static Singleton GetInstance
    {
        get
        {
            return InstanceLock.Value;
        }
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
