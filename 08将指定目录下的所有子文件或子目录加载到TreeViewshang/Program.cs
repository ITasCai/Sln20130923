using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _08将指定目录下的所有子文件或子目录加载到TreeViewshang
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
