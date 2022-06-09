

namespace TicTacToe.Test
{
    public class PlayerTest
    {
        [Fact]
       public void ChangeTurn_whenGivX_ThenReturn0()
        {
            char expected = 'O';
            Assert.Equal(expected, Player.ChangeTurn('X'));
        }
        [Fact]
        public void ChangeTurn_whenGiv0_ThenReturnX()
        {
            char expected = 'X';
            Assert.Equal(expected, Player.ChangeTurn('O'));
        }
    }
}
