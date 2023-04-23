// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        const int Numero_Partidas = 5;
        const int Numero_Digitos = 4;
        
        Random rnd = new Random();

        Console.WriteLine("Bienvenido a la lotería R E G I O N A L. Adivina una combinación de 4 digitos.");

        for (int partida = 1; partida <= Numero_Partidas; partida++)
        {
            Console.WriteLine($"\nPartida {partida}");

            int numLoteria = rnd.Next(0, 1000);
            string loteria = numLoteria.ToString().PadLeft(Numero_Digitos, '0');

            string combinacion = "";
            do
            {
                Console.Write("Ingresa 4 digitos para jugar: ");
                combinacion = Console.ReadLine().Trim().PadLeft(Numero_Digitos, '0');

                if (combinacion.Length != Numero_Digitos)
                {
                    Console.WriteLine("La combinación debe tener 4 digitos. Intentelo de nuevo.");
                }
            } while (combinacion.Length != Numero_Digitos);

            switch (combinacion == loteria)
            {
                case true:
                    Console.WriteLine("¡Felicidades! ganaste la loteria.");
                    break;
                case false:
                    Console.WriteLine($"Lo sentimos, perdiste. El numero ganador es: {loteria}");
                    break;
            }
        }

        Console.WriteLine("\nFin del juego. Preciona cualquier tecla para salir.");
        Console.ReadKey();
    }
}