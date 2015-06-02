using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VkMusicLibrary;

namespace VkMusicWFLibrary
{
    public class WFOutputFactory : OutputFactory
    {
        public override MediaOutputManager CreateMediaOutputManager()
        {
            throw new NotImplementedException();
        }

        public override PageOutputManager CreatePageOutputManager()
        {
            throw new NotImplementedException();
        }

        public override PageListOutputManager CreatePageListOutputManager()
        {
            return new WFPageListOutputManager();
        }

        public override SearchFormOutputManager CreateSearchFormOutputManager()
        {
            return new WFSearchFormOutputManager();
        }

        public override IDownload CreateIDownload()
        {
            throw new NotImplementedException();
        }

        public override Iplay CreateIPlayable()
        {
            throw new NotImplementedException();
        }
    }
}
