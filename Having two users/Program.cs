using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Having_two_users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get User 1 details
            Console.Write("Enter name for User 1: ");
            string user1Name = Console.ReadLine();
            Console.Write("Enter age for User 1: ");
            int user1Age = int.Parse(Console.ReadLine());

            // Get User 2 details
            Console.Write("Enter name for User 2: ");
            string user2Name = Console.ReadLine();
            Console.Write("Enter age for User 2: ");
            int user2Age = int.Parse(Console.ReadLine());

            // Print out the details
            Console.WriteLine("\nUser 1:");
            Console.WriteLine($"Name: {user1Name}");
            Console.WriteLine($"Age: {user1Age}");

            Console.WriteLine("\nUser 2:");
            Console.WriteLine($"Name: {user2Name}");
            Console.WriteLine($"Age: {user2Age}");
        }
    }
}
