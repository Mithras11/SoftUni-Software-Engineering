using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {

        public Lake(int[] stones)
        {
            this.Stones = stones;
        }


        public int[] Stones { get; set; }



        public IEnumerator<int> GetEnumerator()
        {
            int lastEvenIndex = 0;

            for (int i = 0; i < this.Stones.Length; i += 2)
            {
                lastEvenIndex = i;

                yield return this.Stones[i];
            }




            int firstOddIndex;

            if (lastEvenIndex == this.Stones.Length - 1)
            {
                firstOddIndex = lastEvenIndex - 1;
            }
            else
            {
                firstOddIndex = lastEvenIndex + 1;
            }


            for (int j = firstOddIndex; j >= 0; j -= 2)
            {
                yield return this.Stones[j];

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
