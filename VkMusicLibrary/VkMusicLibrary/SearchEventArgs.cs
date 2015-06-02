using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkMusicLibrary
{
    public class SearchEventArgs : EventArgs
    {
        public string Text { get; private set; }

        public SearchEventArgs(string text)
        {
            Text = text;
        }
    }
}
