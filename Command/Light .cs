using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //the reciever class
    public class Light : ISwitchable
    {
        public void PowerOff()
        {
            Console.WriteLine("The power light Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("The power light On");
        }
    }
}
