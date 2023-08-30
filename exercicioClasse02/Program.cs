using System;
using System.Globalization;
using exercicioClasse02;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        
        Console.WriteLine("Coloque os dados do produto:");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preco: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Dados do produto: {p}"); 
        Console.Write("Digite o numero de produtos a serem adicionados: ");
        p.AdicionarProduto();       
        Console.WriteLine($"Dados atualizados: {p}");
        Console.Write("Digite o numero de produtos a serem removidos: ");
        p.RemoverProduto();
        Console.WriteLine($"Dados atualizados: {p}");
    }
}