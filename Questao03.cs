using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* 
3) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?
*/

namespace desafio_codigo_estagio2
{
    public class Questao03
    {
        public void CalcularSoma()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k += 1;
                soma += k;
            }

            Console.WriteLine($"O número no final da soma é {soma}");
        }
    }
}
