using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Globalization;
namespace exercicioClasse02
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto()
        {
            Quantidade += double.Parse(Console.ReadLine());
        }
        public void RemoverProduto()
        {
            Quantidade -= double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco.ToString(CultureInfo.InvariantCulture)}, {Quantidade} unidades, total: $: {ValorTotal().ToString(CultureInfo.InvariantCulture)}";
        }
    }
}

