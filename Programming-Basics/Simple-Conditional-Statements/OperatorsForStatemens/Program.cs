using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsForStatemens
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2;
            var b = 5;
            Console.WriteLine(a == a);    /// Проверка за равенство   /// работи за числа,дати,стрингове
            Console.WriteLine(a != b);    /// Проверка за различно    /// работи за числа,дати,стрингове
            Console.WriteLine(a > b);        ///работи за числа,дати и други сравними типове
            Console.WriteLine(a < b);        ///работи за числа,дати и други сравними типове
            Console.WriteLine(a >= b);       ///работи за числа,дати и други сравними типове
            Console.WriteLine(a <= b);       ///работи за числа,дати и други сравними типове

            var c = new DateTime(2017, 10, 25);
            var d = new DateTime(2017, 11, 23);
            Console.WriteLine($"Дата = {c < d}");

            var result = 5 != 6;
            Console.WriteLine("Boolean Statemen = " + result);  /// Boolean проверява True или False


        }
    }
}
