using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDA_N2B2
{
    public class RegistroCliente : IRegistro, IRegistroDicionario
    {
        public RegistroCliente(string path)
        {
            VerifyContent(path);
            SetContent(path);
        }

        Dictionary<object, object> conteudo = new Dictionary<object, object>();
        public Dictionary<object, object> GetContent() => conteudo;

        public void SetContent(string path)
        {
            string[] linhas = File.ReadAllLines(path, Encoding.UTF8);
            string[] dados;

            HashSet<string> cpf = new HashSet<string>();

            foreach (var item in linhas)
            {

                dados = item.Split('|');

                if (cpf.Add(dados[0]))
                    conteudo.Add(dados[0], dados[1]);

            }
        }

        public void VerifyContent(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Arquivo Cliente não encontrado!");
        }
    }
}

