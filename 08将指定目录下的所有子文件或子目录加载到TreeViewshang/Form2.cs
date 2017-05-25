using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _08将指定目录下的所有子文件或子目录加载到TreeViewshang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region 只加载子目录

            ////1.获取用户输入的路径path
            //string path = textBox1.Text.Trim();


            ////2.获取该路径下的所有的子文件夹
            ////2.1把这些所有文件夹加载到TreeView上
            //string[] dirs = Directory.GetDirectories(path);
            ////遍历所有的文件夹的路径加载到TreeView上
            //foreach (string item in dirs)
            //{

            //    treeView1.Nodes.Add(Path.GetFileName(item));
            //}

            ////3.获取指定目录下的所有的子文件
            ////3.1把这些文件加载到TreeView上
            //string[] files = Directory.GetFiles(path);
            //foreach (string item in files)
            //{
            //    treeView1.Nodes.Add(Path.GetFileName(item));
            //}
            #endregion


            #region 递归加载所有的目录，按照层次结构显示到TreeView 上

            //获取用户输入的一个路径
            string path = textBox1.Text.Trim();


            //调用该方法实现将指定路径下的子文件与子目录按照层次结构加载到TreeView
            LoadFilesAndDirectoriesToTree(path, treeView1.Nodes);


            //treeView1.Nodes

            //TreeNodeCollection c = treeView1.Nodes;

            //LoadData(path, c);

            #endregion



        }

        public void LoadData(string path, TreeNodeCollection collection)
        {

        }


        //将目录与文件加载到TreeView上
        private void LoadFilesAndDirectoriesToTree(string path, TreeNodeCollection treeNodeCollection)
        {
            //1.先根据路径获取所有的子文件和子文件夹
            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);
            //2.把所有的子文件与子目录加到TreeView上。
            foreach (string item in files)
            {
                //把每一个子文件加到TreeView上
                treeNodeCollection.Add(Path.GetFileName(item));
            }
            //文件夹
            foreach (string item in dirs)
            {
                TreeNode node = treeNodeCollection.Add(Path.GetFileName(item));

                //由于目录，可能下面还存在子目录，所以这时要对每个目录再次进行获取子目录与子文件的操作
                //这里进行了递归
                LoadFilesAndDirectoriesToTree(item, node.Nodes);
            }

        }

        //public void M1()
        //{
        //    //...
        //    M1();
        //    //....
        //}

        //public void M2()
        //{

        //}
    }
}
