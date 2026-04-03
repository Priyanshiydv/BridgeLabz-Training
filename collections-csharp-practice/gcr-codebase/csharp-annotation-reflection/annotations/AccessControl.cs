using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role) { Role = role; }
}

class AdminPanel
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser() => Console.WriteLine("User deleted!");
}

class Program
{
    static string CurrentUserRole = "USER";

    static void Main()
    {
        var method = typeof(AdminPanel).GetMethod("DeleteUser");
        var attr = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attr.Role == CurrentUserRole)
            method.Invoke(new AdminPanel(), null);
        else
            Console.WriteLine("Access Denied!");
    }
}
