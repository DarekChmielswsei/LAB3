using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Create);
            writer = new StreamWriter(stream);
        }

        ~FileLogger()
        {
            Dispose(disposing: false);
        }

        public override void Dispose()
        {
            writer.Close();
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
                disposed = true;
            }
        }
    }
}
