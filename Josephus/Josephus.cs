using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus
{
    public class SuicidePact
    {
        public int LastPersonStanding(int numberOfPeople, int interval)
        {
            var soldiers = Enumerable.Range(1, numberOfPeople).ToList();
            int counter = interval;
            int j = 0;
            while (soldiers.Count() > 1)
            {
                counter--;
                if (j >= soldiers.Count()) j = 0;
                if (counter == 0)
                {
                    // j-- accounts for next person at deleted person's index;
                    soldiers.RemoveAt(j--);
                    counter = interval;
                }
                j++;
            }
            return soldiers.ElementAt(0);

        }
    }
}
