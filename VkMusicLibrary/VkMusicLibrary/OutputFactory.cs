using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkMusicLibrary
{
    public abstract class OutputFactory
    {
        public abstract MediaOutputManager CreateMediaOutputManager();

        public abstract PageOutputManager CreatePageOutputManager();

        public abstract PageListOutputManager CreatePageListOutputManager();

        public abstract SearchFormOutputManager CreateSearchFormOutputManager();

        public abstract IDownload CreateIDownload();

        public abstract Iplay CreateIPlayable();
    }
}
