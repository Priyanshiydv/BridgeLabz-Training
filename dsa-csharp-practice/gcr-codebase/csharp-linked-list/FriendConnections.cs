using System;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public string Friends;
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = "";
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public void AddUser(int id, string name, int age)
    {
        UserNode node = new UserNode(id, name, age);
        node.Next = head;
        head = node;
    }

    public void AddFriend(int id, int friendId)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
            {
                temp.Friends = temp.Friends + friendId + " ";
                Console.WriteLine("Friend added");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found");
    }

    public void DisplayFriends(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
            {
                Console.WriteLine("Friends of " + temp.Name + ": " + temp.Friends);
                return;
            }
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();

        sm.AddUser(1, "Amit", 20);
        sm.AddUser(2, "Ravi", 22);

        sm.AddFriend(1, 2);
        sm.DisplayFriends(1);
    }
}
