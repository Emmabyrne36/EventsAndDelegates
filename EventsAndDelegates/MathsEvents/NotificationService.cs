using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.MathsEvents
{
    class NotificationService : IMathsPerformedService
    {
        public void OnMathsPerformed(object sender, MathsPerformedEventArgs args)
        {
            Console.WriteLine("Notification: Result is: " + args.MathsResult);
        }
    }
}
