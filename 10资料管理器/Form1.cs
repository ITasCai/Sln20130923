using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _10资料管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 窗体加载事件

            //1.获取路径
            string path = "demo";


            //2.调用方法递归加载
            LoadData(path, treeView1.Nodes);
        }

        private void LoadData(string path, TreeNodeCollection treeNodeCollection)
        {
            //1.获取path下的所有的目录与文件
            string[] files = Directory.GetFiles(path, "*.txt");
            string[] dirs = Directory.GetDirectories(path);


            //遍历加载到TreeView上\
            //文件
            foreach (string item in files)
            {
                treeNodeCollection.Add(Path.GetFileName(item));
            }

            //目录
            foreach (string item in dirs)
            {
                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));
                LoadData(item, node.Nodes);
            }
        }
    }
}
