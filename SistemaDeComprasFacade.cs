using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleFacade
{
    public class SistemaDeComprasFacade
    {
         private readonly EstoqueService _estoque;
        private readonly PagamentoService _pagamento;
        private readonly NotaFiscalService _notaFiscal;

        public SistemaDeComprasFacade()
        {
            _estoque = new EstoqueService();
            _pagamento = new PagamentoService();
            _notaFiscal = new NotaFiscalService();
        }

        public void ComprarProduto(string produto, int quantidade, string metodoPagamento, decimal valor)
        {
            if (_estoque.VerificarDisponibilidade(produto, quantidade))
            {
                if (_pagamento.ProcessarPagamento(metodoPagamento, valor))
                {
                    _notaFiscal.GerarNota(produto, quantidade);
                    Console.WriteLine("Compra realizada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao processar o pagamento.");
                }
            }
            else
            {
                Console.WriteLine("Produto indisponível no estoque.");
            }
        }
    }
}