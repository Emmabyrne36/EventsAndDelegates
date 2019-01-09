using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class MailService
    {
        // Sends email once video is encoded
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email... " + e.Video.Title);
        }
    }
}