using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORMsample.MyControl
{
    public partial class TextBoxList : TextBox
    {
        private ListView LV;

        public TextBoxList()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            this.Name = "textboxlv";
            LV = new ListView();
            LV.Name = "listview";
            LV.Size = new Size(100, 100);
            LV.Location = new Point(this.Location.X + 10, this.Location.Y + 10);

            this.Controls.Add(LV);
            //this.Parent.Controls.Add(LV);
        }

    }
}
