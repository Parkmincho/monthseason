using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.Write("이번 달은 몇 월인가요 : ");
            var input = Console.ReadLine();


            switch (input)
            {
                case "12월": 
                case "1월":
                case "2월": 
                    Console.WriteLine("겨울입니다");
                    break;
                case "3월":
                case "4월":
                case "5월":
                    Console.WriteLine("봄입니다");
                    break;
                case "6월":
                case "7월":
                case "8월":
                    Console.WriteLine("여름입니다");
                    break;
                case "9월":
                case "10월":
                case "11월":
                    Console.WriteLine("가을입니다");
                    break;
                default:
                    Console.WriteLine("잘못입력하였습니다");
                    break;
            }
        }
    }
}
