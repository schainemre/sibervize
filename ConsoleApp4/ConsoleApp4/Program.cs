using System;
using System.IO;
using System.Diagnostics;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo islem = new ProcessStartInfo();
            islem.Arguments = "-oX nmap -T4 -A -v 192.168.1.1/25";
            islem.RedirectStandardOutput = true;    //programın çıktısını yönlendir
            islem.FileName = "nmap";   //programın ismi
            Process a = new Process();
            a.StartInfo = islem;
            a.Start();
            StreamReader stdout = a.StandardOutput;  //nmap'in stdout'u Console çıktısı
            StreamWriter b = new StreamWriter("stdout.txt");
            b.WriteLine(stdout.ReadToEnd());
            a.WaitForExit();
            Console.WriteLine("program bitti kapatabilirsiniz");
            Console.ReadKey(true);
        }
    }
}
