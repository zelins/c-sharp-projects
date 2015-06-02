using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkMusicLibrary
{
    public class Page
    {
        public PageOutputManager PageOutput
        {
            get;
            set;
        }

        public List<AudioFile> AudioFiles
        {
            get;
            set;
        }

        public Page(IEnumerable<VkNet.Model.Attachments.Audio> files, OutputFactory factory)
        {
            PageOutput = factory.CreatePageOutputManager();

        }
    }
}
