using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exampleFacade
{
    public class NotaFiscalService
    {
        public void GerarNota(string produto, int quantidade)
        {
            Console.WriteLine($"Gerando nota fiscal para {quantidade} unidade(s) do produto '{produto}'...");
        }
    }
}