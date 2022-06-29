namespace TicTacToe
{
    public class StringTooLongException : Exception
    {
        public StringTooLongException()
        {

        }
        public StringTooLongException(string message) : base(message)
        {

        }
        public StringTooLongException(string message, Exception inertException)
            : base(message, inertException)
        {

        }
    }
}
