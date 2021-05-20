using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public class Venda
    {
        #region Atributos
        public string Codigo { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string DataVenda { get; set; }
        #endregion
        public Venda(string[] conteudo)
        {
            Codigo = conteudo[0];
            Cliente = conteudo[1];
            Produto = conteudo[2];
            DataVenda = conteudo[3];
            
        }

    }
}
