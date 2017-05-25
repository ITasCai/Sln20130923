using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _03简体繁体转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 把简体转换成繁体
        private void button1_Click(object sender, EventArgs e)
        {
            //1,获取用户输入的文本
            string userInput = txtJt.Text.Trim();
            //循环每个字符，找到对应的繁体并且拼接
            StringBuilder sbFanti = new StringBuilder();
            for (int i = 0; i < userInput.Length; i++)
            {
                if (dict.ContainsKey(userInput[i]))
                {
                    sbFanti.Append(dict[userInput[i]]);
                }
                else
                {
                    sbFanti.Append(userInput[i]);
                }
            }
            txtFt.Text = sbFanti.ToString();
        }

        Dictionary<char, char> dict = new Dictionary<char, char>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化集合
            //1.读取文本文件中的每一行
            string[] lines = File.ReadAllLines("简体-繁体.txt", Encoding.Default);

            //2.遍历每一行数据Split分割，把简体作为键，把繁体作为值
            foreach (string item in lines)
            {
                string[] parts = item.Split('=');
                dict.Add(parts[0][0], parts[1][0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.构建英汉词典集合（Dictionary）
            Dictionary<string, string> dictEnCn = new Dictionary<string, string>();


            //2.获取用户输入的英文单词
            string[] lines = File.ReadAllLines("英汉词典TXT格式.txt", Encoding.Default);


            //2.1初始化词典集合
            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (dictEnCn.ContainsKey(parts[0]))
                {
                    dictEnCn[parts[0]] += Environment.NewLine + parts[1];
                }
                else
                {
                    dictEnCn.Add(parts[0], parts[1]);
                }
            }


            //3.根据英文单词查找对应的汉语解释
            //获取用户输入的英文单词
            string userInput = txtJt.Text.Trim();
            if (!dictEnCn.ContainsKey(userInput))
            {
                txtFt.Text = "对不起，词典中没有该词。";
            }
            else
            {
                txtFt.Text = dictEnCn[userInput];
            }


            //4.显示到文本框中
        }
    }
}
