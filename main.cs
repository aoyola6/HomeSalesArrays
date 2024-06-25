using System;
using System.Linq;
namespace HomeSales{
  
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salesperson's initials (D, E, or F). Enter 'done' when finished:");
            string input = "";
            char[] validInitials = { 'D', 'E', 'F' };
            int grandTotal = 0;

            while ((input = Console.ReadLine())!= "done")
            {
                input = input.ToUpper();
                if (validInitials.Contains(input[0]))
                {
                    Console.WriteLine("Enter the sales value:");
                    string salesValueStr = Console.ReadLine();
                    int salesValue;
                    if (int.TryParse(salesValueStr, out salesValue))
                    {
                        grandTotal += salesValue;
                        Console.WriteLine($"Added sales value {salesValue} for {input}. Current grand total: {grandTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid sales value. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid initial. Please enter D, E, or F.");
                }
            }

            Console.WriteLine($"Final grand total: {grandTotal}");
            Console.ReadKey();
        }
    }

