using System;
using MobilePhone.Library;

namespace MobilePhone.UI
{
    class UserInterface
    {
        static void Main()
        {
            GSM gsm = new GSM("Nexus", "LG");
            Battery bat = new Battery("SomeModel");
        }
    }
}
