namespace ConsoleApp1;


public class Disposable(string uid) : IDisposable, IAsyncDisposable
{
    public void Dispose() => Console.WriteLine($"{uid} Disposed");

    public async ValueTask DisposeAsync()
    {
        Console.WriteLine($"{uid} DisposedAsync");
        Dispose();
        await Task.CompletedTask.ConfigureAwait(false);
    }
}
