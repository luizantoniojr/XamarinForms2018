using App01_ConsultarCEP.Interface;
using App01_ConsultarCEP.Model;
using Newtonsoft.Json;
using System.Net;

namespace App01_ConsultarCEP.Service
{
    public class ViaCepService : IViaCepService
    {
        private const string URLBase = "http://viacep.com.br/ws/{0}/json/";

        public Resultado BuscarEnderecoViaCep(Cep cep)
        {
            if (ValidarCEP(cep))
            {
                var url = string.Format(URLBase, cep);
                try
                {
                    using (var webClient = new WebClient())
                    {
                        var retorno = webClient.DownloadString(url);
                        var endereco = JsonConvert.DeserializeObject<ViaCepRetorno>(retorno);
                        if (!endereco.Erro)
                            return new Resultado() { Endereco = endereco };
                        else
                            return new Resultado() { MensagemErro = "CEP não encontrado" };
                    }
                }
                catch (WebException)
                {
                    return new Resultado() { MensagemErro = "Não foi possível acessar a internet" };
                }
            }

            return new Resultado() { MensagemErro = "CEP inválido" };
        }

        public bool ValidarCEP(Cep cep) => cep.EhValido;
    }
}
