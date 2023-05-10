﻿using System;

namespace Course {

    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'M';
            char letra = '\u0041';
            byte n1 = 254;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // Exclicita a utilização de Long
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            // string - Uma cadeia de caracteres Unicode IMUTÁVEL (segurança, simplicidade, thread safe)
            // object - Um objeto genérico (toda classe em C# é subclasse de object) GetType, Equals, GetHashCode, ToString


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
        }
    }
}