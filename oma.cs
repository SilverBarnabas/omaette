using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }





        private int _x;
        private int _y;
        private Position _objPosition;
        public Form1()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            _objPosition = Position.Down;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, _x, _y, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x += 5;
            }
            else if (_objPosition == Position.Left)
            {
                _x -= 5;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 5;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 5;
            }

            Invalidate();
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition=Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }

        }
    }
}
