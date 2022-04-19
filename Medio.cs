namespace ProjetoFormacoes
{
    public class Medio : Formacao
    {
        private string Tipo { get; set; }
        public Medio(string descricao, int periodo, string tipo) : base(descricao, periodo){
            Tipo = tipo;
        }
        public string GetTipo(){
            return Tipo;
        }
        public void SetTipo(string tipo){
            Tipo = tipo;
        }
        public void CalcularMensalidade(double fator){
            Mensalidade = Duracao * fator * 7;
        }
    }
}