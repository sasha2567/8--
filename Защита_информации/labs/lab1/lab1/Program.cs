using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            string alf =    "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЫЭЮЯ ";
            string alfres = "СОУМКХЧИЩЖЪДЭВЯАБЮГ ЕЬЗШЙЦЁФНТПРЫЛ";
            char c;
            while ((c = (char)Console.Read()) != '\r')
            {
                result += alfres[alf.IndexOf(c)];
            }
            Console.ReadLine();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
