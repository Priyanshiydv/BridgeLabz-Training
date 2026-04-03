using System;

class ProcessNode
{
    public int Pid;
    public int BurstTime;
    public int RemainingTime;
    public ProcessNode Next;

    public ProcessNode(int pid, int burst)
    {
        Pid = pid;
        BurstTime = burst;
        RemainingTime = burst;
        Next = null;
    }
}

class RoundRobin
{
    private ProcessNode head;

    public void AddProcess(int pid, int burst)
    {
        ProcessNode node = new ProcessNode(pid, burst);

        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }

    public void Schedule(int quantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes");
            return;
        }

        ProcessNode temp = head;
        bool done;

        do
        {
            done = true;
            ProcessNode curr = temp;

            do
            {
                if (curr.RemainingTime > 0)
                {
                    done = false;

                    if (curr.RemainingTime > quantum)
                    {
                        curr.RemainingTime -= quantum;
                        Console.WriteLine("Process " + curr.Pid + " executed for " + quantum);
                    }
                    else
                    {
                        Console.WriteLine("Process " + curr.Pid + " completed");
                        curr.RemainingTime = 0;
                    }
                }
                curr = curr.Next;
            } while (curr != temp);

        } while (!done);
    }
}

class Program
{
    static void Main()
    {
        RoundRobin rr = new RoundRobin();

        rr.AddProcess(1, 10);
        rr.AddProcess(2, 5);
        rr.AddProcess(3, 8);

        rr.Schedule(3);
    }
}
