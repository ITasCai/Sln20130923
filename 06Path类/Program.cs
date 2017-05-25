using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _06Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Path 操作文件路径的类   文件路径→字符串
            //Path类就是对字符串的操作，与实际的文件没有任何关系

            //string path = @"C:\Documents and Settings\Administrator\My Documents\exercises\ITCAST-102\ipmsg.exe";
            ////获取文件名，带后缀
            //string filename = Path.GetFileName(path);
            //Console.WriteLine(filename);


            ////获取文件名不带后缀
            //string fname = Path.GetFileNameWithoutExtension(path);
            //Console.WriteLine(fname);


            ////只获取文件后缀
            //string ext = Path.GetExtension(path);
            //Console.WriteLine(ext);


            ////截取文件的路径部分，不带文件名、
            //string filePath = Path.GetDirectoryName(path);
            //Console.WriteLine(filePath);

            ////只是把字符串中的文件的路径改了，与磁盘上的文件无关。
            //string newpath = Path.ChangeExtension(path, ".txt");
            //Console.WriteLine(newpath);

            //string s1 = @"c:\abc\xyz\aa\";
            //string s2 = "abc.avi";

            ////连接两个路径。
            //string full = Path.Combine(s1, s2);  //s1 + s2;
            //Console.WriteLine(full);









            ////获取当前的临时目录的路径。
            //string path = Path.GetTempPath();
            //Console.WriteLine(path);


            //string tmpName = Path.GetTempFileName();
            //Console.WriteLine(tmpName);
            //Console.ReadLine();


          


            //Console.ReadLine();





            #endregion
        }
    }
}
