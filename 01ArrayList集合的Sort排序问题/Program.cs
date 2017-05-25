using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _01ArrayList集合的Sort排序问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList() { 3, 2, 1, 6, 789, 13, 54 };
            //list.Sort();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.Read();


            //ArrayList list = new ArrayList() {
            //new Person(){ Name="Zhangsan", Age=17},
            //new Person(){ Name="Lisi", Age=15},
            //new Person(){ Name="ZhaoLiu", Age=18},
            //new Person(){ Name="WangQi", Age=27}
            //};

            //list.Sort();

            //Console.Read();
            //MyArrayList mylist = new MyArrayList();

            //mylist.Add(10);
            //mylist.Add(9);
            //mylist.Add(5);
            //mylist.Add(8);
            //mylist.Add(6);


            //MyArrayList mylist = new MyArrayList();

            //mylist.Add("yushangyong");
            //mylist.Add("gaowenmi");
            //mylist.Add("yanliupan");
            //mylist.Add("lirende");
            //mylist.Add("lijingjing");



            //MyArrayList mylist = new MyArrayList();

            //mylist.Add(new Person() { Name = "yushangyong", Age = 10 });
            //mylist.Add(new Person() { Name = "gaowenmi", Age = 13 });
            //mylist.Add(new Person() { Name = "yanliupan", Age = 20 });
            //mylist.Add(new Person() { Name = "lirende", Age = 7 });
            //mylist.Add(new Person() { Name = "lijingjing", Age = 6 });




            //mylist.Sort(new PersonSortByNameLengthDesc());



            //for (int i = 0; i < mylist.Count; i++)
            //{
            //    Console.WriteLine(((Person)mylist[i]).Name);
            //}


            //List<string> list = new List<string>();
            //list.Sort(
            //Console.Read();


            //string msg = "赵";
            //string msg1 = "钱";
            //int n = msg.CompareTo(msg1);
            //Console.WriteLine(n);
            //Console.WriteLine((int)msg[0] + "      " + (int)msg1[0]);
            //Console.Read();



        }
    }

    public class PersonSortByNameLengthDesc : IComparer
    {

        #region IComparer 成员

        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            return p2.Name.Length - p1.Name.Length;
        }

        #endregion
    }


    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }



    //class Person : IComparable
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }

    //    public int Age
    //    {
    //        get;
    //        set;
    //    }


    //    #region IComparable 成员

    //    public int CompareTo(object obj)
    //    {
    //        Person p1 = obj as Person;
    //        return this.Age - p1.Age;
    //    }

    //    #endregion
    //}

    class MyArrayList
    {
        private ArrayList _list = new ArrayList();




        public void Add(object obj)
        {
            _list.Add(obj);
        }

        public object this[int index]
        {
            get
            {
                return _list[index];
            }
        }


        public void Sort()
        {
            //自己写一个冒泡排序法，对_list中的内容进行排序
            for (int i = 0; i < _list.Count - 1; i++)
            {
                for (int j = _list.Count - 1; j > i; j--)
                {
                    #region 写死了，只能对整型排序
                    //if ((int)_list[j] < (int)_list[j - 1])
                    //{
                    //    int tmp = (int)_list[j];
                    //    _list[j] = _list[j - 1];
                    //    _list[j - 1] = tmp;

                    //}
                    #endregion

                    IComparable obj1 = _list[j] as IComparable;

                    IComparable obj2 = _list[j - 1] as IComparable;

                    //判断集合中的元素是否可以成功转换为IComparable接口类型
                    if (obj1 != null && obj2 != null)
                    {
                        //无论集合中存储的是什么类型，这里都可以通过CompareTo来实现比较大小
                        if (obj1.CompareTo(obj2) < 0)
                        {
                            object tmp = _list[j];
                            _list[j] = _list[j - 1];
                            _list[j - 1] = tmp;
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
            }
        }


        //参数是一个比较器，需要自己写一个类来实现。
        public void Sort(IComparer comparer)
        {
            //自己写一个冒泡排序法，对_list中的内容进行排序
            for (int i = 0; i < _list.Count - 1; i++)
            {
                for (int j = _list.Count - 1; j > i; j--)
                {
                    //if (_list[j] < _list[j - 1])
                    //{

                    //}
                    //比较两个元素大小
                    if (comparer.Compare(_list[j], _list[j - 1]) < 0)
                    {
                        object tmp = _list[j];
                        _list[j] = _list[j - 1];
                        _list[j - 1] = tmp;
                    }


                }
            }
        }



        //remove
        public void Remove(object obj)
        {
            _list.Remove(obj);
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }


    }






}
