using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_Ba_Dien_Thoai
{
    internal class Ten
    {
        string _ten;
        public Ten()
        {
            _ten = "";
        }
        public Ten(string ten)
        {
            _ten = ten;
        }   
        public string HoVaTen
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public static List<Ten> getName(List<DanhBa> ds)
        {
            List<Ten> dsname =new List<Ten>();  

            foreach (DanhBa d in ds)
            {
                Ten t = new Ten(d.HoVaTen);
                dsname.Add(t);
            } 
            return dsname;
        }

    }
}
