using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pista_em_uso
{
    class PistaEmUso
    {
        public static int CorrecaoDeclinacao(int direcaoVento, int declinacaoMagnetica, bool declinacaoOeste)
        {
            int x = 0;

            if (declinacaoOeste == true)
            {
                x = direcaoVento + declinacaoMagnetica;

                if (x >= 360)
                {
                    x -= 360;
                }

            }

            else if (declinacaoOeste == false)
            {
                x = direcaoVento - declinacaoMagnetica;
                
                if (x < 0)
                {
                    x += 360;
                }
            }

            return x;
        }

        public static int DiferencaGraus(int rumoPista, int correcaoDeclinacao)
        {
            int phi = Math.Abs(rumoPista - correcaoDeclinacao) % 360;
            int diferencaGraus = phi > 180 ? 360 - phi : phi;

            return diferencaGraus;
        }

        public static int Pista180(int rumoPista)
        {
            int x = rumoPista + 180;

            if (x >= 360)
            {
                x -= 360;
            }

            return x;
        }

        public static int ArredondadorPista(int rumoPista)
        {
            double pistaDouble = rumoPista / 10.0D;

            if ((pistaDouble % 1) > 0.5D)
            {
                pistaDouble = Math.Round(pistaDouble);
                return Convert.ToInt32(pistaDouble);
            }
            else
            {
                pistaDouble = Math.Floor(pistaDouble);
                return Convert.ToInt32(pistaDouble);
            }
        }

        public static string SaidaPistaEmUso(int rumoPista, int direcaoVento, int declinacaoMagnetica, bool declinacaoOeste)
        {
            int correcaoDeclinacao = CorrecaoDeclinacao(direcaoVento, declinacaoMagnetica, declinacaoOeste);
            int diferencaGraus = DiferencaGraus(rumoPista, correcaoDeclinacao);

            if (diferencaGraus == 0)
            {
                return string.Format("Pista em uso: {0:00}", ArredondadorPista(rumoPista));
            }

            else if (diferencaGraus == 90)
            {
                return string.Format("Pista em uso: " + "{0:00}", ArredondadorPista(rumoPista)) + " ou " + string.Format("{0:00}", ArredondadorPista(Pista180(rumoPista)));
            }

            else if (diferencaGraus < 90 && diferencaGraus != 0)
            {
                return string.Format("Pista em uso: {0:00}", ArredondadorPista(rumoPista));
            }

            else if (diferencaGraus > 90)
            {
                return string.Format("Pista em uso: {0:00}", ArredondadorPista(Pista180(rumoPista)));
            }
            return "ERRO";
        }
    }
}
