using System;

namespace TiposDeVariaveisCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos numéricos inteiros
            sbyte sbyteVar = -128;
            byte byteVar = 255;
            short shortVar = -32768;
            ushort ushortVar = 65535;
            int intVar = 2147483647;
            uint uintVar = 4294967295;
            long longVar = 9223372036854775807;
            ulong ulongVar = 18446744073709551615;

            // Tipos numéricos de ponto flutuante
            float floatVar = 3.14f;
            double doubleVar = 3.14159265359;
            decimal decimalVar = 3.14159265358979323846m;

            // Tipo caractere
            char charVar = 'A';

            // Tipo string
            string stringVar = "Olá, mundo!";

            // Tipo booleano
            bool boolVar = true;

            // Tipo objeto (referência)
            object objVar = "Sou um objeto";

            // Exibição dos valores e tipos
            Console.WriteLine("TIPOS DE VARIÁVEIS EM C#\n");

            Console.WriteLine($"sbyte: {sbyteVar} (menor tipo inteiro)");
            Console.WriteLine($"byte: {byteVar} (menor tipo inteiro sem sinal)");
            Console.WriteLine($"short: {shortVar}");
            Console.WriteLine($"ushort: {ushortVar}");
            Console.WriteLine($"int: {intVar}");
            Console.WriteLine($"uint: {uintVar}");
            Console.WriteLine($"long: {longVar}");
            Console.WriteLine($"ulong: {ulongVar}\n");

            Console.WriteLine($"float: {floatVar}");
            Console.WriteLine($"double: {doubleVar}");
            Console.WriteLine($"decimal: {decimalVar}\n");

            Console.WriteLine($"char: {charVar}");
            Console.WriteLine($"string: {stringVar}");
            Console.WriteLine($"bool: {boolVar}");
            Console.WriteLine($"object: {objVar}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
