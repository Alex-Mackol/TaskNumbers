using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNumbers.Controllers.ClassController
{
    class Validator
    {
        public bool Parsing(string stringNumber)
        {
            return long.TryParse(stringNumber, out _);
        }
    }
}
