using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos.Modelo
{
   public class Validacao: absPropriedades
    {
        public Validacao(String dia, String mes): base(dia,mes)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.numeroDia = Convert.ToDouble(this.dia);
                this.numeroMes = Convert.ToDouble(this.mes);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro: digite apenas números";                
            }
        }
    }
}
