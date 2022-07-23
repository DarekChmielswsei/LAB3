using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime time = DateTime.Now; // Uzupełnić to miejsce o logikę zapisu opartą o TextWriter ...
            writer.Write(time.ToString("yyyy-MM-ddTHH:mm:sszzz") + " ");
            foreach (string message in messages)
            {
                writer.Write(message + " ");
            }
            writer.Write("\n");

            writer.Flush();
        }

        public abstract void Dispose();
    }
}
