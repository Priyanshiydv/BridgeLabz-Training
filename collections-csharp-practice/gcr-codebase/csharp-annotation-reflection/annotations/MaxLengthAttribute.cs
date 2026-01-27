using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value { get; }
    public MaxLengthAttribute(int value) { Value = value; }
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        var field = typeof(User).GetField("Username");
        var attr = (MaxLengthAttribute)Attribute.GetCustomAttribute(field, typeof(MaxLengthAttribute));

        if (username.Length > attr.Value)
            throw new ArgumentException("Username too long!");

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        User u = new User("Priya"); // OK
    }
}
