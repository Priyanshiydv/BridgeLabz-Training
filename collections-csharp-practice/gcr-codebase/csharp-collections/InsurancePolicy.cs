using System;
using System.Collections.Generic;

class InsurancePolicy
{
    // Policy model
    class Policy
    {
        public int PolicyNumber;
        public string HolderName;
        public string CoverageType;
        public DateTime ExpiryDate;

        public Policy(int number, string name, string coverage, DateTime expiry)
        {
            PolicyNumber = number;
            HolderName = name;
            CoverageType = coverage;
            ExpiryDate = expiry;
        }
    }

    static void Main()
    {
        // HashSet → unique policy numbers (quick lookup)
        HashSet<int> uniquePolicyNumbers = new HashSet<int>();

        // LinkedHashSet equivalent → preserves insertion order
        List<Policy> insertionOrderPolicies = new List<Policy>();

        // SortedSet → sorted by expiry date
        SortedSet<Policy> sortedPolicies =
            new SortedSet<Policy>(new ExpiryComparer());

        AddPolicy(101, "Ravi", "Health", DateTime.Now.AddDays(20),
                  uniquePolicyNumbers, insertionOrderPolicies, sortedPolicies);

        AddPolicy(102, "Asha", "Life", DateTime.Now.AddDays(40),
                  uniquePolicyNumbers, insertionOrderPolicies, sortedPolicies);

        AddPolicy(103, "Neha", "Vehicle", DateTime.Now.AddDays(10),
                  uniquePolicyNumbers, insertionOrderPolicies, sortedPolicies);

        AddPolicy(101, "Duplicate", "Health", DateTime.Now.AddDays(15),
                  uniquePolicyNumbers, insertionOrderPolicies, sortedPolicies);

        Console.WriteLine("\n--- All Unique Policies (Insertion Order) ---");
        for (int i = 0; i < insertionOrderPolicies.Count; i++)
        {
            Display(insertionOrderPolicies[i]);
        }

        Console.WriteLine("\n--- Policies Expiring Within 30 Days ---");
        DateTime limit = DateTime.Now.AddDays(30);

        Policy[] sortedArray = new Policy[sortedPolicies.Count];
        sortedPolicies.CopyTo(sortedArray);

        for (int i = 0; i < sortedArray.Length; i++)
        {
            if (sortedArray[i].ExpiryDate <= limit)
            {
                Display(sortedArray[i]);
            }
        }

        Console.WriteLine("\n--- Policies with Health Coverage ---");
        for (int i = 0; i < insertionOrderPolicies.Count; i++)
        {
            if (insertionOrderPolicies[i].CoverageType == "Health")
            {
                Display(insertionOrderPolicies[i]);
            }
        }
    }

    static void AddPolicy(
        int number,
        string name,
        string coverage,
        DateTime expiry,
        HashSet<int> uniqueSet,
        List<Policy> insertionList,
        SortedSet<Policy> sortedSet)
    {
        if (uniqueSet.Contains(number))
        {
            Console.WriteLine("Duplicate Policy Found: " + number);
            return;
        }

        Policy policy = new Policy(number, name, coverage, expiry);
        uniqueSet.Add(number);
        insertionList.Add(policy);
        sortedSet.Add(policy);
    }

    static void Display(Policy p)
    {
        Console.WriteLine(
            "PolicyNo: " + p.PolicyNumber +
            ", Name: " + p.HolderName +
            ", Coverage: " + p.CoverageType +
            ", Expiry: " + p.ExpiryDate.ToShortDateString()
        );
    }

    // Comparator for SortedSet (TreeSet equivalent)
    class ExpiryComparer : IComparer<Policy>
    {
        public int Compare(Policy x, Policy y)
        {
            int result = x.ExpiryDate.CompareTo(y.ExpiryDate);
            if (result == 0)
                return x.PolicyNumber.CompareTo(y.PolicyNumber);
            return result;
        }
    }
}
