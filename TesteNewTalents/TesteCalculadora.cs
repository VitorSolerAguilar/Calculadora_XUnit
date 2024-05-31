using NewTalents;

namespace TesteNewTalents
{
    public class TesteCalculadora
    {
        private Calculadora _calc = new Calculadora();

        [Theory]
        [InlineData(1,2,3)]
        public void Somar1Com2Retorno3(int num1, int num2, int resultado)
        {
            int resultadoCalculadora = _calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        public void Subtrair2Com1Retorno1(int num1, int num2, int resultado)
        {
            int resultadoCalculadora = _calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        public void Multiplicar2Com1Retorno2(int num1, int num2, int resultado)
        {
            int resultadoCalculadora = _calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        public void Dividir6Com2Retorno3(int num1, int num2, int resultado)
        {
            int resultadoCalculadora = _calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void DivisaoPor0()
        {
            //Trata exceção de divisão por 0
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(3, 2);
            _calc.Somar(7, 2);
            _calc.Somar(9, 2);

            var lista = _calc.Historico();

            Assert.NotEmpty(_calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}