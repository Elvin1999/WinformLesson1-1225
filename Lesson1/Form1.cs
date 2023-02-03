using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            titleLbl.Text = DateTime.Now.ToLongTimeString();
        }

        public Timer Timer { get; set; }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var x = e.Location.X;
            var y = e.Location.Y;

            titleLbl.Text = $"Clicked X : {x}  Y : {y}";
        }
        public bool IsClicked { get; set; }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                this.BackColor = Color.DodgerBlue;
            }
            else
            {
                this.BackColor = Color.Orange;
            }
            IsClicked = !IsClicked;
        }

        private void titleLbl_MouseEnter(object sender, EventArgs e)
        {
            titleLbl.ForeColor = Color.Red;
        }

        private void titleLbl_MouseLeave(object sender, EventArgs e)
        {
            titleLbl.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.baku;
            //Label myNewLbl = new Label();
            //myNewLbl.Text = "New Label";
            //myNewLbl.Location = new Point(0, 250);
            //myNewLbl.AutoSize = true;
            //myNewLbl.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);
            //myNewLbl.ForeColor = Color.Red;
            //this.Controls.Add(myNewLbl);

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Text = "Click Me";
                button.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
                Random random = new Random();
                int x = random.Next(100, 800);
                int y = random.Next(200, 500);
                button.Location = new Point(x, y);
                button.AutoSize = true;

                button.MouseClick += button1_MouseClick;
                this.Controls.Add(button);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
