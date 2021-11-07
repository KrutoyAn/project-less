using System;

namespace project_less
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int myVar = 256;*/ 

            Student student = new Student();
            student._age = 5;

            Calculate(student);

            Console.WriteLine(student._age);
            Console.ReadLine();
        }
        static void Calculate(Student student){
            student._age += 1;
        }
    }
}
