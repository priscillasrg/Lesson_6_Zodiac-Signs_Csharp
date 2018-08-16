using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String dia, String mes): base(dia, mes)
        {
            Executar();
        }
        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.dia, this.mes);

            if(validacao.mensagem.Equals(""))
            {
                absPropriedades data = new Data(validacao.numeroDia, validacao.numeroMes);
                this.resposta = data.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
