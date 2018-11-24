using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organ
{
    public class Colheita
    {
        int qtd_colheita;

        public Plantio plantio { get; set; }

        public Colheita(int qtd_colheita, String data_colheita, int cod_plantio)
        {
            this.Qtd_colheita = qtd_colheita;
            plantio.Data_colheita = data_colheita;
            plantio.Cod_plantio = cod_plantio;
        }

        public int Qtd_colheita
        {
            get { return qtd_colheita; }
            set { qtd_colheita = value; }
        }

        public void RealizarColheita(Colheita c)
        {

        }

        public void RepetirColheita(Colheita c)
        {

        }
    }
}
