using System.Text.RegularExpressions;

namespace App01_ConsultarCEP.Model
{
    public struct Cep
    {
        private readonly string _valor;
        public readonly bool EhValido;

        public Cep(string valor)
        {
            _valor = valor;

            if (valor == null)
            {
                EhValido = false;
                return;
            }

            var Rgx = new Regex("^\\d{5}-\\d{3}$");

            if (!Rgx.IsMatch(valor))
                EhValido = false;
            else
                EhValido = true;
        }

        public static implicit operator Cep(string valor) => new Cep(valor);

        public override string ToString() => _valor;
    }
}
