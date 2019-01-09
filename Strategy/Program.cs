using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {

        //the strategy pattern is a behavioral software design pattern that enables selecting an algorithm at runtime. 
        //Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.

        static void Main(string[] args)
        {
            //It's expected to use Dependency Injection container to inject either fileLogger or DataBaseLogger but we just try here

            // when to need to log to file
            ILogStrategy fileLogStrategy = new FileLogStrategy();

            ILogger fileLogger = new Logger(fileLogStrategy);

            fileLogger.Log("Error message");


            // when to need to log to database
            ILogStrategy dataBaseLogStrategy = new DataBaseLogStrategy();

            ILogger dataBaseLogger = new Logger(dataBaseLogStrategy);

            dataBaseLogStrategy.Log("Error Message");


        }
    }
}
