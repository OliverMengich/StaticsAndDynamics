using System;

namespace StaticAndDynamicPart1
{
    class Program
    {
        public int Sum(int n1,int n2)
        {
            System.Console.WriteLine("Sum with 2 param");
            return (n1+n2);     
        }
        public int Sum(int n1,int n2,int n3)
        {
            System.Console.WriteLine("Sum with 3 Param");
            return(n1+n2+n3);
        }
        public int Sum(int number,string name)
        {
            
            System.Console.WriteLine("Your Name is",number);  return 1;
        }
        ////////////////////////////////////////////////////////////////////
        
        static void Main(string[] args)
        {
            Program p = new Program();
            {
              Console.WriteLine(p .Sum(2,67));
            }
        }
    }
}
