using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WinWindow : IWindow
    {
        public void Paint()
        {
            Console.WriteLine("Paint win Window");
        }
    }
}
