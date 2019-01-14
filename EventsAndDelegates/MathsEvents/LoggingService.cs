using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates.MathsEvents
{
    class LoggingService : IMathsPerformedService
    {
        public void OnMathsPerformed(object sender, MathsPerformedEventArgs args)
        {
            Console.WriteLine("Logging result: " + args.MathsResult);
        }
    }
}
