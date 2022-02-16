using System;
using System.Globalization;

namespace LearnStringParsing
{

    class Program
    {

        static void Main(string[] args)
        {
            string intString = "5";
            string floatToIntString = "5.00";
            string thousandString = "3,000";
            string thousandDecimalString = "7,000.00";
            int targetNum;

            // Attempt to parse the strings to their numeric data types
            try
            {
                int intNum = int.Parse(intString);
                Console.WriteLine("Converted integer {0}", intNum);

                int floatToInt = int.Parse(floatToIntString, NumberStyles.Float);
                Console.WriteLine("Converted {0} to an integer {1}", floatToIntString, floatToInt);

                int thousandInt = int.Parse(thousandString, NumberStyles.AllowThousands);
                Console.WriteLine("Converted {0} to int {1}", thousandString, thousandInt);

                int thousandDecimalToInt = int.Parse(thousandDecimalString, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine("Converted {0} to int {1}", thousandDecimalString, thousandDecimalToInt);

                Console.WriteLine($"Converting boolean 'True' = {bool.Parse("True")}");
                Console.WriteLine($"Converting float '1.235' to fixed 2 decimals = {float.Parse("1.235"):F2}");
            }
            catch
            {
                Console.WriteLine("Eish, parsing failed !");
            }

            // Using TryParse function
            bool parsed = false;
            parsed = Int32.TryParse(intString, out targetNum);
            if (parsed)
            {
                Console.WriteLine($"Using TryParse function {intString} = {targetNum}");
            }

        } // End Main Function
    } // End class 'Program'
} // End namespace LearnStringParsing