using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_Ba_Dien_Thoai
{
    internal class SDT
    {
        string _SDT;
        public SDT()
        {
            _SDT = "";
        }
        public SDT(string sdt)
        {
            _SDT = sdt;
        }
        public string SoDienThoai
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public static List<SDT> getSDT(List<DanhBa> ds)
        {
            List<SDT> dsSDT = new List<SDT>();

            foreach (DanhBa d in ds)
            {
                SDT s = new SDT(d.SoDienThoai);
                dsSDT.Add(s);
            }
            return dsSDT;
        }

    }
}
