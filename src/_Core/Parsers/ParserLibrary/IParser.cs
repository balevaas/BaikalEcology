using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLibrary
{
    public interface IParser
    {
        bool GoodString(string line);
    }
}
