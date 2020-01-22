using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
        Diary diary = new Diary();

            for (; ; )
            {
                Console.WriteLine("Enter rating from 1 to 10");
                float rating;
                bool end;
                bool result = float.TryParse(Console.ReadLine(), out rating);
                if (result)
                {
                    if (rating > 0 && rating <=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Bad rating! Please enter rating from 1 to 10");
                    }
                }
                else
                {
                    Console.WriteLine("Bad value!");
                }
                for (; ; )
                {
                    Console.WriteLine("Do you want enter rating? (YES or NOT)");
                    string question = Console.ReadLine();
                    question = question.ToUpper();
                    if (question == "NOT")
                    {
                        end = true;
                        break;
                    }
                    else if (question == "YES")
                    {
                        end = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bad value! Please enter YES or NOT");
                        continue;
                    }
                }
                if (end)
                {
                    break;
                }
            }

            Console.WriteLine("Average ratings: " + diary.CalculateAverage() + "\nMax rating: " + diary.GiveMaxRating() + "\nMin rating: " + diary.GiveMinRating());

            Console.ReadKey();
        }
    }
}
