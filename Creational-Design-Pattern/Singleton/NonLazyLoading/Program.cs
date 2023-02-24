using NonLazyLoading;

Console.WriteLine("\nTesting for Non-Lazy or Eager Loading in a multithread environment\n");
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