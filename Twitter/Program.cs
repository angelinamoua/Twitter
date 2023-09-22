using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();
            if (post.Length > 140) 
            {
                Console.WriteLine("Rejected");
                Console.ReadLine();
            } else if (post.Length <= 140) 
            {
                Console.WriteLine("Posted");
                Console.ReadLine();
            }
        }
    }
}
