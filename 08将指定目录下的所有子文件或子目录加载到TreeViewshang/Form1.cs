using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08将指定目录下的所有子文件或子目录加载到TreeViewshang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空所有节点
            treeView1.Nodes.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //增加一个根节点
            string userInput = textBox2.Text.Trim();

            //把userInput内容加到TreeView的根节点中
            //Add()方法的返回值就是刚刚增加的节点
            TreeNode node = treeView1.Nodes.Add(userInput);

            node.BackColor = Color.Yellow;
        }
        //向选中的节点下增加子节点
        private void button4_Click(object sender, EventArgs e)
        {
            //1.判断用户是否有选中节点
            TreeNode node = treeView1.SelectedNode;
            if (node != null)//证明有选中节点
            {
                //2.获取用户输入的节点名称，
                string name = textBox2.Text.Trim();
                node.Nodes.Add(name);


                //3.在选中的节点下增加子节点
            }
            else
            {
                MessageBox.Show("请先选择节点!");
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                MessageBox.Show(treeView1.SelectedNode.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //删除选中节点
            if (treeView1.SelectedNode != null)
            {
                //删除当前选中节点，“自杀”
                treeView1.SelectedNode.Remove();
            }
        }
    }
}
