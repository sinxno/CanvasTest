using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanvasTest
{
    public partial class Form1 : Form
    {
        int[] a = new int[] { 260, 50 };
        int[] b = new int[] { 10, 500 };
        int[] c = new int[] { 510, 500 };
        int[] prevPoint = new int[2];
        int[] currPoint = new int[2];

        
        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();
            prevPoint[0] = a[0];
            prevPoint[1] = a[1];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = this.CreateGraphics();

            switch (rnd.Next(0,3))
            {
                case 0:
                    currPoint[0] = (prevPoint[0] + a[0])/2;
                    currPoint[1] = (prevPoint[1] + a[1]) / 2;
                    break;
                case 1:
                    currPoint[0] = (prevPoint[0] + b[0]) / 2;
                    currPoint[1] = (prevPoint[1] + b[1]) / 2;
                    break;
                case 2:
                    currPoint[0] = (prevPoint[0] + c[0]) / 2;
                    currPoint[1] = (prevPoint[1] + c[1]) / 2;
                    break;
                
                default:
                    break;
            }



            g.FillRectangle(aBrush, currPoint[0], currPoint[1], 4, 4);

            prevPoint[0] = currPoint[0];
            prevPoint[1] = currPoint[1];

        }
    }
}
