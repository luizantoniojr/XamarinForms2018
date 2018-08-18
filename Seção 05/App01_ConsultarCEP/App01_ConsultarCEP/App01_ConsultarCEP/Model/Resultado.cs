namespace App01_ConsultarCEP.Model
{
    public class Resultado
    {
        public bool EhValido { get { return string.IsNullOrEmpty(MensagemErro); } }
        public string MensagemErro { get; set; }
        public ViaCepRetorno Endereco { get; set; }
    }
}
