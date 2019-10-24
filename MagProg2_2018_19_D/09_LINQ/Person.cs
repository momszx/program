using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2} év\t{3}\t{4}\t{5}",
                Id, Name, Age, City, Job, Salary);
        }
    }
}
