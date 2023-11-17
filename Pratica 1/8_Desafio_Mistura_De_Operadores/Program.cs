using System;

class Program
{
    static void Main()
    {
        // Variáveis
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        // Verificar se num1 é maior que num2
        bool num1MaiorQueNum2 = num1 > num2;

        // Verificar se num3 é igual a num1 + num2
        bool num3IgualSomaNum1Num2 = num3 == (num1 + num2);

        // Exibir resultados
        if (num1MaiorQueNum2)
        {
            Console.WriteLine("num1 é maior que num2.");
        }
        else
        {
            Console.WriteLine("num1 não é maior que num2.");
        }

        if (num3IgualSomaNum1Num2)
        {
            Console.WriteLine("num3 é igual a num1 + num2.");
        }
        else
        {
            Console.WriteLine("num3 não é igual a num1 + num2.");
        }
    }
}
