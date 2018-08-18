using App01_ConsultarCEP.Model;

namespace App01_ConsultarCEP.Interface
{
    public interface IViaCepService
    {
        Resultado BuscarEnderecoViaCep(Cep cep);
    }
}
