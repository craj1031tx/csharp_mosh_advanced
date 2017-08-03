using System;
using System.Threading;

namespace csharp_mosh_advanced
{
    public class VideoEncoder
    {
        // 1 - define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2 - define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        // 3 - raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
    }
}