using App01_ConsultarCEP.Interface;
using App01_ConsultarCEP.Model;

namespace App01_ConsultarCEP.Service
{
    public class ViaCepService : IViaCepService
    {
        private const string URL = "http://viacep.com.br/ws/{0}/json/";

        public void BuscarEnderecoViaCep(Cep cep)
        {
            if (ValidarCEP(cep))
            {

            }
        }

        public bool ValidarCEP(Cep cep) => cep.EhValido;
    }
}
