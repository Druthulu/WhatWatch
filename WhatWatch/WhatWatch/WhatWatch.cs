using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatWatch
{
    public partial class WhatWatch : Form
    {
        public WhatWatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_random_Click(object sender, EventArgs e)
        {
            //List<string> tex_list = new List<string>()
            //string[] myLines = ParkingTimes.ToArray();

            //string[] myLines = textbox.text.SplitParkingTimes.ToArray()
            //convert textbox per line to an array
            string[] array_tex_list = tex_list.Text.Split('\n');
            tex_out.Text = array_tex_list
        }
    }
}
