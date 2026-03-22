// =============================================================
// PHASE 2 — Concept 1: What is a Task?
// =============================================================

Console.WriteLine("=== Thread vs Task — The Real Difference ===\n");

// Raw Threads — each gets a BRAND NEW thread
Console.WriteLine("--- Raw Threads ---");
for (int i = 1; i <= 5; i++)
{
    int num = i;
    Thread t = new Thread(() =>
    {
        Console.WriteLine($"  Thread {num} — ID: {Environment.CurrentManagedThreadId}");
    });
    t.Start();
    t.Join();
}

// Tasks — watch thread IDs get REUSED
Console.WriteLine("\n--- Tasks ---");
for (int i = 1; i <= 5; i++)
{
    int num = i;
    await Task.Run(() =>
    {
        Console.WriteLine($"  Task {num} — ID: {Environment.CurrentManagedThreadId}");
    });
}

await Task.Delay(500); // give tasks time to finish
Console.WriteLine("Done!");