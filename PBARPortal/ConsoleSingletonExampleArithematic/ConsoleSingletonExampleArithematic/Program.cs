using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSingletonExampleArithematic
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator.Instance.valueOne = 5;
            calculator.Instance.valueTwo = 10.5;
            
           Console.WriteLine("Addition = " + calculator.Instance.addition());
            Console.WriteLine("Substraction = " + calculator.Instance.substraction());
            Console.WriteLine("Multiplication = " + calculator.Instance.mul());
            Console.WriteLine("Division = " + calculator.Instance.div());


            Console.WriteLine("---------------------------------------------");


            calculator.Instance.valueTwo = 5;
            Console.WriteLine("Addition = " + calculator.Instance.addition());
            Console.WriteLine("Substraction = " + calculator.Instance.substraction());
            Console.WriteLine("Multiplication = " + calculator.Instance.mul());
            Console.WriteLine("Division = " + calculator.Instance.div());


        }
    }

   public sealed class calculator
    {
        private calculator()
        {

        }
        private static calculator instance = null;
        public static calculator Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new calculator();
                }
                return instance;
            }
        }
        public double valueOne { get; set; }
        public double valueTwo { get; set; }
        public double addition()
        {
            return valueOne + valueTwo;
        }
        public double substraction()
        {
            return valueTwo - valueOne;
        }
        public double mul()
        {
            return valueOne * valueTwo;
        }
        public double div()
        {
            return valueTwo / valueOne;
        }
    }
}
