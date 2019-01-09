using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define a delagate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        // 1
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // sender of the event and any additional data to be sent with the event
        
        // EventHandler
        // EventHandler<TEventArgs>
        // 2
        // public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; // instead of creating the delegate above

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3
        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs(){ Video = video });
            // This can be rewritten as:
            //if (VideoEncoded != null)
            //    VideoEncoded(this, EventArgs.Empty);
            // first way better
        }
    }
}
