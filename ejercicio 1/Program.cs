using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de promedios, a continuacion va a ingresar tres numeros");
            Console.WriteLine("Ingrese el primer numero");
            double numero1 = Convert.ToDouble (Console.ReadLine());
            
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            double numero3 = Convert.ToDouble (Console.ReadLine());
            
            double promedio = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine ("El promedio de los tres numeros ingresados es: " + promedio);
        }
    }
}