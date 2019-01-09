using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Entity
    {
        public abstract void PreSave();
        public abstract void SaveSuccess();
        public abstract void SaveFailed();
        public void Save()
        {
            this.PreSave();

            // do logic to save the model to the database
            Console.WriteLine("save the model to the database");
            bool isSaveSuccess = true;

            if(isSaveSuccess)
            {
                this.SaveSuccess();
            }
            else
            {
                this.SaveFailed();
            }
        }
    }
}
