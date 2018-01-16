using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Child
    {
        public string Name { get; set; }
        public bool Sick { get; set; }

        //everything up to this point is called a POCO - plain old C# object, when methods are added it is no longer a POCO

        public string ForgeASickNote()
        {
            /* this is a conditional
            if (Sick)
            {
                return $"Please excuse {Name} from class today becaue they are very sick.";
            }

            return $"{Name}, you still have to go to school, quit faking. Love Mom";
            */

            // this is the same as an if statement but uses a terenary
            return Sick
                ? $"Please excuse {Name} from class today because they are very sick."
                : $"{Name}, you still have to go to school, quit faking. Love Mom";
           
        }
    }
}
