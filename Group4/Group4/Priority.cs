using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4
{
   public enum Priority
    {
        [Description("Low priority")] Lowpriority,
        [Description("Normal")] Normal,
        [Description("Urgent")] Urgent
  
    }
}
