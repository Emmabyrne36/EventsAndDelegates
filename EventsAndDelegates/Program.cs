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

            // More tests
            TestDelegate td = new TestDelegate("Original Name");
            td.NameChanged += OnNameChanged;
            td.AfterChange += OnNameChanged2;
            td.Name = "Emma";
            td.AfterChange -= OnNameChanged2;
            td.Name = "Miller";
            td.Name = "Sooty";

            Console.ReadLine();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Name changed from {args.OldValue} to {args.NewValue}");
        }

        private static void OnNameChanged2(object sender, AfterNameChangedArgs e)
        {
            Console.WriteLine(e.Message);
        }

        // Old methods to invoke the delegates (the 'incorrect' way)
        //private static void OnNameChanged2(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //private static void OnNameChanged(string oldValue, string newValue)
        //{
        //    Console.WriteLine($"Name changed from {oldValue} to {newValue}");
        //}
    }
}
