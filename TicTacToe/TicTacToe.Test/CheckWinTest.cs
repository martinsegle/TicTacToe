using Xunit;
using static TicTacToe.GameBoard;

namespace TicTacToe.Test
{
    public class CheckWinTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange - da�a kur� m�s sagatavojamies funkcion�lai izpild��anai
            int number = 3;
            // Act - da�a kur� m�s izpildam konkr�tu funkciju
            string checkWin = CheckWin.Get(number);
            //Assert da�a kur� m�s p�rliecin�mies, ka funkc. ir korekti nostr�d�jusi
            //vai atgriezusi pareizo rezult�tu
            Assert.Equal("Fizz", checkWin);
        }
    }
}