using System;

namespace vika1 
{ 
internal class Program
{
        private static void Main(string[] args)
        {
            string enterednum = "0";
            List<int> intList = new List<int>();
            int biggest = 0;
            int smallest = 0;
            int enteredint;
            while (enterednum != "")
            { 
        Console.WriteLine("Please enter a number: ");
                enterednum = Console.ReadLine();
                if (enterednum != "") {
                    if (int.TryParse(enterednum, out enteredint) == true) { 
                    intList.Add(enteredint);
                    biggest = intList.Max();
                    smallest = intList.Min();
                    Console.WriteLine($"You entered {enterednum}");
                    }
                }
            };
            Console.WriteLine($"Biggest number entered is {biggest} and smallest number entered is {smallest}");
        }
}
}