using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    class RandNumClass
    {
        private int index1;
        private int index2;
        private int index3;
        
        public RandNumClass()
        {
            getRandNum1(ref index1);
            getRandNum1(ref index2);
            getRandNum1(ref index3);
        }

        public int getRandNum1(ref int index1)
        {
            //INITIALIZE RNG
            Random random = new Random();

            //GET FIRST INDEX FROM RNG
            index1 = random.Next(1, 6);
            return index1;
        }

        public int getRandNum2(ref int index1)
        {
            //INITIALIZE RNG
            Random random2 = new Random();

            //GET FIRST INDEX FROM RNG
            index2 = random2.Next(1, 4);

            return index2;
        }

        public int getRandNum3(ref int index1)
        {
            //INITIALIZE RNG
            Random random3 = new Random();

            //GET FIRST INDEX FROM RNG
            index3 = random3.Next(1, 5);

            return index3;
        }
    }
}
