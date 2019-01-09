using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        //template method pattern is a behavioral design pattern that defines the program skeleton of an algorithm in an operation,
        //deferring some steps to subclasses.

        static void Main(string[] args)
        {
            UserEntity user = new UserEntity();
            user.Save();

            ClientEntity client = new ClientEntity();
            user.Save();

        }
    }
}
