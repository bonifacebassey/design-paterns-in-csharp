
using System.Diagnostics;
using ThreadSafe;

Stopwatch watch = new Stopwatch();
watch.Start();

Console.WriteLine("\nTesting for thread safety in a multithread environment\n");
Parallel.Invoke(
    () => ThreadInstance(),
    () => AnotherThreadInstance()
);

watch.Stop();
Console.WriteLine(watch.Elapsed);

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