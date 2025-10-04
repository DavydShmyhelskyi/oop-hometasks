using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Interfaces
{
    public interface IExportable
    {
        void Export(List<Book> books, string filePath);
    }
}
