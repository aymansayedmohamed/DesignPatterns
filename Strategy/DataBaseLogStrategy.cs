using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DataBaseLogStrategy : ILogStrategy
    {
        public void Log(string message)
        {
            // Log message to dataBase
            Console.WriteLine($"Log to database message : {message}");
        }
    }
}
