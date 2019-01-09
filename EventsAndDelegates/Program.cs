using System;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // this is a pointer to the OnVideoEncoded method in the MailService class
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
