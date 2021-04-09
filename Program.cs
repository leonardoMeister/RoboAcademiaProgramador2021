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
            TratadorMensagens.boasVindas();
           // string[] comando = TratadorMensagens.pegarComando();
            int[] coordenadas = TratadorMensagens.pegarXY();

        }
 
        static void Main(string[] args)
        {
            
            new Program();
        }
    }
}
