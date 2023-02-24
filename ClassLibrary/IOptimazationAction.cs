using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IOptimazationAction : IHeader
    {
        string optimize(string content);
        IHeader getHeader(); 
    }
}
