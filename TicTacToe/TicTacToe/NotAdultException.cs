

namespace TicTacToe
{
    public class NotAdultException : Exception
    {
        public NotAdultException()
        {

        }
        public NotAdultException(string message) : base(message)
        {

        }
        public NotAdultException(string message, Exception inertException)
            : base(message, inertException)
        {

        }
    }
}
