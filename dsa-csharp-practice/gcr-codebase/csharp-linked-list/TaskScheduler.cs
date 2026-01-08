using System;

namespace TaskSchedulerSystem
{
   
    // Task Node
   
    class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public TaskNode Next;

        public TaskNode(int id, string name, int priority, string dueDate)
        {
            TaskId = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    
    // Circular Linked List
    
    class TaskCircularList
    {
        private TaskNode head;
        private TaskNode current;

        // Add at End
        public void AddTask(int id, string name, int priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Remove by Task ID
        public void RemoveTask(int id)
        {
            if (head == null)
                return;

            TaskNode temp = head;
            TaskNode prev = null;

            do
            {
                if (temp.TaskId == id)
                {
                    if (prev != null)
                        prev.Next = temp.Next;
                    else
                    {
                        while (temp.Next != head)
                            temp = temp.Next;
                        temp.Next = head.Next;
                        head = head.Next;
                    }
                    Console.WriteLine("Task removed");
                    return;
                }
                prev = temp;
                temp = temp.Next;
            }
            while (temp != head);
        }

        // View Current Task
        public void ViewCurrentTask()
        {
            if (current != null)
            {
                Console.WriteLine("Current Task: " + current.TaskName);
                current = current.Next;
            }
        }

        // Search by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
                return;

            TaskNode temp = head;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine("Task Found: " + temp.TaskName);
                }
                temp = temp.Next;
            }
            while (temp != head);
        }

        // Display All Tasks
        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            Console.WriteLine("\nTasks:");
            do
            {
                Console.WriteLine(temp.TaskId + " " + temp.TaskName + " " + temp.Priority + " " + temp.DueDate);
                temp = temp.Next;
            }
            while (temp != head);
        }
    }

    class Program
    {
        static void Main()
        {
            TaskCircularList tasks = new TaskCircularList();

            tasks.AddTask(1, "Design", 1, "10-01-2026");
            tasks.AddTask(2, "Coding", 2, "12-01-2026");
            tasks.AddTask(3, "Testing", 1, "15-01-2026");

            tasks.DisplayTasks();
            tasks.ViewCurrentTask();
            tasks.ViewCurrentTask();

            tasks.SearchByPriority(1);
            tasks.RemoveTask(2);

            tasks.DisplayTasks();
        }
    }
}
