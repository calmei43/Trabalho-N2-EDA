using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public class RegistroCategoria : IRegistro, IRegistroDicionario
    {
        Dictionary<object, object> conteudo = new Dictionary<object, object>();

        public RegistroCategoria(string path)
        {
            VerifyContent(path);
            SetContent(path);
        }

        public Dictionary<object, object> GetContent() => conteudo;

        public void SetContent(string path)
        {
            string[] linhas = File.ReadAllLines(path, Encoding.UTF8);
            string[] dados;


            foreach (var item in linhas)
            {

                dados = item.Split('|');

                conteudo.Add(Convert.ToInt32(dados[0]), dados[1]);

            }
        }

        public void VerifyContent(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Arquivo Categoria não encontrado!");
        }
    }
}
