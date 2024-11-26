using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleFacade
{
    public class EstoqueService
    {
        public bool VerificarDisponibilidade(string produto, int quantidade)
        {
            Console.WriteLine($"Verificando o estoque para {quantidade} unidade(s) do produto '{produto}'...");
            return true; // Simulando que o produto está disponível
        }
    }
}