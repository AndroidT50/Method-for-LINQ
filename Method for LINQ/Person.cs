using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_for_LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public Person(int id, int age)
        {
            Id = id;
            Age = age;
        }
        public override string ToString()
        {
            return "Id" + Id + "-Age" + Age + ";";
        }
    }
}
