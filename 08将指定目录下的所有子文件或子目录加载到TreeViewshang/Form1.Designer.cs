namespace _08将指定目录下的所有子文件或子目录加载到TreeViewshang
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode182});
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode184,
            treeNode185});
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode181,
            treeNode183,
            treeNode186,
            treeNode187,
            treeNode188});
            System.Windows.Forms.TreeNode treeNode190 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode191 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode192 = new System.Windows.Forms.TreeNode("节点13");
            System.Windows.Forms.TreeNode treeNode193 = new System.Windows.Forms.TreeNode("节点14");
            System.Windows.Forms.TreeNode treeNode194 = new System.Windows.Forms.TreeNode("节点11", new System.Windows.Forms.TreeNode[] {
            treeNode192,
            treeNode193});
            System.Windows.Forms.TreeNode treeNode195 = new System.Windows.Forms.TreeNode("节点12");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 79);
            this.treeView1.Name = "treeView1";
            treeNode181.Name = "节点3";
            treeNode181.Text = "节点3";
            treeNode182.Name = "节点8";
            treeNode182.Text = "节点8";
            treeNode183.Name = "节点4";
            treeNode183.Text = "节点4";
            treeNode184.Name = "节点6";
            treeNode184.Text = "节点6";
            treeNode185.Name = "节点7";
            treeNode185.Text = "节点7";
            treeNode186.Name = "节点5";
            treeNode186.Text = "节点5";
            treeNode187.Name = "节点9";
            treeNode187.Text = "节点9";
            treeNode188.Name = "节点10";
            treeNode188.Text = "节点10";
            treeNode189.Name = "节点0";
            treeNode189.Text = "节点0";
            treeNode190.Name = "节点1";
            treeNode190.Text = "节点1";
            treeNode191.Name = "节点2";
            treeNode191.Text = "节点2";
            treeNode192.Name = "节点13";
            treeNode192.Text = "节点13";
            treeNode193.Name = "节点14";
            treeNode193.Text = "节点14";
            treeNode194.Name = "节点11";
            treeNode194.Text = "节点11";
            treeNode195.Name = "节点12";
            treeNode195.Text = "节点12";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode189,
            treeNode190,
            treeNode191,
            treeNode194,
            treeNode195});
            this.treeView1.Size = new System.Drawing.Size(247, 376);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C:\\DRIVER";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "清空所有节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "向TreeView中增加一个根节点";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(301, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "向选中的节点下增加子节点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "显示所选中节点的文本";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(301, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "删除某个选中节点";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 479);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

