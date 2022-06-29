

namespace TicTacToe
{
    public class NotHumanException : Exception
    {
        public NotHumanException()
        {

        }
        public NotHumanException(string message) : base(message)
        {

        }
        public NotHumanException(string message, Exception inertException)
            : base(message, inertException)
        {

        }
    }
}
