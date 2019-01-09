using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MessageService
    {
        // Event handler method
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
