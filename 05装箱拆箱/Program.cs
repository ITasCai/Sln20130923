using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace _05装箱拆箱
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 装箱与拆箱
            //装箱:把值类型转换为引用类型，就叫装箱。


            //int n = 10;
            //double d = n; //没有发生装箱，因为都是值类型
            //Console.WriteLine(d);


            //int n = 10;
            //string s = n.ToString();//这个不是装箱。string与int是完全不同的两种类型，没有父子类关系，所以不可能发生装箱和拆箱，因为本身就不具备类型直接转换的功能。
            //Console.WriteLine(s);


            //int n = 10;
            ////n是int类型，int就是Int32，而Int32是一个结构继承字System.ValueType而该类又继承自Object,所以int类型与object类型具有子父类关系，所以可以发生类型
            //object o = n;//这里发生了一次装箱。
            //Console.WriteLine(o);


            //Person p = new Person();
            //object o = p;//装箱了吗?都是引用类型，没有装箱。
            //Console.WriteLine(o);




            //拆箱：把引用类型转换为值类型，就叫拆箱。

            //int n = 10;
            //double d = n;
            //int m = (int)d;//拆箱了吗?没有，因为都是值类型。



            //object o = 10;//发生了一次装箱
            //int n = (int)o;//拆箱了


            //double d = 90;

            //object o = d;//装箱

            //int n = (int)o;//拆箱,但是拆箱有问题，装箱的时候使用的什么数据类型，拆箱的时候必须还是使用对应的数据类型拆箱。

            //Console.WriteLine(n);
            //Console.ReadLine();

            #endregion


            #region 装箱与拆箱的效率问题
            //ArrayList arrayList = new ArrayList();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    arrayList.Add(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.ReadLine();


            //List<int> list = new List<int>();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.ReadLine();

            #endregion


            #region 装箱拆箱案例

            //int n = 10, m = 100;
            //string s1 = "58";
            //string s2 = "200";

            //string s = n + m + s1 + s2; //只发生了一次装箱，先把n与m相加，然后再与字符串拼接，调用Concat()方法。

            ////string s = n + s1 + m + s2;//这里发生了两次装箱
            //int r = int.Parse(s);
            //Console.WriteLine(r);//如果遇到函数重载有对应的类型则也不发生装箱。
            ////Console.WriteLine("最后结果是：{0}", r);// 这里调用了object参数的重载所以这里也装箱了
            //Console.ReadLine();




            int n = 10;
            //object o = n;
            IComparable com = n;

            int m = (int)com;

            #endregion


        }
    }


    class Person
    {

    }
}
