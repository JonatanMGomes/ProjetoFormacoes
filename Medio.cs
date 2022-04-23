namespace ProjetoFormacoes
{
    public class Medio : Formacao
    {
        private string Tipo { get; set; }
        public Medio(string descricao, int periodo, string tipo) : base(descricao, periodo)
        {
            Tipo = tipo;
        }
        public string GetTipo()
        {
            return Tipo;
        }
        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }
        public override void CalcularMensalidade(double fator)
        {
            Mensalidade = Duracao * fator * 7;
        }
        public override void DefinirDuracao()
        {
            SetDuracao(36);
        }
         public override void ExibirDados(){
            Console.WriteLine($"Descrição: {Descricao}. No periodo: {Periodo} e do tipo:{Tipo}");
        }
    }
}