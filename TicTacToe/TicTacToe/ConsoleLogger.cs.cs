

namespace TicTacToe
{
    // mēs gribam, lai Console implomentē Ilogger
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

