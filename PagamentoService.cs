using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleFacade
{
    public class PagamentoService
    {
        public bool ProcessarPagamento(string metodo, decimal valor)
        {
            Console.WriteLine($"Processando pagamento de {valor:C} usando {metodo}...");
            return true; // Simulando que o pagamento foi aprovado
        }
    }
}