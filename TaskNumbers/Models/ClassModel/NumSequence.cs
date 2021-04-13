using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNumbers.Models.ClassModel
{
    class NumSequence : IEnumerable
    {
        public long SquereOfLastNumber { get; }

        public NumSequence(long squereOfLastNumber)
        {
            SquereOfLastNumber = squereOfLastNumber;
        }
         
        public IEnumerator GetEnumerator()
        {
            for (long i = 0; i < long.MaxValue; i++)
            {
                if (i > Math.Sqrt(SquereOfLastNumber))
                {
                    yield break;
                }
                else
                {
                    yield return i;
                }
            }
        }
    }
}
