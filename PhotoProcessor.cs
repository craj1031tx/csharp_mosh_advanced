using System;

namespace csharp_mosh_advanced
{

    public class PhotoProcessor
    {        
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }

}