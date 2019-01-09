using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /*
    the command pattern is a behavioral design pattern in which an object is used to
    encapsulate all information needed to perform an action or trigger an event at a later time. 
    like commands at photoshop (do & undo)
    */

    class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lamp = new Light();

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            var remoteControl = new Switch(switchClose, switchOpen);

            remoteControl.OpenLight();
            remoteControl.CloseLight();
        }
    }
}
