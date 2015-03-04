using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowStaticMethods();

            //ShowNonStaticMethods();

            //ShowNull();

            //ShowCreation();
            int width = 80;
            int height = 2012;
            Console.SetWindowSize(width, height);

            string[] path;
            

            //string path = @"C:\Lesson6\1\2\3\file1.txt";
            File.Move(@"C:\Lesson6\1\2\3\file1.txt", @"C:\Lesson6\1\2\3\data1.txt");
            /*FileInfo file = new FileInfo(path);
            Console.WriteLine(file.Name);*/

            /*Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));*/

            string dir = @"C:\Lesson6\1\2\3"; 
            string temp = "temp_24";
            string fileName = "data.txt";

            string path1 = dir + "\\" + temp + "\\" + fileName;
            Console.WriteLine(path1);

            path1 = string.Format("{0}\\{1}\\{2}", dir, temp, fileName);
            Console.WriteLine(path1);

            path1 = Path.Combine(dir, temp, fileName);
            Console.WriteLine(path1);
            Directory.CreateDirectory(@"Lesson6\Temp\Temp1\1\2\3");

            Console.ReadLine();
        }

        private static void ShowCreation()
        {
            FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            FileInfo file2 = new FileInfo(@"C:\Lesson6\extjs\2.txt");
            file1.Create();
            file2.Create();

            FileInfo file3 = new FileInfo(@"C:\Lesson6\Test\3.txt");
            if (!file3.Directory.Exists)
            {
                file3.Directory.Create();
            }
            file3.Create();

            Directory.CreateDirectory(@"C:\Lesson6\1\2\3\4\5\6\7\8\9");
        }

        private static void ShowNull()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6\extjs\examples\calendar\resources\css\папка");
            while (dir != null)
            {
                Console.WriteLine(dir.FullName);
                dir = dir.Parent;
            }
            //Console.WriteLine(dir.FullName);

            //Console.WriteLine(dir.Root.Parent.FullName); 
        }

        private static void ShowNonStaticMethods()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6");
            if (dir.Exists)
            {
                FileInfo[] files = dir.GetFiles("*.exe", SearchOption.AllDirectories);
                for (int i = 0; i < files.GetLength(0); i++)
                {
                    Console.WriteLine(files[i].FullName);
                    Console.WriteLine(files[i].CreationTime);
                    Console.WriteLine(files[i].Length);
                    Console.WriteLine();
                }
            }
        }

        private static void ShowStaticMethods()
        {
            //string[] filePaths = Directory.GetFiles(@"C:\Lesson6");

            //string[] filePaths = Directory.GetFiles(@"C:\Lesson6", "*.exe");
            // "f*.exe" любые экзешники, имя которых начитается с буквы f

            string[] filePaths = Directory.GetFiles(@"C:\Lesson6", "*.exe", SearchOption.AllDirectories);
            for (int i = 0; i < filePaths.GetLength(0); i++)
            {
                Console.WriteLine(filePaths[i]);
                Console.WriteLine(File.GetCreationTime(filePaths[i]));
                Console.WriteLine();
            }
        }
    }
}
