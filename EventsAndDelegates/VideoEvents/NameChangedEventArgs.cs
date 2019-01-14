using System;
namespace EventsAndDelegates
{
    public class NameChangedEventArgs : EventArgs
    {
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
