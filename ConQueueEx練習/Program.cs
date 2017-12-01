using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConQueueEx練習
{
    class Program
    {
        public static void Printout(IEnumerable myList)
        {
            foreach (object obj in myList)
            {
                Console.Write($"    {obj} ");
                Console.WriteLine("\n");
            }
        }
            

        static void Main(string[] args)
        {
            Queue QName = new Queue();
            string[] aryName = { "david", "tom", "jack", "mary", "bob" };
            for(int i=0;i<aryName.Length;i++)
            {
                QName.Enqueue(aryName[i]);//尾端加入一個元素
            }
            Console.WriteLine($"Queue 原始資料，元素共計：{QName.Count}");
            Printout(QName);



            // 摘要:
            //     移除並傳回在 System.Collections.Queue 開頭的物件。
            //
            // 傳回:
            //     從 System.Collections.Queue 的開頭移除的物件。
            QName.Dequeue();
            Console.WriteLine($"Queue 移除一個資料( QName.Dequeue();移除開頭的物件)，元素共計：{QName.Count}");
            Printout(QName);


            // 摘要:
            //     傳回 System.Collections.Queue 開頭的物件而不移除它。
            Console.WriteLine($"Queue 顯示最前面第一個資料 Peek：{QName.Peek()}");

            Console.WriteLine();

            QName.Clear();
            Console.WriteLine($"Queue 移除所有資料，元素共計：{QName.Count}");
            Printout(QName);

            Console.Read();

        }
    }
}
