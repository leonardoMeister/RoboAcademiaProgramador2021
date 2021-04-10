using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspecificaçãoRobo
{
    class Robo
    {
         public String direcao;  //norte sul leste oeste
         public int x, y;        //Coordenadas Robo
        public Robo(string direcao, int x, int y)
        {
            this.direcao = direcao;
            this.x = x;
            this.y = y;
        }
        public void interpretadorComandosRobo(string[] listaComandos)
        {
            for (int i = 0; i < listaComandos.Length; i++)
            {
                if (listaComandos[i].ToLower() == "d")
                {
                    alterarDirecaoDireira(); 
                }
                else if (listaComandos[i].ToLower() == "e")
                {
                    alterarDirecaoEsquerda();
                }else if (listaComandos[i].ToLower()=="m")
                {
                    Andar();
                }
            }
        }
        //AVANÇAR
        //leste x+1
        //sul  y-1
        //oeste x-1
        //norte y+1
        private void Andar()
        {
            if (direcao == "l")
            {
                this.x++;
            }
            else if (direcao == "s")
            {
                this.y--;
            }
            else if (direcao == "o")
            {
                this.x--;
            }
            else if (direcao == "n")
            {
                this.y++;
            }
        }
        //     L =-=  S =-= O  =-=  N =-= L
        private void alterarDirecaoDireira()
        {
            if (direcao == "l")
            {
                this.direcao = "s";
            }
            else if (direcao == "s")
            {
                this.direcao = "o";
            }
            else if (direcao == "o")
            {
                this.direcao = "n";
            }
            else if (direcao == "n")
            {
                this.direcao = "l";
            }
        }
        private void alterarDirecaoEsquerda()
        {
            if (direcao == "l")
            {
                this.direcao = "n";
            }
            else if (direcao == "n")
            {
                this.direcao = "o";
            }
            else if (direcao == "o")
            {
                this.direcao = "s";
            }
            else if (direcao == "s")
            {
                this.direcao = "l";
            }
        }
    }
}
