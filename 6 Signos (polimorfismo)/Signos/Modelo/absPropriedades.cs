using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signos.Modelo
{
   public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        public String resposta;
        public String dia;
        public String mes;
        public Double numeroDia;
        public Double numeroMes;

        public absPropriedades(String dia, String mes)
        {
            this.dia = dia;
            this.mes = mes;
        }
        public absPropriedades(Double numeroDia, Double numeroMes)
        {
            this.numeroDia = numeroDia;
            this.numeroMes = numeroMes;
        }
        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }
    }
}
