namespace exampleFacade;

class Program
{
    static void Main(string[] args)
    {
            SistemaDeComprasFacade sistemaDeCompras = new SistemaDeComprasFacade();

            // Parâmetros de compra
            string produto = "Notebook";
            int quantidade = 1;
            string metodoPagamento = "Cartão de Crédito";
            decimal valor = 3500.00m;

            // Realiza a compra através da fachada
            sistemaDeCompras.ComprarProduto(produto, quantidade, metodoPagamento, valor);
    }
}
