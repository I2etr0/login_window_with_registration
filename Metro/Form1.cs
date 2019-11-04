using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();


        }



        public void Signin_link_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.google.com");

            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();

        }

        public void pB_Click(object sender, EventArgs e)
        {
            pB.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        

        public void CBMember_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
        }

    }
}
