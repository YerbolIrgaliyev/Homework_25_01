using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_25_01
{
    public class Door : IPart
    {
        public bool IsBuilt { get; set; }
        public Door()
        {
            IsBuilt = false;
        }
    }
}
