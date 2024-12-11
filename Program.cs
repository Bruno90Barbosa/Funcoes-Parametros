using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeEstudo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produtos("Cerâmica", 1000, 14.56m);
            Produtos("Azulejo", 1001, 12.34m);
            Produtos("Cimento", 1002, 55.78m);
            Produtos("Lajota", 1003, 1.50m );
            Produtos("Rejunte", 1004, 10.99m);
            Produtos("Areia", 1005, 88.00m);
            Produtos("Brita", 1006, 85.33m);

            Console.ReadKey();
        }

        static void Produtos(string nome, int codigo, decimal valorUnit)
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome do Produto: "+nome);
            Console.WriteLine("Valor Unitário: "+valorUnit);
            Console.WriteLine();

        }

        
    }
}
