using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Modules
{
    class XLLOAISANPHAM : XLBANG
    {
        public XLLOAISANPHAM() : base("LOAISP") { }
        public XLLOAISANPHAM(string pQuery) : base("LOAISP", pQuery) { }
    }
}
