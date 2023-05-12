using System;
using System.Globalization;

namespace Course {

    class Program {
        static void Main(string[] args) {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F} reais", nome, idade, saldo);
            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


            // bool completo = false;
            // char genero = 'M';
            // char letra = '\u0041';
            // byte n1 = 254;
            // int n2 = 1000;
            // int n3 = 2147483647;
            // long n4 = 2147483648L; // Exclicita a utilização de Long
            // float n5 = 4.5f;
            // double n6 = 4.5;
            // string nome = "Maria Green";
            // object obj1 = "Alex Brown";
            // object obj2 = 4.5f;
            // string - Uma cadeia de caracteres Unicode IMUTÁVEL (segurança, simplicidade, thread safe)
            // object - Um objeto genérico (toda classe em C# é subclasse de object) GetType, Equals, GetHashCode, ToString
            // Funções para valores mínimos e máximos - int.MinValue, int.MaxValue
            // n2 = int.MinValue;
            // n3 = int.MaxValue;
            

            // Console.WriteLine(completo);
            // Console.WriteLine(genero);
            // Console.WriteLine(letra);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(n4);
            // Console.WriteLine(n5);
            // Console.WriteLine(n6);
            // Console.WriteLine(nome);
            // Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}