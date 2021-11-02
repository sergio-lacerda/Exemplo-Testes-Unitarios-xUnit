using System;
using System.Collections.Generic;
using System.Text;
using App_Exemplo_Teste_XUnit;
using Xunit;

namespace App_Exemplo_Teste_XUnit_Test
{
    public class OperacoesUnitTest
    {
        //******** Exemplos de testes sem parâmetros - Fact  *********

        [Fact]
        public void deveSomarDoubleRetornarDouble()
        {
            //Arrange
            var valor1 = 5.9;
            var valor2 = 9.1;
            var esperado = 15;

            //Act
            var obtido = Operacoes.somar(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void deveSubrairDoubleRetornarDouble()
        {
            //Arrange
            var valor1 = 3.5;
            var valor2 = 2.4;
            var esperado = 1.1;

            //Act
            var obtido = Operacoes.subtrair(valor1, valor2);

            //Assert
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void deveMultiplicarDoubleRetornarDouble()
        {
            //Arrange
            var valor1 = 2.36;
            var valor2 = 5.81;
            //O valor exato seria 13.7116, mas queremos apenas com 2 casas decimais.
            var esperado = 13.71;   

            //Act
            var obtido = Operacoes.multiplicar(valor1, valor2);

            //Assert
            //Colocamos um 3º parâmetro dizendo quantas casas decimais estamos comparando
            Assert.Equal(esperado, obtido, 2);
        }

        [Fact]
        public void deveDividirDoubleRetornarDouble()
        {
            //Arrange
            var valor1 = -1;
            var valor2 = 3;
            //O valor exato seria -0.3333333..., mas queremos apenas com 3 casas decimais.
            var esperado = -0.333;

            //Act
            var obtido = Operacoes.dividir(valor1, valor2);

            //Assert
            //Colocamos um 3º parâmetro dizendo quantas casas decimais estamos comparando
            Assert.Equal(esperado, obtido, 3);
        }

        //******** Exemplos de testes com parâmetros - Theory  *********

        [Theory]
        [InlineData(0.0, -5.6, -5.6)]
        [InlineData(3.1, 0.9, 4)]
        [InlineData(10.99, 3.687, 14.677)]
        public void deveSomar2DoubleRetornarDouble(double v1, double v2, double esperado)
        {
            //Act
            var obtido = Operacoes.somar(v1, v2);

            //Assert            
            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(10.0, 4.0, 6.0)]
        [InlineData(13.5, 3.4, 10.1)]
        [InlineData(-3, -5, 2)]
        public void deveSubtrarir2DoubleRetornarDouble(double v1, double v2, double esperado)
        {
            //Act
            var obtido = Operacoes.subtrair(v1, v2);

            //Assert            
            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(10.0, 4.0, 40.0)]
        [InlineData(13.5, 3.4, 45.9)]
        [InlineData(-3, -5, 15)]
        [InlineData(short.MaxValue, 0.001, 32.767)]
        public void deveMultiplicar2DoubleRetornarDouble(double v1, double v2, double esperado)
        {
            //Act
            var obtido = Operacoes.multiplicar(v1, v2);

            //Assert            
            Assert.Equal(esperado, obtido);
        }

        [Theory]
        [InlineData(10.0, 4.0, 2.50)]
        [InlineData(13.5, 3.4, 3.97)]
        [InlineData(-3, -5, 0.60)]
        public void deveDividir2DoubleRetornarDouble(double v1, double v2, double esperado)
        {
            //Act
            var obtido = Operacoes.dividir(v1, v2);

            //Assert            
            Assert.Equal(esperado, obtido, 2);  //Testando com 2 casas decimais
        }

    }
}
