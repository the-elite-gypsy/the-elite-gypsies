using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApParseTryParseExample
{
    class Program
    {
        //public void ParseTryParse()
        //{
        //    string number = "100.11";
        //    int val = int.Parse(number);

        //    Console.WriteLine("Using Parse  " +  val);

        //    int result;
        //    bool ifSucces = int.TryParse(number, out result);
        //    Console.WriteLine("Using Try Parse {0} {1} {2}", number ,result, ifSucces);

        //}
        readonly int read = 10;  
        const int cons = 10;

        public Program()
        {
            read = 100;
            //cons = 100;
            Console.WriteLine("const : {0}", cons);
            Console.WriteLine("Read only : {0}", read);
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            //ob.ParseTryParse();
        }
    }
}
