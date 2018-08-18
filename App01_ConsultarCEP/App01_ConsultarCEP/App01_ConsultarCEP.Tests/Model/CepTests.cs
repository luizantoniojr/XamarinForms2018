using App01_ConsultarCEP.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App01_ConsultarCEP.Tests.Model
{
    [TestClass]
    public class CepTests
    {
        [TestMethod]
        public void DeveValidarCEPComValorInformadoViaConstrutor()
        {
            var valorCEP = "36087-365";

            var cep = new Cep(valorCEP);

            Assert.IsTrue(cep.EhValido);
        }

        [TestMethod]
        public void DeveValidarCEPComValorAtribuido()
        {
            var valorCEP = "36087-365";
            var cep = new Cep();

            cep = valorCEP;

            Assert.IsTrue(cep.EhValido);
        }
    }
}
