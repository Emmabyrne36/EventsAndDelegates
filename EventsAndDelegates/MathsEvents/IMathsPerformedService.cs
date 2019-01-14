using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public interface IMathsPerformedService
    {
        void OnMathsPerformed(object sender, MathsPerformedEventArgs args);
    }
}
