using ExBhaskara;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-10, 10)]
        [InlineData(1, -7)]
        [InlineData(-4, -4)]
        public void TesteCalculo(float a, float b, float c,  float resultadodoteste)
        {
            //arrange
            float resultado =((b * b) - (4 * a * c)) ;

            Exercicio ExercicioTeste = new Exercicio();
            //act
            resultado = ExercicioTeste.Calculo((b * b) - (4 * a * c));
            //assert
            Assert.Equal(resultado, resultadodoteste);

        }
    }
}
}
