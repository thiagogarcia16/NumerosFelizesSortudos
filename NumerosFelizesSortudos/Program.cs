using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosFelizesSortudos
{
    class Program
    {
        static void Main(string[] args)
        {          
            bool continua = false;
            do
            {
                bool ehNumeroFeliz = false;
                bool ehNumeroSortudo = false;
                Console.WriteLine("Digite um número ou zero(0) para sair:");
                string numero = Console.ReadLine();
                continua = numero != "0";
                if (continua)
                {
                    ehNumeroFeliz = NumeroFeliz.EhNumeroFeliz(numero);
                    ehNumeroSortudo = NumeroSortudo.EhNumeroSortudo(Convert.ToInt32(numero));
                                      
                    Console.WriteLine($"{numero} - Número {(ehNumeroSortudo ? "Sortudo" : "Não-Sortudo")} e {(ehNumeroFeliz ? "Feliz" : "Não-Feliz" )}");                    
                }                    

            } while (continua);
       
        }
    }
}
