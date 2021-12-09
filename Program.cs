using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspecificaçãoRobo
{
    class Program
    {
        Robo robo1, robo2;
        public Program()
        {
            //pegando tudo o que precisamos
            TratadorMensagens.boasVindas(" Mapa ");
            int[] areaMapa = TratadorMensagens.pegarAreaMapa();
            Console.Clear();
            TratadorMensagens.boasVindas("Robô 1");
            string[] coordenadasRobo1 = TratadorMensagens.pegarCoordenadasRobo();
            Console.Clear();
            TratadorMensagens.boasVindas("Robô 1");
            string[] comando1 = TratadorMensagens.pegarComando();
            Console.Clear();
            TratadorMensagens.boasVindas("Robô 2");
            string[] coordenadasRobo2 = TratadorMensagens.pegarCoordenadasRobo();
            Console.Clear();
            TratadorMensagens.boasVindas("Robô 2");
            string[] comando2 = TratadorMensagens.pegarComando();
            Console.Clear();
            //instanciando Robos nas coordenadas informadas
            robo1 = new Robo(coordenadasRobo1[2], Convert.ToInt32(coordenadasRobo1[0]),Convert.ToInt32(coordenadasRobo1[1]));
            robo2 = new Robo(coordenadasRobo2[2], Convert.ToInt32(coordenadasRobo2[0]), Convert.ToInt32(coordenadasRobo2[1]));
            //Passando os comandos para os Robos
            robo1.interpretadorComandosRobo(comando1);
            robo2.interpretadorComandosRobo(comando2);         
            //Teste Manual
            {
                /* ROBO 1       1 2 N   EMEMEMEMM       SAIDA 1 3 N
                robo1 = new Robo("n",1,2);
                Console.WriteLine("----------------------");
                Console.WriteLine(robo1.x);
                Console.WriteLine(robo1.y);
                Console.WriteLine(robo1.direcao);
                string[] aux =TratadorMensagens.pegarComando();
                robo1.interpretadorDeComandosRobo(aux);
                Console.WriteLine("----------------------");
                Console.WriteLine(robo1.x);
                Console.WriteLine(robo1.y);
                Console.WriteLine(robo1.direcao);
                Console.ReadLine();                 */

                /* ROBO 2       3 3 L   MMDMMDMDDM      SAIDA 5 1 l
                robo1 = new Robo("l",3,3);
                Console.WriteLine("----------------------");
                Console.WriteLine(robo1.x);
                Console.WriteLine(robo1.y);
                Console.WriteLine(robo1.direcao);
                string[] aux =TratadorMensagens.pegarComando();
                robo1.interpretadorDeComandosRobo(aux);
                Console.WriteLine("----------------------");
                Console.WriteLine(robo1.x);
                Console.WriteLine(robo1.y);
                Console.WriteLine(robo1.direcao);
                Console.ReadLine();                 */
            }
            //saidas
            TratadorMensagens.boasVindas("Saidas");
            Console.WriteLine($"-------------Robô 1    x{robo1.x}, y{robo1.y}, Direção {robo1.direcao.ToUpper()}-------------\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"\n-------------Robô 2    x{robo2.x}, y{robo2.y}, Direção {robo2.direcao.ToUpper()}-------------");
            Console.WriteLine("\n-----------------------------------------------------\n\n");
            Console.Read();
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}
