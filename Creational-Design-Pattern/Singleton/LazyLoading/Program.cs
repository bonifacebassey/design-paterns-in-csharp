using LazyLoading;

Console.WriteLine("\nTesting for Lazy or Deferred Loading in a multithread environment\n");
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