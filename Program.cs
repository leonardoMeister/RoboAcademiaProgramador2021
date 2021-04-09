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
            TratadorMensagens.boasVindas();
            int[] areaMapa = TratadorMensagens.pegarAreaMapa();
            string[] coordenadasRobo = TratadorMensagens.pegarCoordenadasRobo();
            string[] comando = TratadorMensagens.pegarComando();

            //criar os robos

        }

        static void Main(string[] args)
        {

            new Program();
        }
    }
}
