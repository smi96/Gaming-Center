using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void wall_mouse_enter(object sender, EventArgs e)
        {
            Point starting_point = panel1.Location;
            starting_point.Offset(10, 10);
            Cursor.Position = PointToScreen(starting_point);
        }

        private void finishgame(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done!");
            Close();
        }
    }
}
