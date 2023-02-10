using System;
using System.Reflection;

class Program
{
    static List<int> MakeList(int tal)
    {
        List<int> AllaTal = new List<int>();
        for (int i = 0; i < tal; i++)
        {
            AllaTal.Add(i);
        }
        return AllaTal;

    }
    static int PrimtalsUndersökarn(int tal)
    {
        List<int> AllaTal = MakeList(tal);
        for (int i = 2; i < AllaTal.Count(); i++) // Väljer tal att dela på
        {
            for (int j = 0; j < AllaTal.Count(); j++) //Väljer talet som ska delas
            {
                if (AllaTal[j] % i == 0)
                {
                    AllaTal.RemoveAt(j);
                }
            }

        }
        return AllaTal.Count();
    }
    static void Main()
    {
        Console.WriteLine("Skriv ett tal så undersöker vi om det är ett primtal");
        int tal = int.Parse(Console.ReadLine());
        Console.WriteLine("Det finns: " + PrimtalsUndersökarn(tal));

    }
}
