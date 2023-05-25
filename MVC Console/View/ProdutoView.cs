using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        //método para exibir a lista de produtos
        public void Listar(List<Produto> produto)
        {

             Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:c}");
            }

        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o Código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Informe o Nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o Preço: ");
            novoProduto.Preco = int.Parse(Console.ReadLine());
            
            return novoProduto;
        }
    }
}