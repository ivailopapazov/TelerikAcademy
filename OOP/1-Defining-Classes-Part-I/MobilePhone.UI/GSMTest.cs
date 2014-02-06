using System;
using MobilePhone.Library;

namespace MobilePhone.UI
{
    class GSMTest
    {
        static void Main()
        {
            // Create an array of few instances of the GSM class.
            Battery badBattery = new Battery("CS3215", BatteryType.LiPoly, 18, 3);
            Battery goodBattery = new Battery("AS4321", BatteryType.LiIon, 36, 6);
            Display badDisplay = new Display(2, 256000);
            Display goodDisplay = new Display(4, 16000000);
            GSM ultimateGSM = new GSM("3310", "Nokia", goodBattery, badDisplay, 20, "GOD");
            GSM badGSM = new GSM("GuangDong", "ChainaTown", badBattery, badDisplay, 50, "NaSakotoQkata");
            GSM goodGSM = new GSM("Nexus 4", "LG", goodBattery, goodDisplay, 500, "ME");
            GSM[] mobilePhones = new GSM[] { badGSM, goodGSM, ultimateGSM };

            // Display the information about the GSMs in the array.
            foreach (GSM mobilePhone in mobilePhones)
            {
                Console.WriteLine(mobilePhone);
            }

            // Display the information about the static property IPhone4S.
            Console.WriteLine("IPhone 4S information");
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
