using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USER.BOT
{
    public partial class Search_For_Posts : Form
    {
        public string access_token;
        public string user_id;

        public Search_For_Posts()
        {
            InitializeComponent();
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
