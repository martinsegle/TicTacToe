

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
    }
}
