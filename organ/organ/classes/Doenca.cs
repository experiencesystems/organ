using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Doenca
    {
        private String nome_doenca;
        private String descricao;

        public String Nome_doenca
        {
            get { return nome_doenca; }
            set { nome_doenca = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
