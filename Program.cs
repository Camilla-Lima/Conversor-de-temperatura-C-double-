using System;

namespace HelloWorldApp {

    class Geeks {

        static void Main(string[] args) {

            double fahreinheit = 0;
            double celcius = 0;

        Console.WriteLine("Conversor de temperatura de Fahreinheit para Celcius");

            Console.WriteLine("Insira a temperatura em Fahreinheit: ");
            fahreinheit = Convert.ToDouble(Console.ReadLine());

            celcius = (fahreinheit - 32.0) * (5.0 / 9.0);

            Console.WriteLine("Sua temperatura em Celcius: " + celcius.ToString());
            Console.ReadLine();
        


            
        }
    }
}