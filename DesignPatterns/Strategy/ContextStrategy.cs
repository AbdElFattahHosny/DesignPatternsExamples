using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ContextStrategy
    {
        private  ICompression compression;

        public ContextStrategy(ICompression compression)
        {
            this.compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            this.compression = compression;
        }

        public void CreateArchive(string name)
        {
            compression.CompressFolder(name);
        }
    }
}
