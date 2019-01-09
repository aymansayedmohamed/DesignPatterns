using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{

    //Interface to define the actions that reciever can do
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
