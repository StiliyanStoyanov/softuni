using System;

namespace _05.Boolean_Variable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool boolean = Convert.ToBoolean(input);
            if(boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
