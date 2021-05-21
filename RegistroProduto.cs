using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public class RegistroProduto : IRegistro
    {
        Dictionary<int, Produto> content = new  Dictionary<int, Produto>();

       

        public RegistroProduto(string path)
        {
            VerifyContent(path);
            SetContent(path);
        }

        public Dictionary<int,Produto> GetContent() => content;
       
        public void SetContent(string path)
        {
            var lines = File.ReadAllLines("produtos.txt");

            foreach (var line in lines)
            {
                var dados = line.Split('|');

                if (int.Parse(dados[3]) <= 1000)
                {
                    Produto produto = new Produto(dados);

                    
                    content.Add(Convert.ToInt32(dados[0]),produto);
                }
            }
        }

        public void VerifyContent(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Arquivo Produto não encontrado!");
        }
    }
}
