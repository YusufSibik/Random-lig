using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_random_lig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Enabled = false;
            int a=rastgele.Next(0,5);
            int b=rastgele.Next(0, 5);
            int c=rastgele.Next(0, 5);
            int d=rastgele.Next(0, 5);


            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label6.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text =gspuan.ToString();
            }
            if (Convert.ToInt32 (label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32 (label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan  =   gspuan + 1;
                fbpuan  =   fbpuan + 1;
                labelgspuan.Text=gspuan.ToString();
                labelfbpuan.Text=fbpuan.ToString();

            }

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32 (label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan  = tspuan+1;
                labelbjkpuan.Text =(bjkpuan.ToString());
                labeltspuan.Text =(tspuan.ToString());

            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);


            label11.Text = a.ToString(); //gs
            label12.Text = b.ToString(); //bjk
            label13.Text = c.ToString(); //fb
            label21.Text = d.ToString(); //ts

            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text)) 
            {
                gspuan = gspuan + 3;
                labelgspuan.Text =(gspuan.ToString());

            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();

            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label11.Text))
            {
                gspuan=gspuan + 1;
                bjkpuan=bjkpuan + 1;
                labelgspuan.Text=gspuan.ToString();
                labelbjkpuan.Text=(bjkpuan.ToString());

            }
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label21.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text =(fbpuan.ToString());

            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label13.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text =(tspuan.ToString());

            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label21.Text))
            {
                fbpuan=fbpuan + 1;
                tspuan=tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);


            label26.Text = a.ToString(); //fb
            label31.Text = b.ToString(); //bjk
            label27.Text = c.ToString(); //ts
            label25.Text = d.ToString(); //gs

            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label31.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label26.Text)) 
            {   
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) == Convert.ToInt32(label31.Text))
            {
                fbpuan=fbpuan + 1;
                bjkpuan=bjkpuan + 1;
                labelfbpuan.Text= fbpuan.ToString();
                labelbjkpuan.Text =bjkpuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label25.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label27.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();

            }
            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label25.Text))
            {
                tspuan = tspuan + 1;
                gspuan  = gspuan + 1;
                labeltspuan.Text= tspuan.ToString();
                labelgspuan.Text= gspuan.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32 (labelgspuan.Text)> Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32 (labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text)> Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Avanoslu\\Desktop\\1.m4a";
                label35.Text = "Şampiyon Galatasaray";
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Avanoslu\\Desktop\\1.m4a";
                label35.Text = "Şampiyon Fenerbahçe";
            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Avanoslu\\Desktop\\1.m4a";
                label35.Text = "Şampiyon Beşiktaş";
            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Avanoslu\\Desktop\\1.m4a";
                label35.Text = "Şampiyon Trabzonspor";
            }
        }
    }
}
