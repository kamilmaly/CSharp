using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            DiaryStatistics stats = diary.ComputeStatistics();
            Console.WriteLine("avg: " + stats.averageGrade + "\nmax rating: " + stats.maxGrade + "\nmin rating " + stats.minGrade) ;

            Console.ReadKey();
            //Diary diary2 = diary;
            //diary2.AddRating(8);

            //Diary diary3 = diary2;
            //diary3.AddRating(1);

        }
    }
}
