using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public class RegistroVenda : IRegistro
    {
        private Dictionary<object, object> cpf;
        private Dictionary<int, Produto> codigoProduto;

        List<Venda> content = new List<Venda>();

        private HashSet<string> VendasIndividuais = new HashSet<string>();
        private HashSet<string> ProdutosVendidos = new HashSet<string>();
        public RegistroVenda(string path, Dictionary<object, object> cpf, Dictionary<int, Produto> codigoProduto)
        {
            this.cpf = cpf;
            this.codigoProduto = codigoProduto;

            VerifyContent(path);
            SetContent(path);

        }

        public List<Venda> GetContent() => content;
        public HashSet<string> GetVendasIndividuais() => VendasIndividuais;

        public void SetContent(string path)
        {
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var dados = line.Split('|');

                if (cpf.ContainsKey(dados[1]) && codigoProduto.ContainsKey(Convert.ToInt32(dados[2])))
                {
                    VendasIndividuais.Add(dados[0]);
                    ProdutosVendidos.Add(dados[2]);
                    Venda venda = new Venda(dados);
                    content.Add(venda);
                }
            }
        }

        public void VerifyContent(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Arquivo Venda não encontrado!");
        }
    }
}
