using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ExamExcercise2_PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var PoolVolume = int.Parse(Console.ReadLine());
            var Pipe1Debit = int.Parse(Console.ReadLine());
            var Pipe2Debit = int.Parse(Console.ReadLine());
            var HoursPassed = int.Parse(Console.ReadLine());
            var PoolCapacity = PoolVolume;
            var Pipe1Contribution = Pipe1Debit * HoursPassed;
            var Pipe2Contribution = Pipe2Debit * HoursPassed;
            var TotalPipeContribution = Pipe1Contribution * Pipe2Contribution;        
            if (PoolCapacity < TotalPipeContribution)
            {
                Console.WriteLine();
            }
        }
    }
}
