using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class TextBox_Admin : UserControl
    {
        public TextBox_Admin()
        {
            InitializeComponent();
        }

        private string _name;

        public string NAme
        {
            get { return _name;  }
            set { _name = value; TextBox_Label.Text = value; }
        }

        private string _text;

        public string TExt
        {
            get { return _text; }
            set { _text = value;}
        }
        public string gettxt()
        {
            TExt = TextBox.Text;
            return TExt;
        }

        private string _placeholder;
        private string d;

        public string Placeholder
        {
            get { return _placeholder; }
            set { _placeholder = value; TextBox.Text = value; }
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            d = Placeholder;
            if (TextBox.Text == d)
            {
                Textbox_bg_Panel.Size = new System.Drawing.Size(215, 10);
                Placeholder = null;
                Font Largefont = new Font("Lucida Sans", 15);
                TextBox.Font = Largefont;
            }
            
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            Textbox_bg_Panel.Size = new System.Drawing.Size(200, 10);
            d = Placeholder;
            Placeholder = null;
            Font Largefont = new Font("Lucida Sans", 15);
            TextBox.Font = Largefont;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {

        }
    }
}
