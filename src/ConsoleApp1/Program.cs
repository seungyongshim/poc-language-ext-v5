using ConsoleApp1;
using LanguageExt;
using static LanguageExt.Prelude;


var effect =
    from _A in use(static envIO => new Disposable("4"))
    from _B in (from _1 in use(() => new Disposable("1"))
                from _2 in use(() => new Disposable("2"))
                from _3 in use(() => new Disposable("3"))
                from _5 in liftIO(env =>
                {
                    throw new Exception("what");
                })
                //from _4 in release(_3)
                select unit)
    select unit;


var ret = effect.RunAsync();



public class A : IDisposable
{
    public void Dispose() => Console.Write("A");
}

public class B : IDisposable
{
    public void Dispose() => Console.Write("B");
}
