using System;
using Xunit;

namespace NumeralRomano.Tests
{
    public class TestNumeroRomanoConversor
    {
        private NumeralRomanoConversor _numeroRomanoConversor;

        public TestNumeroRomanoConversor()
        {
            _numeroRomanoConversor = new NumeralRomanoConversor();
        }


        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(443, "CDXLIII")]
        [InlineData(500, "D")]
        [InlineData(628, "DCXXVIII")]
        [InlineData(898, "DCCCXCVIII")]
        [InlineData(1000, "M")]
        [InlineData(1398, "MCCCXCVIII")]
        [InlineData(1888, "MDCCCLXXXVIII")]
        [InlineData(2000, "MM")]
        [InlineData(2273, "MMCCLXXIII")]
        [InlineData(2878, "MMDCCCLXXVIII")]
        [InlineData(3000, "MMM")]
        public void ValidaValor(int numero, string resultado)
        {
            Assert.True(_numeroRomanoConversor.InteiroParaRomano(numero) == resultado);
        }

        [Fact]
        public void ValidaExcecoes()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => _numeroRomanoConversor.InteiroParaRomano(-10));
            Assert.Equal("Só é possível inserir um valor entre 0 e 3000", ex.Message);

            Exception ex2 = Assert.Throws<ArgumentException>(() => _numeroRomanoConversor.InteiroParaRomano(4000));
            Assert.Equal("Só é possível inserir um valor entre 0 e 3000", ex2.Message);
        }
    }
}
