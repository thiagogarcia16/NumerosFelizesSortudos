using System;
using System.Linq;

namespace NumerosFelizesSortudos
{
    public static class NumeroSortudo
    {
        public static bool EhNumeroSortudo(int numero)
        {
            if ((numero % 2) == 0)
                return false;

            var listaNumeros = Enumerable.Range(1, numero).Where(n => n % 2 > 0).ToList();
            var lista = listaNumeros.Select((v, i) => new { Index = i, Value = v }).ToList();

            for (int j = 3; j < numero; j++)
            {
                if (lista.Count <= j || lista[j].Value > numero)
                    return lista.Any(l => l.Value == numero);
                lista = lista.Where(x => (x.Index+1) % j > 0 && (x.Index+1) > j).ToList();
            }

            return false;
        }
    }
}