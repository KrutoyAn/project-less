using System.Threading;
using System;


namespace project_less
{
    
    public delegate void ShowMessage(string message);
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i<= distance; i++)
            {
                Thread.Sleep(1000);
                if(Moving != null)
                    Moving(this, new MovingEventArgs(string.Format("Идет перемещение... Пройдено км: {0}", i)));

            }
        }
        public event EventHandler<MovingEventArgs> Moving;
    }
    
}