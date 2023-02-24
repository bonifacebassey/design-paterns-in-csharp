//#define MULTITHREAD

using NoThreadSafe;

#if MULTITHREAD

    Console.WriteLine("\nTesting for thread safety in a multithread environment\n");
    Parallel.Invoke(
        () => ThreadInstance(),
        () => AnotherThreadInstance()
    );

    void ThreadInstance()
    {
        Singleton singleton = Singleton.GetInstance;
        singleton.PrintDetails("From thread instance");
    }
    
    void AnotherThreadInstance()
    {
        Singleton singleton = Singleton.GetInstance;
        singleton.PrintDetails("From another thread instance");
    }

#else

    Singleton instance = Singleton.GetInstance;
    instance.PrintDetails("Calling from Instance");
    
    Singleton anotherInstance = Singleton.GetInstance;
    anotherInstance.PrintDetails("Calling from another Instance");

#endif
