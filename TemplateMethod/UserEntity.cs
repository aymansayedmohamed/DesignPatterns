using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class UserEntity : Entity
    {
        public override void PreSave()
        {
            Console.WriteLine("making validation on user before save");
        }

        public override void SaveFailed()
        {
            Console.WriteLine("Failed to save the User");
        }

        public override void SaveSuccess()
        {
            Console.WriteLine("User saved success");
        }
    }
}
