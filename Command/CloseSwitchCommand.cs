using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// command to close the light
    /// </summary>
    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;


        public CloseSwitchCommand(ISwitchable switchable)
        {
            this._switchable = switchable;
        }

        public void Execute()
        {
            this._switchable.PowerOff();
        }

        public void Undo()
        {
            this._switchable.PowerOn();
        }
    }
}
