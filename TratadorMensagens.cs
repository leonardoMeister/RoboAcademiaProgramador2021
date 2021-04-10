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
            while (0 == 0)
            {
                Console.WriteLine("Escreva o comando para o Robo [Ex = EMEEMMDM]: ");
                string mensagemUsuario = Console.ReadLine();
                string[] comandos = new string[mensagemUsuario.Length];
                bool valorInvalido = false;
                for (int i = 0; i < mensagemUsuario.Length; i++)
                {
                    comandos[i] = mensagemUsuario[i].ToString();
                    if (comandos[i].ToLower() != "d" && comandos[i].ToLower() != "e" && comandos[i].ToLower() != "m")
                    {
                        valorInvalido = true;
                    }
                }
                if (valorInvalido)
                {
                    Console.WriteLine("Valor Inválido, Favor Tentar novamente!");
                    continue;
                }
                return comandos;
            }
        }
        public static int[] pegarAreaMapa()
        {
            while (0 == 0)
            {
                try
                {
                    int[] coord = new int[2];
                    Console.WriteLine("Informe a área do mapa [Ex = 2 3]: ");
                    String valorXY = Console.ReadLine();
                    String[] separarXY = valorXY.Split();
                    coord[0] = Convert.ToInt32(separarXY[0]);
                    coord[1] = Convert.ToInt32(separarXY[1]);
                    return coord;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro Tente Novamente\n");
                }
            }
        }
        public static String[] pegarCoordenadasRobo()
        {
            while (0 == 0)
            {
                try
                {
                    String[] separarXYZ;
                    Console.WriteLine("Informe uma coordenada inicial para o Robô [Ex = 2 3 N]: ");
                    String valorXY = Console.ReadLine();
                    separarXYZ = valorXY.ToLower().Split();
                    { //verificando se são numeros
                        int teste = Convert.ToInt32(separarXYZ[0]);
                        teste = Convert.ToInt32(separarXYZ[1]);
                    }
                    { //verificando se a direção é uma opção valida
                        if (!(separarXYZ[2].ToLower() == "s" || separarXYZ[2].ToLower() == "n" || separarXYZ[2].ToLower() == "l" || separarXYZ[2].ToLower() == "o"))
                        {
                            Console.WriteLine("Direção Inválida, favor Inserir um valor valido!\n[S,N,L,O]\n");
                            continue;
                        }
                    }
                    return separarXYZ;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor Invalido para Coordenadas X ou Y.\nFavor inserir um valor Válido!\n");
                }
            }
        }
        public static void boasVindas(String numeroRobo)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("------Seja Bem Vindo ao Assistente Tupiniquim I------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"----------------------{numeroRobo}-------------------------");
            Console.WriteLine("-----------------------------------------------------\n");

        }
    }
}