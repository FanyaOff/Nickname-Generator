using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Nickname_Generator
{
    public partial class ZXC : Form
    {
        WebClient wc = new WebClient();

        public ZXC()
        {
            string path1 = Path.GetTempPath() + @"/" + "zxc.mp3";
            wc.DownloadFile("https://cdn.discordapp.com/attachments/874211494823346187/893571365947465768/Fem.Love_-_1000-7.mp3", path1);
            InitializeComponent();
            Process.Start(path1);
            timer1.Start();
            
        }

        private void ZXC_Load(object sender, EventArgs e)
        {
            
        }

        private void ZXC_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string[] random1 =
         {
            "zxc",
            "sf",
            "dead",
            "umer",
            "dota克",
            "要",
            "克",
            "the dead",
            "pain",
            "cursed",
            "killer",
            "god",
            "mute",
            "all",
            "no brain",
            "krip",
            "bot",
            "matь ebal克",
            "inside"

        }; // random list
            string[] random2 =
        {
            "abuzer",
            "pudge",
            "hopeless",
            "ghoul",
            "demon",
            "要",
            "克",
            "1k pts",
            "ugly god",
            "cursed",
            "killer",
            "god",
            "clown",
            "doter",
            "pidr",
            "in",
            "zxc",
            "1000-7",
            "problem",
            "depression",
            "dead",
            "demons in my head",
            "no",
            "inside"

        }; // random list
            string[] random3 =
        {
            "mertv",
            "kripo4ek",
            "zxc",
            "cursed",
            "zxcursed",
            "hate life",
            "alone",
            "pussy",
            "eblan",
            "法格",
            "juggernaut",
            "raze",
            "shadowfiend",
            "格",
            "法",
            "bot"
            

        }; // random list
            Random r = new Random();
            string nick = random1[r.Next(0, random1.Length - 1)] + " " + random2[r.Next(0, random2.Length - 1)] + " " + random3[r.Next(0, random3.Length - 1)];
            guna2TextBox1.Text = nick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
