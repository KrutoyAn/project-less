using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace project_less
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int myVar = 256;*/ 
            Student student = new Student();
            student.Moving+= student_Moving;
            
            student.Move(7);
        }
        static void student_Moving(object sender, MovingEventArgs e)
        {
           Console.WriteLine(e.Message);
        }

    }
}
