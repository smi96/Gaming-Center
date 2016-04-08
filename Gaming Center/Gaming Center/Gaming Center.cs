using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Center
{
    public partial class Gaming_Center : Form
    {
        public Gaming_Center()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maze_Game.Form1 hello = new Maze_Game.Form1();
            hello.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MAtching_Game.Form1 hello2 = new MAtching_Game.Form1();
            hello2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Snake.Form1 hello3 = new Snake.Form1();
            hello3.Show();
        }
    }
}
