using System;
//06-01-2026
// CallLog class
class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;

    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        PhoneNumber = phoneNumber;
        Message = message;
        TimeStamp = timeStamp;
    }

    public void Display()
    {
        Console.WriteLine("Phone: " + PhoneNumber +
                          ", Message: " + Message +
                          ", Time: " + TimeStamp);
    }
}

// Manager class
class CallLogManager
{
    CallLog[] logs = new CallLog[10];   // Array to store call logs
    int count = 0;

    // Add new call log
    public void AddCallLog(string phone, string message, DateTime time)
    {
        if (count < logs.Length)
        {
            logs[count] = new CallLog(phone, message, time);
            count++;
            Console.WriteLine("Call log added successfully.");
        }
        else
        {
            Console.WriteLine("Call log storage is full.");
        }
    }

    // Search logs by keyword in message
    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine("\nSearching logs with keyword: " + keyword);

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
            }
        }
    }

    // Filter logs by time range
    public void FilterByTime(DateTime startTime, DateTime endTime)
    {
        Console.WriteLine("\nLogs between " + startTime + " and " + endTime);

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= startTime && logs[i].TimeStamp <= endTime)
            {
                logs[i].Display();
            }
        }
    }
}

// Main class
class TelecomApp
{
    static void Main(string[] args)
    {
        CallLogManager manager = new CallLogManager();

        // Adding call logs
        manager.AddCallLog("9876543210", "Network issue reported",
                           DateTime.Now.AddHours(-3));

        manager.AddCallLog("9123456780", "Billing related query",
                           DateTime.Now.AddHours(-1));

        manager.AddCallLog("9988776655", "Internet speed problem",
                           DateTime.Now);

        // Search by keyword
        manager.SearchByKeyword("Network");

        // Filter by time range
        DateTime start = DateTime.Now.AddHours(-2);
        DateTime end = DateTime.Now;

        manager.FilterByTime(start, end);
    }
}
