using System;
using System.Reflection;

// Custom Inject Attribute
[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

// Service Class
class MessageService
{
    public void SendMessage()
    {
        Console.WriteLine("Message Sent!");
    }
}

// Client Class
class Client
{
    [Inject]
    private MessageService service;

    public void Start()
    {
        service.SendMessage();
    }
}

// Simple DI Container
class DIContainer
{
    public static T CreateObject<T>() where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        FieldInfo[] fields = type.GetFields(
            BindingFlags.NonPublic | BindingFlags.Instance);

        for (int i = 0; i < fields.Length; i++)
        {
            if (Attribute.IsDefined(fields[i], typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(fields[i].FieldType);
                fields[i].SetValue(obj, dependency);
            }
        }
        return obj;
    }
}

// Main
class SimpleDIContainer
{
    static void Main()
    {
        Client client = DIContainer.CreateObject<Client>();
        client.Start();
    }
}
