namespace ProjetoFormacoes
{
    public class Tecnologo : Formacao
    {
        private bool PlanoEstendido { get; set; }
        public Tecnologo(string descricao, int periodo, bool planoEstendido) : base(descricao, periodo){
            PlanoEstendido = planoEstendido;
        }
        public bool GetPlanoEstendido(){
            return PlanoEstendido;
        }
        public void SetPlanoEstendido(bool planoEstendido){
            PlanoEstendido = planoEstendido;
        }
    }
}