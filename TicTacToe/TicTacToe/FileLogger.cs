using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"log.txt", message + Environment.NewLine);
            // failss mums ir log.txt - teksta fails
            //NewLine pielīmē mums tekstam kāt jaunu līniju
        }
    }
}
