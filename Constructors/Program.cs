using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Adam");
            Person person3 = new Person(2, "Krystian", "Nowak");
            Person person4 = new Person(3, "Kazimierz", "Stonoga", "Phoenix", 20, "Men");
        }
    }
}
