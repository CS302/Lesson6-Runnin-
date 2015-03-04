using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Lesson6 - копия");
            int count1 = 1, count2 = 1, count3 = 1, count4 = 1;
            for (int i = 0; i < filePaths.GetLength(0); i++)
            {
                switch (Path.GetExtension(filePaths[i]))
                {
                    case ".exe":
                        File.Move(filePaths[i], Path.GetDirectoryName(filePaths[i]) + "\\" + "data" + count1 + Path.GetExtension(filePaths[i]));
                        count1++;
                        break;
                    case ".pdf":
                        File.Move(filePaths[i], Path.GetDirectoryName(filePaths[i]) + "\\" + "data" + count2 + Path.GetExtension(filePaths[i]));
                        count2++;
                        break;
                    case ".txt":
                        File.Move(filePaths[i], Path.GetDirectoryName(filePaths[i]) + "\\" + "data" + count3 + Path.GetExtension(filePaths[i]));
                        count3++;
                        break;
                    default:
                        File.Move(filePaths[i], Path.GetDirectoryName(filePaths[i]) + "\\" + "Unknown_data" + count4 + Path.GetExtension(filePaths[i]));
                        count4++;
                        break;
                }
            }
            Console.WriteLine("Завершено");
            Console.ReadLine();
            
        }
    }
}
