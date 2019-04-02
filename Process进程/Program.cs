using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //关闭进程
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            //通过进程打开一些应用程序、文件
            //Process.Start(@"C:\Users\Administrator\Desktop\什么时间做什么事.txt");
            //Process.Start(@"D:\セ產I wanna be the guy\iwbtgbeta(slomo).exe");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("calc");
            //Process.Start("iexplore", "http://www.baidu.com");//"www.baidu.com"

            //通过一个进程打开指定文件
            ProcessStartInfo psi = new ProcessStartInfo(@"D:\Program Files\Tencent\QQ\Bin\QQScLauncher.exe");
            //psi.FileName = @"D:\Program Files\Tencent\QQ\Bin\QQScLauncher.exe";

            //创建一个进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            Console.ReadKey();
        }
    }
}
