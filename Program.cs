using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g2);
            Console.WriteLine(g1.Name);

            int x1 = 4;
            int x2 = x1;

            x1 = 100;
            Console.WriteLine(x2);


                //GradeBook book = new GradeBook();
                //book.AddGrade(91);
                //book.AddGrade(89.1f);
                //book.AddGrade(75);

                //GradeStatistics stats = book.ComputeStatitics();
                //Console.WriteLine(stats.AverageGrade);
                //Console.WriteLine(stats.LowestGrade);
                //Console.WriteLine(stats.HighestGrade);
        }
    }
}
