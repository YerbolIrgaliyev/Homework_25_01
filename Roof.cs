using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class Roof : IPart
    {
        public bool IsBuilt { get; set; }
        public Roof()
        {
            IsBuilt = false;
        }
    }
}
