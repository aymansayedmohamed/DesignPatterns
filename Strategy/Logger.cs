using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Logger : ILogger
    {

        private ILogStrategy _logStrategy;

        public Logger(ILogStrategy logStrategy)
        {
            this._logStrategy = logStrategy;
        }

        public void Log(string message)
        {
            this._logStrategy.Log(message);
        }
    }
}
