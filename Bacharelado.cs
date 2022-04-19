namespace ProjetoFormacoes
{
    public class Bacharelado : Formacao
    {
        private string ProjetoConclusao { get; set; }
        private int CargaHorariaEstagio { get; set; }
        public Bacharelado(string descricao, int periodo, string projetoConclusao, int cargaHorariaEstagio) : base(descricao, periodo)
        {
            ProjetoConclusao = projetoConclusao;
            CargaHorariaEstagio = cargaHorariaEstagio;
        }
        public string GetProjetoConclusao()
        {
            return ProjetoConclusao;
        }
        public void SetProjetoConclusao(string projetoConclusao)
        {
            ProjetoConclusao = projetoConclusao;
        }
        public int GetCargaHorariaEstagio()
        {
            return CargaHorariaEstagio;
        }
        public void SetCargaHorariaEstagio(int cargaHorariaEstagio)
        {
            CargaHorariaEstagio = cargaHorariaEstagio;
        }
        public void CalcularMensalidade(double fator)
        {
            Mensalidade = (Duracao * fator * 8) + (CargaHorariaEstagio * 12);
        }
        public override void DefinirDuracao()
        {
            var descricaoParaVerificacao = GetDescricao();
            var resultadoVerificacao = descricaoParaVerificacao.Contains("Engenharia");
            if (resultadoVerificacao == true)
            {
                SetDuracao(60);
            }
            else
            {
                SetDuracao(48);
            }
        }
    }
}