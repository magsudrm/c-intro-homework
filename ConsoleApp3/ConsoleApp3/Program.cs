using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan proqram

            Console.WriteLine("Birinci ededi daxil et!");
            string birinci = Console.ReadLine();
            int num1 = Convert.ToInt32(birinci);
            Console.WriteLine("İkinci ededi daxil et!");
            string ikinci = Console.ReadLine();
            int num2 = Convert.ToInt32(ikinci);
            var sum0 = 0;
            var count = 0;
            while (num1 < num2)
            {
                if (num1 % 21 == 0)
                {
                    sum0 = sum0 + num1;
                    count++;
                    num1++;
                }
                else
                {
                    num1++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine(sum0/count);
            }
            else
            {
                Console.WriteLine("0 a bolme yoxdur!");


                //Verilmiş ədədin rəqəmləri cəmini tapan proqram

                Console.WriteLine("Ededi daxil et!");
                string input4 = Console.ReadLine();
                var eded = Convert.ToInt32(input4);
                var sum = 0;

                while (eded != 0)
                {
                    var x = eded % 10;
                    eded = (eded - x) / 10;
                    sum = sum + x;
                }
                Console.WriteLine(sum);


                //Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram;

                Console.WriteLine("Ayin sira nomresini daxil edin!");
                string input0 = Console.ReadLine();
                var nomre = Convert.ToInt32(input0);

                if (nomre < 1 || nomre > 12)
                {
                    Console.WriteLine("Daxil etdiyiniz eded yanlisdir!");
                }
                if (nomre == 12 || nomre <= 2)
                {
                    Console.WriteLine("Qis fesli");
                }
                if (nomre >= 3 && nomre <= 5)
                {
                    Console.WriteLine("Yaz fesli");
                }
                if (nomre >= 6 && nomre <= 8)
                {
                    Console.WriteLine("Yay fesli");
                }
                if (nomre >= 9 && nomre <= 11)
                {
                    Console.WriteLine("Payiz fesli");
                }

                //Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini
                //istəməlidir ta ki rəqəmsiz daxil edilənədək.

                Console.WriteLine("Yazini daxil edin!");
                string word = Console.ReadLine();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == '1')
                    {
                        Console.WriteLine("Reqem var yeniden yaz!");
                        break;
                    }
                    if (word[i] == '2')
                    {
                        Console.WriteLine("Reqem var yeniden yaz!");
                        break;
                    }
                    if (word[i] == '3')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '4')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '5')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '6')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '7')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '8')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '9')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                    if (word[i] == '0')
                    {
                        Console.WriteLine("Rəqəm var yenidən yaz");
                        break;
                    }
                }



                //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
                //Misalçün consoledan 5,10 və + daxil edilsə 5 və 10 - u toplayıb nəticəsini göstərsin.Console - dan daxil
                //edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

                Console.WriteLine("Birinci ededi daxil edin!");
                string input1 = Console.ReadLine();
                int eded1 = Convert.ToInt32(input1);
                Console.WriteLine("İkinci ededi daxil edin!!");
                string input2 = Console.ReadLine();
                int eded2 = Convert.ToInt32(input2);
                Console.WriteLine("Operatoru daxil edin!");
                string input3 = Console.ReadLine();


                if (input3 == "+")
                {
                    Console.WriteLine(eded1 + eded2);
                }
                if (input3 == "-")
                {
                    Console.WriteLine(eded1 - eded2);
                }
                if (input3 == "/")
                {
                    Console.WriteLine(eded1 / eded2);
                }
                if (input3 == "*")
                {
                    Console.WriteLine(eded1 * eded2);
                }
                if (input3 != "+,-,/,*")
                {
                    Console.WriteLine("Operator yanlisdir!");
                }


            }


        }
    }
}

