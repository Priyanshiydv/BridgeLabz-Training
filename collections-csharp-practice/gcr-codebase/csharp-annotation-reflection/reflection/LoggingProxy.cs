using System;
using System.Reflection;

// 1️⃣ Interface
public interface IGreeting
{
    void SayHello();
}

// 2️⃣ Original Class
public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello from Greeting class!");
    }
}

// 3️⃣ Logging Proxy using DispatchProxy
public class LoggingProxy<T> : DispatchProxy
{
    public T Target; // Original object

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine("Method Invoked: " + targetMethod.Name);

        // Call original method
        return targetMethod.Invoke(Target, args);
    }
}

// 4️⃣ Main Program
class Program
{
    static void Main()
    {
        // Original object
        IGreeting original = new Greeting();

        // Create proxy
        IGreeting proxy = DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

        // Set target
        ((LoggingProxy<IGreeting>)proxy).Target = original;

        // Call method
        proxy.SayHello();
    }
}
