using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _07Directory类操作文件夹_目录_
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion


            ////Directory.GetDirectories();
            ////Directory.GetFiles();

            //////Directory.Exists是判断指定的目录是否存在，不会验证文件是否存在
            ////bool b= Directory.Exists(@"c:\xxx\ytyy\zzz\avis");
            ////Console.WriteLine(b);

            //if (Directory.Exists(@"c:\xxx"))
            //{
            //    //只能删除空目录
            //    //Directory.Delete(@"c:\xxx");

            //    //可以删除整个目录，连同子文件、子文件夹都删除了。
            //    Directory.Delete(@"c:\xxx", true);
            //    Console.WriteLine("删除成功1");
            //}
            //else
            //{
            //    Console.WriteLine("没有该路径");
            //}




            ////File.Exists();//验证指定的文件是否存在
            //Console.ReadLine();
            #endregion


            string path = @"C:\DRIVER";
            //读取指定目录下的所有子目录
            //string[] dirs = Directory.GetDirectories(path);
            string[] dirs = Directory.GetDirectories(path,"*a*",SearchOption.AllDirectories);
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=============================");
            //获取指定目录下的所有的子文件
            string[] files = Directory.GetFiles(path,"*b*",SearchOption.AllDirectories);
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



        }
    }
}
