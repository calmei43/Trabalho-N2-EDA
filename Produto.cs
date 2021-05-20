namespace EDA_N2B2
{
    public class Produto 
    {
        #region Atributos
        public string Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string DataCadastro { get; set; }
        #endregion
        public Produto(string[]conteudo)
        {
            Preco = conteudo[1];
            Descricao = conteudo[2];
            Categoria = conteudo[3];
            DataCadastro = conteudo[4];
        }



    }
}
