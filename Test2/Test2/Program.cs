using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Birds
    {

        public string birds;
        public string species;
        public string Sex;
        public int Weight;
        public int bandno;

    }
    class Program//pubic string and int for variables
    {
        public static void Main(string[] args) //main is not allowing program to run

        {

            String Birds = "Name Unknown";
            String Species = "species unknown";
            String Sex = "Sex unknown";
            String Weight = "Weight unkown";
            String Bandno = "Bandno Unkown";


            //code for writing the program
            Console.WriteLine("Birds objects created and defaulted data loaded...");
            Console.WriteLine();
            Console.WriteLine("please update bird data");
            Console.WriteLine();
            Console.WriteLine("Enter Birds Name: " + Birds);
            Birds = Console.ReadLine();
            Console.WriteLine("Enter Birds Species: " + Species);
            Species = Console.ReadLine();
            Console.WriteLine("Enter birds Sex: " + Sex);
            Sex = Console.ReadLine();
            Console.WriteLine("Enter birds Weight: " + Weight);
            Weight = Console.ReadLine();
            Console.WriteLine("Enter Birds Bandno: " + Bandno);
            Bandno = Console.ReadLine();
            Console.WriteLine();

            //code for returning the program
            Console.WriteLine();
            Console.WriteLine("Birds name: " + Birds);
            Console.WriteLine("Birds Species: " + Species);
            Console.WriteLine("Birds Sex: " + Sex);
            Console.WriteLine("Birds Weight: " + Weight);
            Console.WriteLine("Birds Bandno: " + Bandno);
            Console.ReadLine();
        }

    }
}
