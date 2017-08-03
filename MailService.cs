using System;

namespace csharp_mosh_advanced
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email... {0}", e.Video.Title);
        }
    }
}