using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkMusicLibrary;

namespace VkMusicWFLibrary
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VkMusicAppWindow.CreateInstance<WFOutputFactory>();
            Application.Run(VkMusicAppWindow.Instance);
        }
    }
}
