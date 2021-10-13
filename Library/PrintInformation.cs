using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintInformation
{
    public class PrintInformation<T>
    {
        public int EndNumber { get; set; }
        public T WordFor3 { get; set; }
        public T WordFor5 { get; set; }
    }
}
