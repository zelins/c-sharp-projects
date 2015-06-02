using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VkMusicLibrary
{
    public delegate void SearchHandler(object sender, SearchEventArgs ea);

    public class SearchForm
    {
        public StringBuilder SearchText { get; set; }

        private VkMusicLibrary.SearchFormOutputManager searchForm;
        public SearchFormOutputManager SearchFormOutputManager
        {
            get
            {
                return searchForm;
            }
            set
            {
                searchForm = value;
            }
        }

        public event SearchHandler SearchEvent;

        public void SearchButtonClick(object sender, EventArgs e)
        {
            var temp = SearchEvent;

            if (temp != null)
            {
                temp(this, new SearchEventArgs(SearchText.ToString()));
            }
        }

        public void SearchTextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            this.SearchText.Clear();
            this.SearchText.Append(textbox.Text);
            
        }

        public SearchForm(OutputFactory factory)
        {
            this.SearchFormOutputManager = factory.CreateSearchFormOutputManager();
            SearchText = new StringBuilder();
        }
    }
}
