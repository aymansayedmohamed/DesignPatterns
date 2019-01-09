using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IOSWindow : IWindow
    {
        public void Paint()
        {
            Console.WriteLine("Paint IOS Window");
        }
    }
}
