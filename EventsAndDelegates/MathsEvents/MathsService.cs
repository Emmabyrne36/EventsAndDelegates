using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    class MathsService
    {
        // Below is the long way to go about creating events and delegates

        //public delegate double ResultHandler(double value1, double value2);
        //public delegate void OutboundHandler(double result);
        //public ResultHandler MathsDelegate;
        //// This is the same as the event below
        //// public OutboundHandler OutboundDelegate;
        //public event OutboundHandler OutboundEvent;

        public event EventHandler<MathsPerformedEventArgs> MathsPerformed;

        public double AddNumbers(double value1, double value2)
        {
            double result = value1 + value2;
            MathsPerformed?.Invoke(this, new MathsPerformedEventArgs(result));
            return result;
        }

        public double MultiplyNumbers(double value1, double value2)
        {
            double result = value1 * value2;
            MathsPerformed?.Invoke(this, new MathsPerformedEventArgs(result));
            return result;
        }
    }
}