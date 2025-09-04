using static System.Console;
using System.Threading.Tasks;

async Task Task1()
{
    await Task.Run(async () =>
    {
        WriteLine("Task1 is executing...");
        await Task.Delay(4000);
        WriteLine("Task1 is Completed!");
    });
}

async Task Task2()
{
    await Task.Run(async () =>
    {
        WriteLine("Task2 is executing...");
        await Task.Delay(2000);
        WriteLine("Task2 is Completed!");
    });
}

async Task Task3()
{
    await Task.Run(async () =>
    {
        WriteLine("Task3 is executing...");
        await Task.Delay(5000);
        WriteLine("Task3 is Completed!");
    });
}

async Task Task4()
{
    await Task.Run(async () =>
    {
        WriteLine("Task4 is executing...");
        await Task.Delay(1000);
        WriteLine("Task4 is Completed!");
    });
}

// Entry point must be async if you're awaiting
await Task.WhenAll(Task1(), Task2(), Task3(), Task4());



