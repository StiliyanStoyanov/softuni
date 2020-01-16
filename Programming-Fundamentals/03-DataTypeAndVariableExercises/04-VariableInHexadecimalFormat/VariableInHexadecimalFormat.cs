using System;

namespace _04_VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            // Create a hexadecimal value out of range of the Integer type.
            string value = Convert.ToString(Console.ReadLine());
            // Convert it back to a number.
            try
            {
                int number = Convert.ToInt32(value, 16);
                Console.WriteLine("{0}", number.ToString());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to convert '0x{0}' to an integer.", value);
            }
        }
    }
}
