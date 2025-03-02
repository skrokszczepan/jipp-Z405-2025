using System;

namespace FullProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nZadanie 2\n");

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            

            Console.WriteLine("\nZadanie 3\n");
            int result = 5 + 9;
            Console.WriteLine("Wynik dodawania 5 + 9 = " + result);
            

            Console.WriteLine("\nZadanie 1 Operatory\n");
            int number = 68;
            float money = 19.49f;
            string text = "Lubie placki";
            bool isLogged = true;
            char myChar = 'S';
            decimal price = 99.99m;

            Console.WriteLine("Zmienne ");
            Console.WriteLine("number: " + number);
            Console.WriteLine("money: " + money);
            Console.WriteLine("text: " + text);
            Console.WriteLine("isLogged: " + isLogged);
            Console.WriteLine("myChar: " + myChar);
            Console.WriteLine("price: " + price);
            

            Console.WriteLine("\nZadanie 2 Operatory\n");
            string myAge = "Age: ";
            int wifeAge = 18;
            string result2 = myAge + wifeAge;
            Console.WriteLine(result2);

            Console.WriteLine("\nZadanie 3 Operatory\n");
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("AND " + and);
            Console.WriteLine("OR " + or);
            Console.WriteLine("NEGATIVE: " + negative);

            Console.WriteLine("\nZadanie 4 Operatory\n");
            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("Dodawanie: " + add);
            Console.WriteLine("Odejmowanie: " + sub);
            Console.WriteLine("Dzielenie: " + div);
            Console.WriteLine("Mnożenie " + mul);
            Console.WriteLine("Modulo: " + mod);

            Console.WriteLine("\nZadanie 5 Operatory\n");
            string AA = "Ala ";
            string BB = "ma ";
            string CC = "kota.";
            string finalResult = AA + BB + CC;

            Console.WriteLine(finalResult);

        }
    }
}