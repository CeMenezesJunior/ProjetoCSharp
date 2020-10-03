using System;
using System.Threading;
using Xunit;

namespace ProjetoCSharpUnitTest
{
    public class ProjectCSharpTests
    {
        [Fact]
        public void FibonacciPoucasIteracoes()
        {
            var iteracoes = 5;
            var valorEsperado = 8;

            var Fibonacci = ProjetoCSharp.Fibonacci.CalculaFibonacci(iteracoes);

            Assert.Equal(valorEsperado, Fibonacci);
        }
        [Fact]
        public void FibonacciDe1Iteracao()
        {
            var iteracao = 1;
            var valorEsperado = 1;

            var Fibonacci = ProjetoCSharp.Fibonacci.CalculaFibonacci(iteracao);

            Assert.Equal(valorEsperado, Fibonacci);
        }
        [Fact]
        public void StackOverflowFibonacci()
        {
            var iteracoes = 25;

            Action act = () => ProjetoCSharp.Fibonacci.CalculaFibonacci(iteracoes);

            StackOverflowException exception = Assert.Throws<StackOverflowException>(act);

            Assert.Equal("Stack Overflow", exception.Message);
        }

    }
}
