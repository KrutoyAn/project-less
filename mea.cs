using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace project_less
{
    public class MovingEventArgs: EventArgs
    {
        public MovingEventArgs(string message)
        {
            Message = message;
        }
        public string Message {get; private set;}
    }
}