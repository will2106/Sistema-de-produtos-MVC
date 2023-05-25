using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Console.Model;
using MVC_Console.View;

namespace MVC_Console.Controller
{
    public class ProdutoController
    {
        //instanciar o objeto Produto e Produtoview
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProduto()
        {
            //lista de produtos chamada pela Model
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição (View) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }

        
        //método controlador para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chama para a view que recebe cada objeto a ser inserido no CSV
            Produto novoProduto = produtoView.Cadastrar();

            //CHAMA PARA A MODEL PARA INSERIR ESSE OBJETO NO CSV
            produto.Inserir(novoProduto);
        }
    }
}