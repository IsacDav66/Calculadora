using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, escoge la operación a realizar escogiendo los numeros de al lado");
            int multiplicacion = 1;
            int suma = 2;
            int resta =3;
            int division =4;

            int eleccion;
           

            Console.WriteLine("MULTIPLICACION = 1");
            Console.WriteLine("SUMA = 2");
            Console.WriteLine("RESTA = 3");
            Console.WriteLine("DIVISION = 4");
            eleccion= Convert.ToInt32(Console.ReadLine());
            //MULTIPLICACION
            if (eleccion == 1)
            {
                Console.WriteLine("MULTIPLICACION");
                int number1;
                Console.WriteLine("Escribe el primer numero");
                number1 = Convert.ToInt32(Console.ReadLine());
                int number2;
                Console.WriteLine("Escribe el segundo numero");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado de la multiplicacion es: ");
                Console.WriteLine(number1 * number2);
            }
            if (eleccion == 2)
            {
                Console.WriteLine("SUMA");
                int number1;
                Console.WriteLine("Escribe el primer numero");
                number1 = Convert.ToInt32(Console.ReadLine());
                int number2;
                Console.WriteLine("Escribe el segundo numero");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado de la suma es: ");
                Console.WriteLine(number1 + number2);
            }
            if (eleccion == 3)
            {
                Console.WriteLine("RESTA");
                int number1;
                Console.WriteLine("Escribe el primer numero");
                number1 = Convert.ToInt32(Console.ReadLine());
                int number2;
                Console.WriteLine("Escribe el segundo numero");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado de la resta es: ");
                Console.WriteLine(number1 - number2);
            }
            if (eleccion == 4)
            {
                Console.WriteLine("DIVISION");
                int number1;
                Console.WriteLine("Escribe el primer numero");
                number1 = Convert.ToInt32(Console.ReadLine());
                int number2;
                Console.WriteLine("Escribe el segundo numero");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado de la division es: ");
                Console.WriteLine(number1 / number2);
            }
        }
        
    }
}
