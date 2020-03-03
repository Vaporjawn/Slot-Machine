using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    class SpinClass
    {
        private int randNum1;
        private int randNum2;
        private int randNum3;

        private string[] picArray = new string[6];

        public SpinClass()
        {
            //GETS RANDOM NUMBER
            RandNumClass getNum = new RandNumClass();

            randNum1 = getNum.getRandNum1(ref randNum1);
            randNum2 = getNum.getRandNum2(ref randNum2);
            randNum3 = getNum.getRandNum3(ref randNum3);

            //CALLS SLOT IMAGE DISPLAYERS, SENDS THEM RANDOM NUMBERS
            DisplayImage1(ref randNum1);
            DisplayImage2(ref randNum2);
            DisplayImage3(ref randNum3);
        }

        //SLOT IMAGE DISPLAY MODULE 1, CONTAINS ALL COMBOS
        public void DisplayImage1(ref int randNum1)
        {
            int caseSwitch = randNum1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Display Picture for Slot 1: A");
                    break;
                case 2:
                    Console.WriteLine("Display Picture for Slot 1: B");
                    break;
                case 3:
                    Console.WriteLine("Display Picture for Slot 1: C");
                    break;
                case 4:
                    Console.WriteLine("Display Picture for Slot 1: D");
                    break;
                case 5:
                    Console.WriteLine("Display Picture for Slot 1: E");
                    break;
                case 6:
                    Console.WriteLine("Display Picture for Slot 1: F");
                    break;
            }
        }

        public void DisplayImage2(ref int randNum2)
        {
            int caseSwitch = randNum2;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Display Picture for Slot 2: A");
                    break;
                case 2:
                    Console.WriteLine("Display Picture for Slot 2: B");
                    break;
                case 3:
                    Console.WriteLine("Display Picture for Slot 2: C");
                    break;
                case 4:
                    Console.WriteLine("Display Picture for Slot 2: D");
                    break;
                case 5:
                    Console.WriteLine("Display Picture for Slot 2: E");
                    break;
                case 6:
                    Console.WriteLine("Display Picture for Slot 2: F");
                    break;
            }
        }

        public void DisplayImage3(ref int randNum3)
        {
            int caseSwitch = randNum3;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Display Picture for Slot 3: A");
                    break;
                case 2:
                    Console.WriteLine("Display Picture for Slot 3: B");
                    break;
                case 3:
                    Console.WriteLine("Display Picture for Slot 3: C");
                    break;
                case 4:
                    Console.WriteLine("Display Picture for Slot 3: D");
                    break;
                case 5:
                    Console.WriteLine("Display Picture for Slot 3: E");
                    break;
                case 6:
                    Console.WriteLine("Display Picture for Slot 3: F");
                    break;
            }
        }
    }
}
