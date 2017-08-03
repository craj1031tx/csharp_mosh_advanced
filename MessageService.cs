using System;

namespace csharp_mosh_advanced
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a text message.... {0}", args.Video.Title);
        }
    }
}