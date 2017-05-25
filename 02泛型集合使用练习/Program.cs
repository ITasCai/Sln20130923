using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02泛型集合使用练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 案例：把分拣奇偶数的程序用泛型实现。List<int>

            //string msg = "2 7 8 3 22 9 5 11";
            //string[] nums = msg.Split(' ');
            //List<string> listOdd = new List<string>();
            //List<string> listEvent = new List<string>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (Convert.ToInt32(nums[i]) % 2 == 0)
            //    {
            //        listEvent.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listOdd.Add(nums[i]);
            //    }
            //}

            //listOdd.AddRange(listEvent);
            //string str = string.Join(" ", listOdd.ToArray());
            //Console.WriteLine(str);
            //Console.Read();
            #endregion


            #region 练习1：将int数组中的奇数放到一个新的int数组中返回。
            //int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> list = new List<int>();
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    if (arrInt[i]%2!=0)
            //    {
            //        list.Add(arrInt[i]);
            //    }
            //}
            //int[] arrOddInt = list.ToArray();
            //for (int i = 0; i < arrOddInt.Length; i++)
            //{
            //    Console.WriteLine(arrOddInt[i]);
            //}
            //Console.ReadKey();

            #endregion


            #region 练习2：从一个整数的List<int>中取出最大数（找最大值）。别用max方法。


            //List<int> list = new List<int>() { 1, 2, 3, 4, 54, 12, 23, 6, 33 };

            //int max = list[0];
            //for (int i = 1; i < list.Count; i++)
            //{
            //    if (list[i] > max)
            //    {
            //        max = list[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.ReadKey();


            #endregion


            #region 练习：把123转换为：壹贰叁。Dictionary<char,char>

            //string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            //Dictionary<char, char> _dict = new Dictionary<char, char>();

            //string[] parts = str.Split(' ');
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    _dict.Add(parts[i][0], parts[i][1]);
            //}
            //while (true)
            //{
            //    Console.WriteLine("请输入阿拉伯数字：");
            //    string number = Console.ReadLine();
            //    char[] chs = number.ToCharArray();
            //    for (int i = 0; i < chs.Length; i++)
            //    {
            //        if (_dict.ContainsKey(chs[i]))
            //        {
            //            chs[i] = _dict[chs[i]];
            //        }
            //    }
            //    Console.WriteLine(new string(chs));

            //}



            #endregion

            #region 计算字符串中每种字母出现的次数（面试题）。 “Welcome ,to Chinaworld”，不区分大小写，打印“W2”“e 2”“o 3”……

            //string msg = "Welcome ,to Chinaworld";
            //msg = msg.ToLower();
            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    //只考虑字母
            //    if (char.IsLetter(msg[i]))
            //    {
            //        if (!dict.ContainsKey(msg[i]))
            //        {
            //            dict.Add(msg[i], 1);
            //        }
            //        else
            //        {
            //            dict[msg[i]]++;
            //        }
            //    }


            //}

            ////遍历dict集合
            //foreach (KeyValuePair<char, int> kv in dict)
            //{
            //    Console.WriteLine(kv.Key + "   出现了  {0}次。", kv.Value);
            //}

            //Console.ReadLine();

            #endregion

            //Console.WriteLine(char.IsLetter('中'));
            //Console.ReadLine();

        }
    }
}
