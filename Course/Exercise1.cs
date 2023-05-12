using System.Globalization;


namespace Course {
    internal class Exercise1 {
        static void Main(string[] args) {
            double computador = 2100.00;
            double mesa = 650.50;
            double medida = 53.23456700;
            int anos = 30;
            int codigo = 5290;
            char genero = 'M';

            Console.WriteLine("Produtos:");
            Console.WriteLine($"Computador, cujo preço é $ {computador:F2}");
            Console.WriteLine($"Mesa de escritório, cujo preço é $ {mesa:F2}");

            Console.WriteLine($"Registro: {anos} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F2}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
