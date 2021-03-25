using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodePractice1
{
    class Testing
    {
        public delegate void Mydelegate(int number); // 대리자 선언

        public Mydelegate delegate_instance;
    }


    class MainApp
    {
        static void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) //number 가 3,6,9로 끝나는 값일 때 if문 실행
            {
                Console.WriteLine("{0} : 짝", number);
            }
        }

        static void Main(string[] args)
        {
            Testing class_instance = new Testing();
            class_instance.delegate_instance = new Testing.Mydelegate(DoSomething);

            for (int i = 1; i < 30; i++)
            {
                class_instance.delegate_instance(i);
            }
        }
    }
}
// 주석 추가!!
