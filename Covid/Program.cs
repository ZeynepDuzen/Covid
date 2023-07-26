using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Covid19 symptoms and determination ***

            Heading();
            bool fever = Beginning("Do you have any fever ? < yes : y, no : n >");
            bool soreThroat = Beginning("Do you have any sore throat : < yes : y, no : n >");
            bool cough = Beginning("Do you have any cough : < yes : y, no : n >");
            bool covid = Determination(fever, soreThroat, cough);
            Diagnosis(covid);


            Console.Read();
        }

        static void Diagnosis(bool covid)
        {
            if (covid)
            {
                Console.WriteLine("You have covid 19");
            }
            else
            {
                Console.WriteLine("You have not covid 19");
            }
        }

        static bool Determination(bool fever, bool soreThroat, bool cough)
        {
            if (fever || soreThroat || cough)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Heading()
        {
            Console.WriteLine("*** Covid19 symptoms and determination ***");
            Console.WriteLine();
        }

        static bool Beginning(string message)
        {
            bool result;
            Console.WriteLine(message);
            string symptom = Console.ReadLine();

            if (symptom == "y")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

    }
}
