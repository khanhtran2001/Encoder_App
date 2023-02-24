using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary 
{
    class QRGenerator : IHeader,IFooter,IOptimazationAction
    {
        string rawContent { get; set; }
        public void getFooterContent()
        {
            throw new NotImplementedException();
        }

        public IHeader getHeader()
        {
            throw new NotImplementedException();
        }

        public void getHeaderContent()
        {
            throw new NotImplementedException();
        }

        public string optimize(string content)
        {
            throw new NotImplementedException();
        }

        void addHeader(IHeader header)
        {

        }
        
        void setFooter(IFooter footer)
        {

        }
        
        void generate()
        {

        }
    }
}


