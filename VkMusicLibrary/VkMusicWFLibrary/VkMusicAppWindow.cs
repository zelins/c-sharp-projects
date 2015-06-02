using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkMusicLibrary;
using VkNet;
using VkNet.Enums.Filters;

namespace VkMusicWFLibrary
{
    public partial class VkMusicAppWindow : Form
    {
        private static VkMusicAppWindow instance;
        private static Int32 count = 0;
        private OutputFactory factory;
        public OutputFactory OutputFactory
        {
            get
            {
                return factory;
            }
            private set
            {
                factory = value;
            }
        }

        public AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer
        {
            get
            {
                return axWindowsMediaPlayer1;
            }
        }
        public PageList PageList { get; set; }
        private VkMusicAppWindow(OutputFactory fact)
        {
            factory = fact;
            this.PageList = new PageList(factory);
            //this.PageList.PageListOutput = factory.CreatePageListOutputManager();
            
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"http://cs7-4v4.vk-cdn.net/p13/34326d5123a57e.mp3?extra=8u-vxCUCSYI7lMsjuRKzNBNHXUFz6mFKKukL3nIxn8OWG5pIJ8JemPs7wZorrQ5AibSm7by7raR-YeBZCwruWFqCuuC7Dm4";
            
        }
        public static VkMusicAppWindow Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new Exception("Class wasn't initialize");
                }
                return instance;
            }
        }
        public static void CreateInstance<TFactory>() where TFactory : OutputFactory, new()
        {
            if (count < 1)
            {
                TFactory factory = new TFactory();
                instance = new VkMusicAppWindow(factory);
                count++;
            }
            else
                throw new Exception("Class's arleady initialized!");
        }
        public static void DestroyInstance()
        {
            if (count == 0)
            {
                throw new Exception("There is no instance of class!");
            }
            else
            {
                instance = null;
                count--;
            }
        }

        private void VkMusicAppWindow_Shown(object sender, EventArgs e)
        {
            this.PageList.PageListOutput.Show();
            this.PageList.SearchForm.SearchFormOutputManager.Show();
        }

        private void VkMusicAppWindow_Load(object sender, EventArgs e)
        {
            MdiClient CtlMdi;
            foreach (var ctl in this.Controls)
            {
                try
                {
                    CtlMdi = (MdiClient)ctl;

                    CtlMdi.BackColor = this.BackColor;
                }
                catch (InvalidCastException)
                {
                    // ignore and continue
                }
            }

            
        }
    }
}
