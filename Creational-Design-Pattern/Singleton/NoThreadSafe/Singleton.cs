namespace NoThreadSafe;

public sealed class Singleton
{
    private static int counter = 0;
    private static Singleton? instance;

    private Singleton()
    {
        counter++;
        Console.WriteLine($"Singleton object instances: {counter}");
    }

    public static Singleton GetInstance { 
        get { 
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance; 
        } 
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
