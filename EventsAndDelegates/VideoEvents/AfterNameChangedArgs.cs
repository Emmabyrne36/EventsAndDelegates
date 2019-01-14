using System;

namespace EventsAndDelegates
{
    public class AfterNameChangedArgs : EventArgs
    {
        public string Message { get; set; }
    }
}