namespace ProjetoFormacoes
{
    public class Tecnologo : Formacao
    {
        private bool PlanoEstendido { get; set; }
        public Tecnologo(string descricao, int periodo, bool planoEstendido) : base(descricao, periodo)
        {
            PlanoEstendido = planoEstendido;
        }
        public bool GetPlanoEstendido()
        {
            return PlanoEstendido;
        }
        public void SetPlanoEstendido(bool planoEstendido)
        {
            PlanoEstendido = planoEstendido;
        }
        public void CalcularMensalidade(double fator)
        {
            Mensalidade = Duracao * fator * 8;
        }
        public override void DefinirDuracao()
        {
            SetDuracao(24);
        }
    }
}