using System;

namespace NumerosFelizesSortudos
{
    public static class NumeroFeliz
    {
        const int MAXIMO_DE_ITERACOES = 100;
        const string VALOR_NUMERO_FELIZ = "1";

        public static bool EhNumeroFeliz(string numero)
        {
            for (int i = 0; i < MAXIMO_DE_ITERACOES; i++)
            {
                numero = RetornaSomaDosDigitosAoQuadrado(numero);

                if (numero == VALOR_NUMERO_FELIZ)
                    return true;
            }

            return false;
        }

        private static string RetornaSomaDosDigitosAoQuadrado(string numero)
        {
            int soma = 0;
            foreach (char digito in numero)
            {
                var valor = (int)char.GetNumericValue(digito);
                soma += valor * valor;
            }
                

            return soma.ToString();           
        }
    }
}