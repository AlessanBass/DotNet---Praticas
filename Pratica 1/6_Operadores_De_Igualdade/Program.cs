using System;

class Program
{
    static void Main()
    {
        // Strings
        string str1 = "Hello";
        string str2 = "World";

        // Verificar se as strings são iguais usando o método Equals
        bool saoIguais = str1.Equals(str2);

        // Ou verificar usando o operador de igualdade (==)
        // bool saoIguais = (str1 == str2);

        // Exibir o resultado
        if (saoIguais)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings são diferentes.");
        }
    }
}
