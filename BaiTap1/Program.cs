using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static int[] EnterPrintE()
        {
            Console.WriteLine("ĐỌC VÀ IN CÁC PHẦN TỬ MÃNG TRONG C#");
            Console.WriteLine("____________________________________");
            Console.Write("Nhập vào số  phần tử mãng ");
            int n = int.Parse(Console.ReadLine());
            String result = "In các phần tử của mãng : ";
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập vào phân tử thứ {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
                result += " " + arr[i];
            }
            Console.WriteLine(result);
            return arr;
        }
        static void mixArr()
        {
            Console.WriteLine("Trộn ghép 2 mảng trong C#");
            Console.WriteLine("____________________________________");
            int[] arr1 = EnterPrintE();
            int[] arr2 = EnterPrintE();
            int i = 0;
            int[] newArr = new int[arr1.Length + arr2.Length];
            while (i < newArr.Length)
            {
                if (i < arr1.Length)

                {
                    newArr[i] = arr1[i];
                }
                else
                {
                    newArr[i] = arr2[i - arr1.Length];
                }

                i++;
            }
            Array.Sort(newArr, (a, b) => b.CompareTo(a));
            foreach (int num in newArr)
            {
                Console.Write(" {0}", num);
            }
        }
        static void appearWord()
        {
            Console.Write("nhập vào số phần tử cần lưu giữ : ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("phần tử  - ");
                string text = Console.ReadLine();
                if (text.Contains(" "))
                {
                    Console.WriteLine("Dữ liệu nhập vào không hợp lệ !");
                    break;
                }
                String[] str = text.Split(':');

                if (myDictionary.ContainsKey(str[0]))
                {
                    myDictionary[str[0]] += int.Parse(str[1]);
                }
                else
                {
                    myDictionary.Add(str[0], int.Parse(str[1]));
                }
            }
            var newDic = myDictionary.OrderByDescending((x) => x.Value);
            foreach (var item in newDic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        static void PrintDynamicArr()
        {
            Console.Write("Chèn phần tử vào mảng trong C# !");
            //int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(EnterPrintE());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(" phần tử  - {0}", i);
            //    list.Add(int.Parse(Console.ReadLine()));
            //}
            Console.Write("Nhập vào giá trị phần tử cần chèn : ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào vị trí  phần tử cần chèn : ");
            int index = int.Parse(Console.ReadLine());
            list.Insert(index, value);
            foreach (var item in list)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();
        }
        static void speadArr()
        {
            Console.WriteLine("Tách mảng thành 2 mảng chẳn và lẻ !");
            Console.WriteLine("_____________________________________");
            int[] arr = EnterPrintE();
            List<int> EvenList = new List<int>();
            String printEven = "Các phần tử chẳn là \n";
            List<int> OddList = new List<int>();
            String printOdd = " Các phần tử lẻ là :  \n";
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    EvenList.Add(item);
                    printEven += " " + item;
                }
                else
                {
                    OddList.Add(item);
                    printOdd  += " " + item;
                }
            }
            Console.WriteLine(printEven);
            Console.WriteLine(printOdd);

        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //EnterPrintE();
            //mixArr();
            //appearWord();
            PrintDynamicArr();
            //speadArr();
        }
    }
}
