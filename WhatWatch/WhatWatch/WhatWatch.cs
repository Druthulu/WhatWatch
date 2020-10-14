using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WhatWatch
{
    public partial class WhatWatch : Form
    {
        //string[] output; //should allow shared output from file read, display, and save. but restric to just WhatWatch class
        public WhatWatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ee
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load on launch
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void but_random_Click(object sender, EventArgs e)
        {

            //convert textbox per line to an array
            string[] array_tex_list = tex_list.Text.Split('\n');
            //new random
            Random random = new Random();
            //random index
            int randomIndex = random.Next(0, array_tex_list.Length);
            //output array value
            tex_out.Text = array_tex_list[randomIndex];
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            //check first for changes, output and auto close in 10 seconds if dont click random
            //note to add check for need to save on exit of program
            /*
             * 
             DataTable dt;  
             dt = new DataTable("datafromtextbox");  
             dftb = datafromtextbox;
             dftb.Fill(dt);  
             dt.WriteXml("list.xml");  
             * 
             */

           //File.WriteAllLines("test_out.csv", output); //write array OUTPUT to csv
        }

        private void but_load_Click(object sender, EventArgs e)
        {
            //
            // idea but set ahead, csv should be fine for now. location file to be determined later
            /*
             * 
             DataSet ds = new DataSet();
             ds.ReadXml(fileNamePath);
             * 
             */
            /*
            var input = File.ReadAllLines("http://samplecsvs.s3.amazonaws.com/SalesJan2009.csv"); //read file and create var 
            output = input.Select((line, i) => //loop through for each line
            {
                //if (i == 0) //line index 0 first line, use for special intro info, ignore in my case.
                    //tex_list.Text = line + ",string"; //output first line
                //tex_list.Text = line + "," + "somedumbshit"; //output current line
            }).ToArray(); //bring lines into array var OUTPUT
            */
            /*string line = "";
            using (var wclient = new System.Net.WebClient())
            {
                string result = wclient.DownloadString("https://people.sc.fsu.edu/~jburkardt/data/csv/addresses.csv");
                StreamReader sr = new StreamReader(result);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        tex_list.AppendText(line);
                    }
                }
                sr.Close();
            }*/
            tex_list.Text = "";
            var wclient = new System.Net.WebClient();
            Stream stream = wclient.OpenRead("https://people.sc.fsu.edu/~jburkardt/data/csv/addresses.csv");
            StreamReader sr = new StreamReader(stream);
            //string str = sr.ReadToEnd();
            string line = "";
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    tex_list.AppendText(line);
                }
            }
            sr.Close();

        }
    }
}
