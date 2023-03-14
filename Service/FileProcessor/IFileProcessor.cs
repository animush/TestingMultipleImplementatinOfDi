using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FileProcessor
{
    public interface IFileProcessor
    {
        string ProcessFile(bool IsLarge);
    }
}
