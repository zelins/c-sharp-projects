using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkMusicLibrary
{
    public class AudioFile
    {
        private String URL;

        public Iplay Iplay
        {
            get;
            set;
        }

        public IDownload Idownload
        {
            get;
            set;
        }

        public MediaOutputManager MediaOutput
        {
            get;
            set;
        }

        public AudioFile(String url, OutputFactory factory)
        {
            this.URL = url;
            this.MediaOutput = factory.CreateMediaOutputManager();
        }
    }
}
