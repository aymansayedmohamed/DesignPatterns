using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     The abstract factory pattern provides a way to encapsulate a group of individual factories 
     that have a common theme without specifying their concrete classes.
    */
    class Program
    {
        enum Appearance { Win , IOS}

        static void Main(string[] args)
        {
            var appearance = Appearance.IOS;

            IGUIFactory factory= new WinFactory();
            switch (appearance)
            {
                case Appearance.Win:
                    factory = new WinFactory();
                    break;
                case Appearance.IOS:
                    factory = new IOSFactory();
                    break;
            }

            var button = factory.CreateButton();
            button.Paint();

            var window = factory.CreateWindow();
            window.Paint();

        }
    }
}
