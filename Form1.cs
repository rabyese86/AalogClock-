using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnalogClock
{
    public partial class Form1 : Form{

        Bitmap clock, hour, mintue, second;
        public Form1()
        {
            InitializeComponent();

            clock = new Bitmap(".\\clock.png");
            hour = new Bitmap(".\\hour.png");
            mintue= new Bitmap(".\\mintue.png");
            second = new Bitmap(".\\second.png");


        }

        private void timerClick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int Hour = now.Hour;
            int Minute = now.Minute;
            int Second = now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

           ClockBox1.Image = clock;
            ClockBox1.Controls.Add(hourBox);
            hourBox.Location = new Point(130, 190);
            hourBox.Image = rotateImage(hour, AngleH);
            hourBox.Controls.Add(mintueBox4);
            mintueBox4.Location = new Point(4, 5);
            mintueBox4.Image = rotateImage(mintue, AngleM);
            mintueBox4.Controls.Add(secondBox2);
            secondBox2.Location = new Point(-30, -18);
            secondBox2.Image = rotateImage(second, AngleS);

        }

        private Bitmap rotateImage(Bitmap rotateme, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateme.Width, rotateme.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateme.Width / 2, rotateme.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateme.Width / 2, -rotateme.Height / 2);
                g.DrawImage(rotateme, new Point(0, 0));
            }
            return rotatedImage;
        }

    }
}
