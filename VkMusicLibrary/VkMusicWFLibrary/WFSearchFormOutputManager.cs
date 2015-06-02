using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VkMusicWFLibrary
{
    public class WFSearchFormOutputManager : VkMusicLibrary.SearchFormOutputManager
    {
        TextBox textbox;
        Button button;
        ComboBox combobox;
        Label label;
        public override void Show()
        {
            var parent = (VkMusicAppWindow.Instance.PageList.PageListOutput as WFPageListOutputManager).Form;
            var parentSize = parent.Size;
            textbox = new TextBox
            {
                Parent = parent,
                Location = new System.Drawing.Point(10, 10),
                TextAlign = HorizontalAlignment.Left,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Size = new System.Drawing.Size(parentSize.Width * 5 / 7, 0),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
            textbox.TextChanged += VkMusicAppWindow.Instance.PageList.SearchForm.SearchTextChanged;
            textbox.Show();
            button = new Button
            {
                Parent = parent,
                Location = new System.Drawing.Point(textbox.Size.Width + 10, 10),
                Text = "Search",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Anchor = AnchorStyles.Right | AnchorStyles.Top
            };
            button.Click += VkMusicAppWindow.Instance.PageList.SearchForm.SearchButtonClick;
            button.Show();
        }

        

        public override void Close()
        {
            throw new NotImplementedException();
        }
    }
}
