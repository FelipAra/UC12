using Tester.Core;
using Xunit;

namespace TestsXUnit
{
    public class OperacoesTests
    {
        // método de teste
        [Fact]
        // descricao do teste
        public void CalcularIMC()
        {
            // arrange – organizar, preparar o teste
            double peso = 60;
            double altura = 1.7;

            // act – agir – execução/chamada do método

            var resultado = Operacoes.Calculo(peso, altura);

            // Assert – comportamento esperado, comportamento obtido

        Assert.Equal(20.761245674740486, resultado);
        }

        [Theory]
        [InlineData(75, 1.78, 23.671253629592222)]
        public void
        SomarDoisNumeros_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            var resultadoDaSoma = Operacoes.Calculo(primeiroNumero, segundoNumero);
            Assert.Equal(resultadoEsperado, resultadoDaSoma);
        }
    }
}