using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Author author = new Author();
            //    Console.WriteLine(author.CountAuthors());
            //    Console.ReadLine();
            //}
            //catch(Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //    Console.ReadLine();
            //}


            try
            {
                Author author = new Author();
                foreach (string name in author.GetAuthorList())
                {
                    Console.WriteLine(name);
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
