using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MathsPerformedEventArgs : EventArgs
    {
        public double MathsResult { get; set; }
        public MathsPerformedEventArgs(double result)
        {
            MathsResult = result;
        }
    }
}
