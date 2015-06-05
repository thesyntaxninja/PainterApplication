using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterApplication
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        private const float SMALL = 5;
        private const float MEDIUM = 10;
        private const float LARGE = 15;
        private Point start;
        private Point end;
        private Point prev;
        private Brush selectedColor = new SolidBrush(Color.Black);
        private float diameter = SMALL;
        private Graphics storedGraphics;
        private Bitmap savedImage;

        public Form1()
        {
            InitializeComponent();
            shouldPaint = false;
            Size maxWindowSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            savedImage = new Bitmap(maxWindowSize.Width, maxWindowSize.Height); //image that gets drawn to panel
            storedGraphics = Graphics.FromImage(savedImage); // graphic cache
        }

        // when button clicked set brush color
        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = new SolidBrush(Color.Red);
        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = new SolidBrush(Color.Blue);
        }

        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = new SolidBrush(Color.Green);
        }

        private void blackButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedColor = new SolidBrush(Color.Black);
        }

        // when size buttons cliced set diameter of brush size
        private void smallButton_CheckedChanged(object sender, EventArgs e)
        {
            diameter = SMALL;
        }

        private void mediumButton_CheckedChanged(object sender, EventArgs e)
        {
            diameter = MEDIUM;
        }

        private void largeButton_CheckedChanged(object sender, EventArgs e)
        {
            diameter = LARGE;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            
           Graphics graphics = e.Graphics;
           graphics.DrawImage(savedImage, 0, 0, savedImage.Width, savedImage.Height);

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e) // when mouse down (clicked) obtain starting and ending points 
        {
            Point point = new Point(e.X, e.Y);
            start.X = (prev.X = point.X);
            start.Y = (prev.Y = point.Y);
            shouldPaint = true; // should paint = true 
        }


        private void Canvas_MouseUp(object sender, MouseEventArgs e) // when mouse not clicked shouldPaint = false
        {
            shouldPaint = false;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) // paint when shouldPaint true and mouse moving
        {

            if (shouldPaint == true)
            {
                end.X = e.X;
                end.Y = e.Y;

                
                Canvas.BackgroundImage = savedImage;
                Pen pen = new Pen(selectedColor, diameter);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics graphics = Canvas.CreateGraphics();
                graphics.DrawLine(pen, prev, end);
                graphics.Dispose();
                storedGraphics.DrawLine(pen, prev, end);
            }
            prev = end;
        }
    }
}
