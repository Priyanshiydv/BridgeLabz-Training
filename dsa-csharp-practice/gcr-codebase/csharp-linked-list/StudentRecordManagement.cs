using System;
namespace StudentLinkedListDemo
{
    // Student Node
    
    class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public string Grade;
        public StudentNode Next;

        public StudentNode(int rollNo, string name, int age, string grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

   
    // Singly Linked List
   
    class StudentLinkedList
    {
        private StudentNode head;

        // Add at Beginning
        public void AddAtBeginning(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        // Add at End
        public void AddAtEnd(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Add at Specific Position
        public void AddAtPosition(int position, int rollNo, string name, int age, string grade)
        {
            if (position <= 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            StudentNode temp = head;

            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Delete by Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student deleted");
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student deleted");
            }
        }

        // Search by Roll Number
        public void SearchStudent(int rollNo)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    Console.WriteLine("Student Found:");
                    Console.WriteLine("Roll No: " + temp.RollNo);
                    Console.WriteLine("Name: " + temp.Name);
                    Console.WriteLine("Age: " + temp.Age);
                    Console.WriteLine("Grade: " + temp.Grade);
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found");
        }

        // Update Grade
        public void UpdateGrade(int rollNo, string newGrade)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found");
        }

        // Display All Students
        public void DisplayStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available");
                return;
            }

            StudentNode temp = head;
            Console.WriteLine("\nStudent Records:");
            while (temp != null)
            {
                Console.WriteLine("Roll No: " + temp.RollNo +
                                  " Name: " + temp.Name +
                                  " Age: " + temp.Age +
                                  " Grade: " + temp.Grade);
                temp = temp.Next;
            }
        }
    }

   
    // Main Class
    
    class Program
    {
        static void Main()
        {
            StudentLinkedList list = new StudentLinkedList();

            list.AddAtBeginning(1, "Amit", 20, "A");
            list.AddAtEnd(2, "Riya", 21, "B");
            list.AddAtPosition(2, 3, "Neha", 22, "A+");

            list.DisplayStudents();

            list.SearchStudent(2);
            list.UpdateGrade(2, "A");
            list.DeleteByRollNo(1);

            list.DisplayStudents();
        }
    }
}
