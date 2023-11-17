using System;

class Program
{
    static void Main()
    {
        // Variável double com parte fracionária
        double numeroDouble = 10.75;

        // Tentativa de conversão para int
        int numeroInteiro;
        // Usando conversão explícita
        numeroInteiro = (int)numeroDouble;

        Console.WriteLine($"Conversão bem-sucedida: {numeroInteiro}");
        
    }
}
