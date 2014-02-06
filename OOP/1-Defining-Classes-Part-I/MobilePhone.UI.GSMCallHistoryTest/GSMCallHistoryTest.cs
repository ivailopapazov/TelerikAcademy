using System;
using System.Collections.Generic;
using MobilePhone.Library;
using System.Text;
using System.Linq;

namespace MobilePhone.UI.GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            // Create an instance of the GSM class.
            GSM myPhone = GSM.IPhone4S;

            // Add few calls.
            myPhone.AddCall(new DateTime(2014, 1, 25, 10, 25, 30), 345, "0884635438");
            myPhone.AddCall(new DateTime(2014, 1, 27, 11, 15, 40), 15, "0876435458");
            myPhone.AddCall(new DateTime(2014, 1, 30, 15, 45, 11), 35, "0897546835");
            myPhone.AddCall(new DateTime(2014, 2, 2, 20, 11, 55), 2483, "0883348985");

            // Display the information about the calls.
            List<Call> calls = myPhone.CallHistory;
            int longestCallDuration = 0;
            int longestCallIndex = 0;
            for (int i = 0; i < calls.Count; i++)
            {
                // Print call
                Console.WriteLine("{0,-23} - {1} - {2}", calls[i].DateTime, calls[i].DialedNumber, calls[i].Duration);

                if (calls[i].Duration > longestCallDuration)
                {
                    longestCallDuration = calls[i].Duration;
                    longestCallIndex = i;
                }
            }

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Total price: {0:C}", myPhone.CalculateTotalPrice(0.37M));

            // Remove the longest call from the history and calculate the total price again.
            myPhone.DeleteCall(longestCallIndex);
            myPhone.CallHistory.ForEach(call => Console.WriteLine("{0,-23} - {1} - {2}", call.DateTime, call.DialedNumber, call.Duration));
            Console.WriteLine("Total price: {0:C}", myPhone.CalculateTotalPrice(0.37M));

            // Finally clear the call history and print it.
            myPhone.ClearCalls();
            Console.WriteLine("Number count in call history = {0}", myPhone.CallHistory.Count);
        }
    }
}
