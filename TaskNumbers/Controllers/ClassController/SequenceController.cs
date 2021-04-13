using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskNumbers.Models.ClassModel;
using TaskNumbers.View.ClassView;

namespace TaskNumbers.Controllers.ClassController
{
    class SequenceController
    {
        public string SquereNumber { get; }
        NumSequence sequence;
        DisplaySequence displaySequence;

        public SequenceController(string squereNumber)
        {
            SquereNumber = squereNumber;
        }

        public void DisplaySequence()
        {
            Validator validator = new Validator();
            if (validator.Parsing(SquereNumber))
            {
                sequence = new NumSequence(long.Parse(SquereNumber));
                displaySequence = new DisplaySequence();
                foreach (long number in sequence)
                {
                    displaySequence.DisplaySequenceOnScreen(number.ToString());
                }
            }
            else
            {
                displaySequence.DisplaySequenceOnScreen("Invalid format of number! Please enter again!");
            }
        }
    }
}
