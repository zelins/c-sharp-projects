using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VkNet;
using VkNet.Enums.Filters;

namespace VkMusicLibrary
{
    public class PageList
    {
        private PageListOutputManager pageListOutput;
        private VkMusicLibrary.SearchForm searchForm;
        private VkNet.VkApi api = null;
        private const Int32 countForPage = 20;
        private Int32 counter = 0;      // счетчик страницы
        public List<Page> Pages
        {
            get;
            set;
        }

        public List<VkNet.Model.Attachments.Audio> MediaFiles
        {
            get;
            set;
        }

        public PageListOutputManager PageListOutput
        {
            get
            {
                return pageListOutput;
            }
            set
            {
                pageListOutput = value;
            }
        }

        public SearchForm SearchForm
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

        public void Search(object sender, SearchEventArgs ea)
        {
            Int32 count;
            MediaFiles.AddRange(api.Audio.Search(ea.Text, out count, true, null, null, 200, 0).ToList());

            Int32 temp = count % countForPage == 0 ? count / countForPage : (count / countForPage) + 1;
            Pages = new List<Page>(temp);
        }

        public void Next()
        {
            throw new System.NotImplementedException();
        }

        public void Previous()
        {
            throw new System.NotImplementedException();
        }

        public PageList(OutputFactory factory)
        {
            this.MediaFiles = new List<VkNet.Model.Attachments.Audio>(200);
            this.PageListOutput = factory.CreatePageListOutputManager();
            this.SearchForm = new SearchForm(factory);
            this.searchForm.SearchEvent += Search;

            int appId = 12345; // указываем id приложения
            string email = "+380931670003"; // email для авторизации
            string password = "radioPlayer"; // пароль
            Settings settings = Settings.Audio; // уровень доступа к данным
            api = new VkApi();
            api.Authorize(appId, email, password, settings); // авторизуемся
        }
    }
}