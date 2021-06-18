namespace IdadeComMoqTeste
{
    public class PessoaTeste
    {
        [Theory]
        [InlineData]("Max", 23, "é número primo")
        [InlineData]("Lucas", 30, "Não é número primo")
        [InlineData]("Maria", 17, "é número primo")
        [InlineData]("josé", 16, "Não é número primo")
        
        public void VerificaIdade(String Nome, int idade)
        {
            //Arrange
            Pessoa pessoa = new(Nome, idade);
          

            Mock<Pessoa.IVerificaIdade> mock = new Mock<Pessoa.IVerificaIdade>();
            mock.Setup(m => m.VerificaIdade(pessoa)).Returns("é primo");


            //Act
            Pessoa verifica = new Pessoa();

            var idadeEsperada = mock.Object.VerificaIdade(pessoa);
            var idade = verifica.VerificaIdade(pessoa);

            //Assert
            Assert.Equal(idade, idadeEsperada);

        }

    }    }
