using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _09Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Directory.CreateDirectory(@"c:\aaa\xxx\bb\" + i);
                File.Create(@"c:\aaa\xxx\bb\" + i + ".txt");
            }
            MessageBox.Show("ok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //剪切
            //Directory.Move(@"c:\aaa", @"c:\x\aaa");

            //重命名
            Directory.Move(@"c:\x", @"c:\xyz");
            MessageBox.Show("ok");
        }
    }
}
