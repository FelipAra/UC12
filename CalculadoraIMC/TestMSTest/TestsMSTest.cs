using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tester.Core;

namespace TestMSTest
{
    // classe de testes que você queira executar
    [TestClass]
    public class OperacoesTests
    {
        // método de teste
        [TestMethod]
        // descricao do teste
        public void CalcularIMC_RetornaResultado()
        {
            // arrange – organizar, preparar o teste
            double peso = 60;
            double altura = 1.7;
            // act – agir – execução/chamada do método
            var resultado = Operacoes.Calculo(peso, altura);
            // Assert – comportamento esperado, comportamento obtido
            Assert.AreEqual(20.761245674740486, resultado);
        }
    }
}