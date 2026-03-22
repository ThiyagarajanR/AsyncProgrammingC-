// =============================================================
// PHASE 1 — Concept 1: What is a Thread?
// =============================================================

Console.WriteLine("=== What is a Thread? ===\n");

Console.WriteLine($"Main thread ID: {Environment.CurrentManagedThreadId}");
Console.WriteLine("Main thread starts doing work...\n");

// Creating a new thread
Thread thread1 = new Thread(() =>
{
    Console.WriteLine($"  Thread1 started  — ID: {Environment.CurrentManagedThreadId}");
    Thread.Sleep(2000); // simulate doing some work for 2 seconds
    Console.WriteLine($"  Thread1 finished — ID: {Environment.CurrentManagedThreadId}");
});

thread1.Start();

Console.WriteLine("Main thread is still running while Thread1 works...");
Console.WriteLine("Main thread doing its own work...");


Console.WriteLine("\nMain thread: Thread1 has finished, continuing now.");


thread1.Join(); // Main thread waits here until thread1 finishes

// =============================================================
// PHASE 1 — Concept 2: What is a Task?
// =============================================================

Console.WriteLine("=== What is a Task? ===\n");

Console.WriteLine($"Main thread ID: {Environment.CurrentManagedThreadId}");

var task = Task.Run(() =>
{
    Console.WriteLine($"  Task started  — ID: {Environment.CurrentManagedThreadId}");
    Thread.Sleep(2000); // simulate doing some work for 2 seconds
    Console.WriteLine($"  Task finished — ID: {Environment.CurrentManagedThreadId}");
});
Console.WriteLine("Main thread is still running while Task works...");

task.Wait(); // same as thread1.Join()

Console.WriteLine("Main thread: Task has finished.");

