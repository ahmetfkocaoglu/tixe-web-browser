using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIXEBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://www.google.com.tr");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack == true && webBrowser1.IsOffline == false)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward == true && webBrowser1.IsOffline == false)
            {
                webBrowser1.GoForward();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsBusy == true && webBrowser1.IsOffline == false)
            {
                webBrowser1.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsBusy == false && webBrowser1.IsOffline == false)
            {
                webBrowser1.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.GoHome();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.GoSearch();
            }
        }

        private void commodoreGenTRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("http://www.commodore.gen.tr");
            }
        }

        private void metroİstanbulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://www.metro.istanbul");
            }
        }

        private void puyoNexusWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://puyonexus.com");
            }
        }

        private void vehiclePictureDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("http://pc2.pxtr.de");
            }
        }

        private void ınternetArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://archive.org");
            }
        }

        private void bulbaPediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://bulbapedia.bulbagarden.net");
            }
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://www.youtube.com");
            }
        }

        private void sabahGazetesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("http://www.sabah.com.tr");
            }
        }

        private void stackOverflowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("http://stackoverflow.com");
            }
        }

        private void superMarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://www.mariowiki.com");
            }
        }

        private void videoGameMusicDowloadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://downloads.khinsider.com");
            }
        }

        private void teletextStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://zxnet.co.uk/teletext");
            }
        }

        private void smashWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.IsOffline == false)
            {
                webBrowser1.Navigate("https://www.ssbwiki.com");
            }
        }
    }
}