using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice - Indexer

            //PhoneBook phoneBook = new PhoneBook();
            //phoneBook[0] = "a";
            //phoneBook[1] = "b";
            //phoneBook[2] = "c";


            //Console.WriteLine(phoneBook[0]);
            //Console.WriteLine(phoneBook[1]);
            //Console.WriteLine(phoneBook[2]);
            //Console.WriteLine(phoneBook["a"]);
            //Console.WriteLine(phoneBook["b"]);
            //Console.WriteLine(phoneBook["z"]);

            #endregion

            #region Practice - 

            //int n = 7;
            //Console.WriteLine(n.FindAverage());

            //string s = "coding";
            //Console.WriteLine(s.Sub());

            #endregion

            #region Practice - Boxing & Unboxing

            //int number = 5;
            //object obj = number; //5
            //number = 6;
            //Console.WriteLine(obj);
            //Console.WriteLine(number);

            //int number2 = 5;
            //object obj2 = number2; //5
            //int number3 = (int)obj2; //5
            //Console.WriteLine(number3);

            #endregion

            #region HomeWork

            //Debug impossible
            PhoneBook phoneBook = new PhoneBook();
            phoneBook["AliBaba"] = "123456789";
            //phoneBook["AliBaba"] = "123456789";
            phoneBook["AnqutBaba"] = "987654321";


            Console.WriteLine(phoneBook["AliBaba"]);
            Console.WriteLine(phoneBook["AnqutBaba"]);

            #endregion
        }
    }

    #region Practice - Indexer

    //public class PhoneBook
    //{
    //    public string[] names = new string[3]; // "a","b","c"

    //    public string this[int number]
    //    {
    //        get
    //        {
    //            return names[number];
    //        }
    //        set
    //        {
    //            names[number] = value;
    //        }
    //    }

    //    public string this[string name]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < names.Length; i++)
    //            {
    //                if (names[i] == name)
    //                {
    //                    return names[i];
    //                }
    //            }

    //            return null;
    //        }
    //    }
    //}

    #endregion

    #region Practice - Extensions

    //public static class Extensions
    //{
    //    public static float FindAverage(this int number)
    //    {
    //        return number / 2F;
    //    }
    //    public static string Sub(this string str)
    //    {
    //        return str.Substring(3, 2);
    //    }
    //}

    #endregion
}
