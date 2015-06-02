using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VkMusicLibrary;

namespace VkMusicWFLibrary
{
    public class WFPageListOutputManager : PageListOutputManager
    {
        Form form;
        public Form Form
        {
            get
            {
                return form;
            }
        }
        public override void Show()
        {
            var mainWindSize = VkMusicAppWindow.Instance.ClientSize;
            var WMPSize = VkMusicAppWindow.Instance.WindowsMediaPlayer.Size;

            form = new Form();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = VkMusicAppWindow.Instance;
            form.Location = new System.Drawing.Point(mainWindSize.Width / 7, 0);
            form.LayoutMdi(MdiLayout.TileVertical);
            form.Size = new System.Drawing.Size(mainWindSize.Width * 5 / 7, mainWindSize.Height - WMPSize.Height - 5);
            form.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Show();
            System.Drawing.Size windSize = form.Size;
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }
    }
}
