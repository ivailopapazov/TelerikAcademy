using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModel
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("asd", "asd", "ASd", "123", "asd", "123312312", 2, Specialty.AppliedMathematics, University.NewBulgarianUniversity, Faculty.Electronics);
            Student student2 = new Student("asd", "asd", "ASd", "123", "aaasd", "123312312", 2, Specialty.AppliedMathematics, University.NewBulgarianUniversity, Faculty.Electronics);
            string asd = "asddasadssda";

            Console.WriteLine(student1.GetHashCode() == student2.GetHashCode());
        }
    }
}
