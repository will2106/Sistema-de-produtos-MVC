using MVC_Console.Controller;
using MVC_Console.Model;

//instancia do objeto Produto
Produto produto = new Produto();

//instancia do objeto produtoController
ProdutoController controller = new ProdutoController();

//chama o método controlador
controller.CadastrarProduto();

//chama o método controlador
controller.ListarProduto();


