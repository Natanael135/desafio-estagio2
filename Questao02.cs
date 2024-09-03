using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_codigo_estagio2
{
    public class Questao02
    {
        private string textoParaVerificar;

        public Questao02(string texto)
        {
            textoParaVerificar = texto;
            VerificarLetraA();
        }

        private void VerificarLetraA()
        {
            int contador = 0;

            foreach (char c in textoParaVerificar)
            {
                if (c == 'a' || c == 'A')
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine($"\nA letra 'a' foi encontrada {contador} vezes na string fornecida.");
            }
            else
            {
                Console.WriteLine("\nA letra 'a' não foi encontrada na string fornecida.");
            }
        }
    }
}
