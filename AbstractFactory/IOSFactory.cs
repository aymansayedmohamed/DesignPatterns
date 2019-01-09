using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new IOSButton();
        }

        public IWindow CreateWindow()
        {
            return new IOSWindow();
        }
    }
}
