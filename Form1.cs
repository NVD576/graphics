using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuanDepTraiVai
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm= new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint= false;
        Point px, py;
        Pen p= new Pen(Color.Black,1);
        Pen erase = new Pen (Color.White,10);
        int index=3;
        int x, y, ex, ey;

        private void boderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                p= new Pen(dlg.Color,1);
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            x=e.X; 
            y=e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                else if (index == 0)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                
            }
            pic.Refresh();
        }

        private void eLLIPESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint=false;
            ex= e.X-x; 
            ey= e.Y-y;
            if (index == 3)
            {
                g.DrawRectangle(p, x,y,ex,ey);
            }
            else if (index == 2)
            {
                g.DrawEllipse(p, x, y, ex, ey);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            index = 0;
        }

        private void line_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            index = 3;
        }
    }
}
