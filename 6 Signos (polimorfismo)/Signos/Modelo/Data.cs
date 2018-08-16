using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos.Modelo
{
    public class Data: absPropriedades
    {
        #region Datas
        /* Aquário: de 20 janeiro a 18 fevereiro
           Peixes: de 19 fevereiro a 20 março
           Áries: de 21 março a 19 abril
           Touro: de 20 abril a 20 maio
           Gêmeos: de 21 maio a 21 junho
           Câncer: de 22 junho a 22 julho
           Leão: de 23 julho a 22 agosto
           Virgem: de 23 agosto a 22 setembro
           Libra:  de 23 setembro a 22 outubro
           Escorpião: de 23 outubro a 21 novembro
           Sagitário: de 22 novembro a 21 dezembro
           Capricórnio: de 22 dezembro a 19 janeiro */
           
        #endregion Datas

        public Data(Double numeroDia, Double numeroMes): base(numeroDia, numeroMes)
        {
            Executar();
        }
        public override void Executar()
        {
            if( (numeroDia >= 20 && numeroDia <= 31) && (numeroMes == 1) || (numeroDia >= 1 && numeroDia <= 18) && (numeroMes == 2))
            {
                this.resposta = "Seu signo é Aquário";
            }
            if ((numeroDia >= 19 && numeroDia <= 28) && (numeroMes == 2) || (numeroDia >= 1 && numeroDia <= 20) && (numeroMes == 3))
            {
                this.resposta = "Seu signo é Peixes";
            }
            if ((numeroDia >= 21 && numeroDia <= 31) && (numeroMes == 3) || (numeroDia >= 1 && numeroDia <= 19) && (numeroMes == 4))
            {
                this.resposta = "Seu signo é Áries";
            }
            if ((numeroDia >= 20 && numeroDia <= 30) && (numeroMes == 4) || (numeroDia >= 1 && numeroDia <= 20) && (numeroMes == 5))
            {
                this.resposta = "Seu signo é Touro";
            }
            if ((numeroDia >= 21 && numeroDia <= 31) && (numeroMes == 5) || (numeroDia >= 1 && numeroDia <= 21) && (numeroMes == 6))
            {
                this.resposta = "Seu signo é Gêmeos";
            }
            if ((numeroDia >= 22 && numeroDia <= 30) && (numeroMes == 6) || (numeroDia >= 1 && numeroDia <= 22) && (numeroMes == 7))
            {
                this.resposta = "Seu signo é Cancer";
            }
            if ((numeroDia >= 23 && numeroDia <= 31) && (numeroMes == 7) || (numeroDia >= 1 && numeroDia <= 22) && (numeroMes == 8))
            {
                this.resposta = "Seu signo é Leão";
            }
            if ((numeroDia >= 23 && numeroDia <= 31) && (numeroMes == 8) || (numeroDia >= 1 && numeroDia <= 22) && (numeroMes == 9))
            {
                this.resposta = "Seu signo é Virgem";
            }
            if ((numeroDia >= 23 && numeroDia <= 30) && (numeroMes == 9) || (numeroDia >= 1 && numeroDia <= 22) && (numeroMes == 10))
            {
                this.resposta = "Seu signo é Libra";
            }
            if ((numeroDia >= 23 && numeroDia <= 31) && (numeroMes == 10) || (numeroDia >= 1 && numeroDia <= 21) && (numeroMes == 11))
            {
                this.resposta = "Seu signo é Escorpião";
            }
            if ((numeroDia >= 22 && numeroDia <= 31) && (numeroMes == 11) || (numeroDia >= 1 && numeroDia <= 21) && (numeroMes == 12))
            {
                this.resposta = "Seu signo é Sagitário";
            }
            if ((numeroDia >= 22 && numeroDia <= 31) && (numeroMes == 12) || (numeroDia >= 1 && numeroDia <= 19) && (numeroMes == 1))
            {
                this.resposta = "Seu signo é Capricórnio";
            }
        }
    }
}
