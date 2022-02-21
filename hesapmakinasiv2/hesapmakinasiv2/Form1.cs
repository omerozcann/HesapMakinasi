using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinasiv2
{
    public partial class Form1 : Form
    {
        Double s1, s2, sonuc;
        String islem = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void yedibtn_Click(object sender, EventArgs e)
        {
            if(sonuctxt.Text=="0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text+ "7";
        }

        private void sekizbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "8";
        }

        private void dokuzbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "9";
        }

        private void dortbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "4";
        }

        private void besbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "5";
        }

        private void altibtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "6";
        }

        private void birbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "1";
        }

        private void ikibtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "2";
        }

        private void ucbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "3";
        }

        private void sifirbtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text == "0")
            {
                sonuctxt.Text = "";
            }
            sonuctxt.Text = sonuctxt.Text + "0";
        }

        private void noktabtn_Click(object sender, EventArgs e)
        {
            if (sonuctxt.Text.Contains(",") == false)
            {
                sonuctxt.Text = sonuctxt.Text + ',';                
            }
        }

        private void esittirbtn_Click(object sender, EventArgs e)
        {
            s2 = Double.Parse(sonuctxt.Text);
            if(islem=="*")
            {
                sonuc = s1 * s2;
            }
            if (islem == "/")
            {
                sonuc = s1 / s2;
            }
            if (islem == "-")
            {
                sonuc = s1 - s2;
            }
            if (islem == "+")
            {
                sonuc = s1 + s2;
            }
            sonuctxt.Text = sonuc.ToString();
        }

        private void bolbtn_Click(object sender, EventArgs e)
        {
            s1 = Double.Parse(sonuctxt.Text);
            islem = "/";
            sonuctxt.Text = "0";
        }

        private void cikarbtn_Click(object sender, EventArgs e)
        {
            s1 = Double.Parse(sonuctxt.Text);
            islem = "-";
            sonuctxt.Text = "0";
        }

        private void toplabtn_Click(object sender, EventArgs e)
        {
            s1 = Double.Parse(sonuctxt.Text);
            islem = "+";
            sonuctxt.Text = "0";
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            sonuctxt.Text = "0";
        }

        private void carpbtn_Click(object sender, EventArgs e)
        {
            s1 = Double.Parse(sonuctxt.Text);
            islem = "*";
            sonuctxt.Text = "0";
        }
    }
}
