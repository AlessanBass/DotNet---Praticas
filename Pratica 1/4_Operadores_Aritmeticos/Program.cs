using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int x = 10;
        int y = 3;

        // Adição
        int soma = x + y;
        Console.WriteLine($"Adição: {soma}");

        // Subtração
        int diferenca = x - y;
        Console.WriteLine($"Subtração: {diferenca}");

        // Multiplicação
        int produto = x * y;
        Console.WriteLine($"Multiplicação: {produto}");

        // Divisão (divisão inteira)
        int quociente = x / y;
        Console.WriteLine($"Divisão (divisão inteira): {quociente}");

        // Divisão (divisão de ponto flutuante)
        double resultadoDivisao = (double)x / y;
        Console.WriteLine($"Divisão (ponto flutuante): {resultadoDivisao}");
    }
}
