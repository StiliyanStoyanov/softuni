using System;

namespace _04_ExternalEvaluation
{
    class ExternalEvaluation
    {
        static void Main(string[] args)
        {
            double Students = double.Parse(Console.ReadLine());
            var poorMark = 0.0;
            var statisfactoryMark = 0.0;
            var goodMark = 0.0;
            var veryGoodMark = 0.0;
            var excellentMark = 0.0;

            for (int pointPerStudent = 1; pointPerStudent <= Students; pointPerStudent++)
            {
                double studenPoints = double.Parse(Console.ReadLine());

                if (studenPoints <= 22.5) poorMark++;
                else if (studenPoints > 22.5 && studenPoints <= 40.5) statisfactoryMark++;
                else if (studenPoints > 40.5 && studenPoints <= 58.5) goodMark++;
                else if (studenPoints > 58.5 && studenPoints <= 76.5) veryGoodMark++;
                else if (studenPoints > 76.5 && studenPoints <= 100) excellentMark++;
            }
            var percentPoorMark = (poorMark / Students) * 100.0;
            var percentStatisfactoryMarks = (statisfactoryMark / Students) * 100.0;
            var percentGoodMarks = (goodMark / Students) * 100.0;
            var percentVeryGoodMarks = (veryGoodMark / Students) * 100.0;
            var percentExcellentMarks = (excellentMark / Students) * 100.0;

            Console.WriteLine($"{percentPoorMark:F2}% poor marks");
            Console.WriteLine($"{percentStatisfactoryMarks:F2}% satisfactory marks");
            Console.WriteLine($"{percentGoodMarks:F2}% good marks");
            Console.WriteLine($"{percentVeryGoodMarks:F2}% very good marks");
            Console.WriteLine($"{percentExcellentMarks:F2}% excellent marks");
        }
    }
}
