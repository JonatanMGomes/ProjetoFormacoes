namespace ProjetoFormacoes
{
    public class Bacharelado : Formacao
    {
        private string ProjetoConclusao { get; set; }
        private int CargaHorariaEstagio { get; set; }
        public Bacharelado(string descricao, int periodo, int cargaHorariaEstagio) : base(descricao, periodo){
            CargaHorariaEstagio = cargaHorariaEstagio;
        }
        public string GetProjetoConclusao(){
            return ProjetoConclusao;
        }
        public void SetProjetoConclusao(string projetoConclusao){
            ProjetoConclusao = projetoConclusao;
        }
        public int GetCargaHorariaEstagio(){
            return CargaHorariaEstagio;
        }
        public void SetCargaHorariaEstagio(int cargaHorariaEstagio){
            CargaHorariaEstagio = cargaHorariaEstagio;
        }
    }
}