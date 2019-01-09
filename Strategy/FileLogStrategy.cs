using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileLogStrategy : ILogStrategy
    {
        public void Log(string message)
        {
            //Write message to file
            Console.WriteLine($"log to file message : {message}");
        }
    }
}
