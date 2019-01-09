using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ClientEntity : Entity
    {
        public override void PreSave()
        {
            Console.WriteLine("making validation on Client before save");
        }

        public override void SaveFailed()
        {
            Console.WriteLine("failed to save the Client");
        }

        public override void SaveSuccess()
        {
            Console.WriteLine("client saved success");
        }
    }
}
