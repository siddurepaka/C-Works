
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"e:\\");
            di.Create();
           di.CreateSubdirectory("mydir");
            DirectoryInfo[] e = di.GetDirectories();
            foreach (DirectoryInfo x in e)
            {
                Console.WriteLine(x.Name + " " + x.FullName);
            }
            FileInfo[] fi = di.GetFiles();

            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName);
            }
            /* FileStream fs = new FileStream(@"e:\\mydir\a.txt",FileMode.OpenOrCreate,FileAccess.Write);
             StreamWriter sw = new StreamWriter(fs);
             sw.WriteLine("Welcome");
             for(int i=0;i<2;i++)
             {
                 string s = Console.ReadLine();
                 sw.WriteLine(s);
             }
             sw.Close();
             fs.Close();*/

            /* FileStream fs1 = new FileStream(@"e:\\mydir\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
             StreamReader sr= new StreamReader(fs1);
             string s1;
             while((s1=sr.ReadLine())!=null)
             {
                 Console.WriteLine(s1);
             }
             sr.Close();
             fs1.Close();*/
            FileStream fs = new FileStream(@"e:\\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 0;
            char ch = 'd';
            string f = "hello";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(f);
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"e:\\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int a= br.ReadInt32();
            char ch1 = br.ReadChar();
            string s = br.ReadString();
            br.Close();
            fs1.Close();
            Console.WriteLine(a + " " + ch1 + " " + s);
            Console.ReadLine();
        }
    }
}
