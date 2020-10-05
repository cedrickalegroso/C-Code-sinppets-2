using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alegroso_Finals
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Initializations classes parents and childs
            new Student();
            var _student = new Student();
            var _student1 = new Student1();
            var _student2 = new Student2();
            var _student3 = new Student3();

            //This will trigger the function to input the data
            _student1.inputScores();
            _student2.inputScores();
            _student3.inputScores();


            Console.WriteLine("\n\n\n\n\n\n\n\nOUTPUT=====================================================\n"); // Seperator hehe

            //This will trigger the function to check equivalent grading system
            _student1.gradeEquiv();
            _student2.gradeEquiv();
            _student3.gradeEquiv();

            Console.WriteLine("");

            //This will trigger the function to check if whom passed
            _student1.ispassed();
            _student2.ispassed();
            _student3.ispassed();


            //This will find the greatest of them all!
            if (_student1._total > _student2._total && _student1._total > _student3._total) 
            {
                Console.WriteLine("\n" +_student1._Name + " got the highest score with " + _student1._total + "%");
            }
            else if (_student2._total > _student1._total && _student2._total > _student3._total)
            {
                Console.WriteLine("\n" + _student2._Name + " got the highest score with " + _student2._total + "%");
            }
            else if (_student3._total > _student1._total && _student3._total > _student2._total)
            {
                Console.WriteLine("\n" + _student3._Name + " got the highest score with " + _student3._total + "%");
            }
        }
    }
}
