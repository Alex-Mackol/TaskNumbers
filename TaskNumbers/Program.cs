using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskNumbers.Controllers.ClassController;

namespace TaskNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SequenceController sequenceController = new SequenceController(args[0]);
            sequenceController.DisplaySequence();
            Console.ReadKey();
        }
    }
}
