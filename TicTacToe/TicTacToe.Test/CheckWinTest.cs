using Xunit;
using static TicTacToe.GameBoard;

namespace TicTacToe.Test
{
    public class CheckWinTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange - daïa kurâ mçs sagatavojamies funkcionâlai izpildîðanai
            int number = 3;
            // Act - daïa kurâ mçs izpildam konkrçtu funkciju
            string checkWin = CheckWin.Get(number);
            //Assert daïa kurâ mçs pârliecinâmies, ka funkc. ir korekti nostrâdâjusi
            //vai atgriezusi pareizo rezultâtu
            Assert.Equal("Fizz", checkWin);
        }
    }
}