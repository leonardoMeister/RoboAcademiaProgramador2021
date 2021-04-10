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
            /*
            //pegando tudo o que precisamos
            TratadorMensagens.boasVindas();
            int[] areaMapa = TratadorMensagens.pegarAreaMapa();
            Console.Clear();
            TratadorMensagens.boasVindas();
            string[] coordenadasRobo = TratadorMensagens.pegarCoordenadasRobo();
            Console.Clear();
            TratadorMensagens.boasVindas();
            string[] comando = TratadorMensagens.pegarComando();
            Console.Clear();
            TratadorMensagens.boasVindas();
            */
            //criar os robos


            //  Robo1   1 2 N   EMEMEMEMM       SAIDA 1 3 N
            //  Robo2   3 3 L   MMDMMDMDDM      SAIDA 5 1 l
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
            Console.ReadLine();

        }

        static void Main(string[] args)
        {

            new Program();
        }
    }
}
