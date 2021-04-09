using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspecificaçãoRobo
{
    class TratadorMensagens
    {       
        public static string[] pegarComando() 
        {
            Console.WriteLine("Escreva o comando a Ser Seguido: [Ex = EMEEMMDM]");
            string mensagemUsuario = Console.ReadLine();
            string[] comandos = new string[mensagemUsuario.Length];
            for (int i = 0; i < mensagemUsuario.Length; i++)
            {
                comandos[i] = mensagemUsuario[i].ToString();
            }

            return comandos;
        }
        public static int[] pegarXY()
        {
            int[] coord = new int[2];

            return coord;
        }

        public static void boasVindas()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----Seja Bem Vindo ao Assistente Tupiniquim I----");
            Console.WriteLine("-------------------------------------------------\n");
        }
    }
}
