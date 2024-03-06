using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoterem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class elso
        {
            public int x;
            public int y;
            public elso(int a, int b)
            {
                x = a;
                y = b;
            }
        }
        public class masodik : elso
        {
            public masodik(int a, int b) : base( a, b)
            { 
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elso antal = new elso(9, 11);
            label1.Text = (antal.x * antal.y).ToString();
            masodik bence = new masodik(6, 8);
            label1.Text = (bence.x * bence.y).ToString();
            
        }
    }
}
