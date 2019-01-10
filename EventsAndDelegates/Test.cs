using System;
using static EventsAndDelegates.Test;

namespace EventsAndDelegates
{
    class Test
    {
        // This is a more verbose way of creating a delegate, can just use the event handler to reduce amount of code written
        // Create a delegate
        public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);

       // public delegate void AfterNameChangedDeleate(string message);
    }

    class TestDelegate
    {
        public event NameChangedDelegate NameChanged;
        public event EventHandler<AfterNameChangedArgs> AfterChange;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (Name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    // This way of invoking an event goes against .NET convention.
                    // Ususally you don't pass in the arguments in this way. Usually, sender and eventArgs is passed in
                    // We should group the two values below as an object and pass that object as the second parameter to the event

                    // Old way
                    // NameChanged?.Invoke(oldValue, value); // Make sure it's not null

                    // Better way
                    NameChangedEventArgs args = new NameChangedEventArgs() { OldValue = oldValue, NewValue = value };
                    NameChanged?.Invoke(this, args);
                    
                    AfterChange?.Invoke(this, new AfterNameChangedArgs() { Message = "Ahoy" });

                }
            }
        }

        public TestDelegate(string name)
        {
            _name = name;
        }
    }
}
