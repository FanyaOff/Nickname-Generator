using NicknameGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Nickname_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Checked)
            {
                string path = Path.GetTempPath();
                WebClient wc = new WebClient();
                wc.DownloadFile("https://cdn.discordapp.com/attachments/874211494823346187/893525401454915594/Adjectives.txt", path + @"text.txt");
                timer1.Start();
            }
            else
            {
                string path = Path.GetTempPath();
                File.Delete(path + @"\" + "text.txt");
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = Path.GetTempPath() + @"\" + "text.txt";
            string[] random1 = File.ReadAllLines(path, Encoding.Default);
            string[] random2 =
        {
            "mov",
            "qq",
            "mq",
            "tip",
            "man",
            "lo",
            "sli",
            "ky",
            "ad",
            "vb",
            "qve",
            "adt",
            "adv",
            "pos",
            "insi",
            "o",
            "a",
            "b",
            "ab",
            "cd",
            "an",
            "aje",
            "kikt",
            "blya",
            "ef",
            "fg",
            "abdc",
            "au",
            "pul"

        }; // random list
            Random r = new Random();
            string nick = random1[r.Next(0, random1.Length - 1)] + random2[r.Next(0, random2.Length - 1)];
            listBox1.Items.Add(nick);
            label2.Text = listBox1.Items.Count.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Текстовые файлы|*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string file = sf.FileName;
                WriteToFile(file, listBox1);
            }
        }

        private void WriteToFile(string path, ListBox listBox)
        {
            using (var sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                if (listBox != null)
                {
                    foreach (var item in listBox.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ТЫ ТОЧНО ХОЧЕШЬ ЭТОГО?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ZXC zxc = new ZXC();
                zxc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Хороший мальчик", "ЛУЧШИЙ!");
            }
            
        }
    }
}
